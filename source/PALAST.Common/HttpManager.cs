using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace PALAST
{
    public static class HttpManager
    {
        #region nLog instance (LOG)
        private static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion       

        #region private class HttpWebRequestUserState
        private class HttpWebRequestUserState
        {
            public const int SIZE = 131744 * 4;
            public byte[] Buffer = new byte[SIZE];
            public System.Threading.ManualResetEvent Finished;

            public TrackedDownload TrackedDownload;
            public HttpWebRequest HttpWebRequest;
            public Stream ResponseStream;
            public FileStream FileStream;
            public long BytesTotal;
            public long BytesRead;
            public DateTime StartTime;
            public bool Successfull = false;

            public HttpWebRequestUserState(HttpWebRequest httpWebRequest, TrackedDownload trackedDownload)
            {
                this.TrackedDownload = trackedDownload;
                this.HttpWebRequest = httpWebRequest;
                this.Finished = new System.Threading.ManualResetEvent(false);
                this.FileStream = new FileStream(this.TrackedDownload._Target + ".gz", FileMode.Create);
            }
        }
        #endregion
        public static void DownloadGz_HttpWebRequest(TrackedDownload trackedDownload)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(trackedDownload._Source + ".gz");
            request.Proxy = null;
            request.ServicePoint.ConnectionLimit = 4;
            request.ServicePoint.Expect100Continue = false;
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ConnectionGroupName = "MyConnectionGroupname";

            HttpWebRequestUserState userState = new HttpWebRequestUserState(request, trackedDownload);
            request.BeginGetResponse(new AsyncCallback(DownloadGz_HttpWebRequest_OnBeginGetResponseCallback), userState);

            userState.Finished.WaitOne();
        }
        public static bool DownloadGz_HttpWebRequest(TrackedDownload[] trackedDownloads)
        {
            HttpWebRequestUserState[] userStates = new HttpWebRequestUserState[trackedDownloads.Length];
            for (int i = 0; i < trackedDownloads.Length; i++)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(trackedDownloads[i]._Source + ".gz");
                request.Proxy = null;
                request.ServicePoint.ConnectionLimit = 4;
                request.ServicePoint.Expect100Continue = false;
                request.Credentials = CredentialCache.DefaultCredentials;
                request.ConnectionGroupName = "DownloadGz_HttpWebRequestArray";

                userStates[i] = new HttpWebRequestUserState(request, trackedDownloads[i]);
                request.BeginGetResponse(new AsyncCallback(DownloadGz_HttpWebRequest_OnBeginGetResponseCallback), userStates[i]);
            }

            for (int i = 0; i < trackedDownloads.Length; i++)
                userStates[i].Finished.WaitOne();

            for (int i = 0; i < trackedDownloads.Length; i++)
                if (!userStates[i].Successfull)
                    return false;

            return true;
        }
        private static void DownloadGz_HttpWebRequest_OnBeginGetResponseCallback(IAsyncResult ar)
        {
            HttpWebRequestUserState userState = ar.AsyncState as HttpWebRequestUserState;

            try
            {
                HttpWebResponse httpWebResponse = (HttpWebResponse)userState.HttpWebRequest.EndGetResponse(ar);
                userState.BytesTotal = httpWebResponse.ContentLength;
                userState.BytesRead = 0;
                userState.StartTime = DateTime.Now;
                userState.ResponseStream = httpWebResponse.GetResponseStream();
                userState.ResponseStream.BeginRead(userState.Buffer, 0, HttpWebRequestUserState.SIZE, new AsyncCallback(DownloadGz_HttpWebRequest_OnBeginReadCallback), userState);
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                #region userState.FileStream.Close();
                try
                {

                    if (userState.FileStream != null)
                        userState.FileStream.Close();
                }
                catch
                {
                }
                #endregion
                #region userState.ResponseStream.Close();
                try
                {
                    if (userState.ResponseStream != null)
                        userState.ResponseStream.Close();
                }
                catch
                {
                }
                #endregion
                #region File.Delete(userState.TrackedDownload._Target + ".gz");
                try
                {
                    File.Delete(userState.TrackedDownload._Target + ".gz");
                }
                catch
                {
                }
                #endregion
                userState.Successfull = false;
                userState.Finished.Set();
            }
        }
        private static void DownloadGz_HttpWebRequest_OnBeginReadCallback(IAsyncResult ar)
        {
            HttpWebRequestUserState userState = ar.AsyncState as HttpWebRequestUserState;
            try
            {

                TimeSpan totalTime = DateTime.Now - userState.StartTime;
                int bytesRead = userState.ResponseStream.EndRead(ar);
                if (bytesRead > 0)
                {
                    userState.BytesRead += bytesRead;
                    //Console.WriteLine(bytesRead + " - " + userState.Buffer.Length); // zur überwachung der pufferausnutzung
                    userState.FileStream.Write(userState.Buffer, 0, bytesRead);
                    userState.ResponseStream.BeginRead(userState.Buffer, 0, HttpWebRequestUserState.SIZE, new AsyncCallback(DownloadGz_HttpWebRequest_OnBeginReadCallback), userState);

                    //    state.bytesRead += bytesRead;
                    double precent = ((double)userState.BytesRead / (double)userState.BytesTotal) * 100.0f;
                    
                    // Note: bytesRead/totalMS is in bytes/ms.  Convert to kb/sec.
                    double kbPerSec = ((userState.BytesRead / totalTime.TotalSeconds) * 8.0f) / 1024.0f;
                    userState.TrackedDownload.DownloadProgressChanged(new DownloadProgress(precent, kbPerSec, totalTime.TotalSeconds));
                }
                else
                {
                    userState.FileStream.Close();
                    userState.ResponseStream.Close();

                    Decompress(new FileInfo(userState.TrackedDownload._Target + ".gz"));
                    File.SetLastWriteTimeUtc(userState.TrackedDownload._Target, userState.TrackedDownload._LastWriteTimeUtc);
                    userState.TrackedDownload.DownloadProgressChanged(new DownloadProgress(100, 0, totalTime.TotalSeconds));
                    userState.Successfull = true;
                    userState.Finished.Set();
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                #region userState.FileStream.Close();
                try
                {
                    userState.FileStream.Close();
                }
                catch
                {
                }
                #endregion
                #region userState.ResponseStream.Close();
                try
                {
                    userState.ResponseStream.Close();
                }
                catch
                {
                }
                #endregion
                #region File.Delete(userState.TrackedDownload._Target + ".gz");
                try
                {
                    File.Delete(userState.TrackedDownload._Target + ".gz");
                }
                catch
                {
                }
                #endregion
                userState.Successfull = false;
                userState.TrackedDownload.DownloadProgressChanged(new DownloadProgress(100, 0, 0));
                userState.Finished.Set();
            }
        }

        public static Repository DownloadGz(string address)
        {
            WebRequest request = WebRequest.Create(address + ".gz");
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            using (Stream responseStream = response.GetResponseStream())
            {
                using (GZipStream decompressedStream = new GZipStream(responseStream, CompressionMode.Decompress))
                {
                    Repository instance = new System.Xml.Serialization.XmlSerializer(typeof(Repository)).Deserialize(decompressedStream) as Repository;

                    // Parent Referenzen aktualisieren:
                    if ((instance != null) && (instance.Addons != null))
                        instance.Addons.UpdateParentReferences(null);

                    if (instance.Version > Repository.SUPPORTED_VERSION)
                        throw new Exception("Die Version des Repositories wird nicht von dieser Version unterstützt. Aktualisieren Sie Ihre Software.");

                    return instance;
                }
            }
        }

        #region public class VersionUserState
        public class VersionUserState
        {
            public HttpWebRequest HttpWebRequest;
            public VersionEventHandler Callback;

            public VersionUserState(HttpWebRequest httpWebRequest, VersionEventHandler callback)
            {
                this.HttpWebRequest = httpWebRequest;
                this.Callback = callback;
            }
        }
        public delegate void VersionEventHandler(Version version);
        #endregion
        public static void Download_Version(string url, VersionEventHandler callback)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Proxy = null;
            request.ServicePoint.ConnectionLimit = 2;
            request.ServicePoint.Expect100Continue = false;
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ConnectionGroupName = "MyConnectionGroupnamePalastVersion";

            VersionUserState userState = new VersionUserState(request, callback);
            request.BeginGetResponse(new AsyncCallback(Download_Version_OnBeginGetResponseCallback), userState);
        }
        private static void Download_Version_OnBeginGetResponseCallback(IAsyncResult ar)
        {
            VersionUserState userState = ar.AsyncState as VersionUserState;

            try
            {
                HttpWebResponse httpWebResponse = (HttpWebResponse)userState.HttpWebRequest.EndGetResponse(ar);
                using (Stream responseStream = httpWebResponse.GetResponseStream())
                {
                    VersionSerializeable instance = new System.Xml.Serialization.XmlSerializer(typeof(VersionSerializeable)).Deserialize(responseStream) as VersionSerializeable;
                    userState.Callback(instance.ToVersion());                    
                }
            }
            catch (Exception ex)
            {
                userState.Callback(null);
                LOG.Error(ex);
            }
        }

        private static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }

            fileToDecompress.Delete();
        }

        [Obsolete("unused")]
        public static void DownloadGz(string url, string localFilename, DateTime lastWriteTimeUtc)
        {
            WebRequest request = WebRequest.Create(url + ".gz");
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                using (GZipStream decompressedStream = new GZipStream(responseStream, CompressionMode.Decompress))
                {
                    using (FileStream fileStream = File.Create(localFilename))
                    {
                        decompressedStream.CopyTo(fileStream);
                    }
                }
            }

            File.SetLastWriteTimeUtc(localFilename, lastWriteTimeUtc);
        }
    }
}
