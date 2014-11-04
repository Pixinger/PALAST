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

        #region private class WebClientUserState
        private class WebClientUserState
        {
            public TrackedDownload TrackedDownload;
            public System.Threading.ManualResetEvent Finished;
        }
        #endregion
        public static void DownloadGz_WebClient(TrackedDownload trackedDownload)
        {
            WebClientUserState userState = new WebClientUserState();
            userState.Finished = new System.Threading.ManualResetEvent(false);
            userState.TrackedDownload = trackedDownload;
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadGz_WebClient_DownloadProgressChanged);
            webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadGz_WebClient_DownloadFileCompleted);
            webClient.DownloadFileAsync(new Uri(trackedDownload._Source + ".gz"), trackedDownload._Target + ".gz", userState);
            userState.Finished.WaitOne();

            Decompress(new FileInfo(trackedDownload._Target + ".gz"));

            File.SetLastWriteTimeUtc(trackedDownload._Target, trackedDownload._LastWriteTimeUtc);
        }
        private static void DownloadGz_WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            WebClientUserState state = e.UserState as WebClientUserState;
            state.Finished.Set();
        }
        private static void DownloadGz_WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            WebClientUserState state = e.UserState as WebClientUserState;
            state.TrackedDownload.DownloadProgressChanged(new DownloadProgress(e.ProgressPercentage, 0, 0));
        }

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
        public static void DownloadGz_HttpWebRequest(TrackedDownload[] trackedDownloads)
        {
            HttpWebRequestUserState[] userStates = new HttpWebRequestUserState[trackedDownloads.Length];
            for (int i = 0; i < trackedDownloads.Length; i++)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(trackedDownloads[i]._Source + ".gz");
                request.Proxy = null;
                request.ServicePoint.ConnectionLimit = 2;
                request.ServicePoint.Expect100Continue = false;
                request.Credentials = CredentialCache.DefaultCredentials;
                request.ConnectionGroupName = "MyConnectionGroupname";

                userStates[i] = new HttpWebRequestUserState(request, trackedDownloads[i]);
                request.BeginGetResponse(new AsyncCallback(DownloadGz_HttpWebRequest_OnBeginGetResponseCallback), userStates[i]);
            }

            for (int i = 0; i < trackedDownloads.Length; i++)
            {
                userStates[i].Finished.WaitOne();
            }

            for (int i = 0; i < trackedDownloads.Length; i++)
            {
            }
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
            }
        }
        private static void DownloadGz_HttpWebRequest_OnBeginReadCallback(IAsyncResult ar)
        {
            try
            {
                HttpWebRequestUserState userState = ar.AsyncState as HttpWebRequestUserState;

                int bytesRead = userState.ResponseStream.EndRead(ar);
                if (bytesRead > 0)
                {
                    userState.BytesRead += bytesRead;
                    //Console.WriteLine(bytesRead + " - " + userState.Buffer.Length); // zur überwachung der pufferausnutzung
                    userState.FileStream.Write(userState.Buffer, 0, bytesRead);
                    userState.ResponseStream.BeginRead(userState.Buffer, 0, HttpWebRequestUserState.SIZE, new AsyncCallback(DownloadGz_HttpWebRequest_OnBeginReadCallback), userState);

                    //    state.bytesRead += bytesRead;
                    double precent = ((double)userState.BytesRead / (double)userState.BytesTotal) * 100.0f;
                    TimeSpan totalTime = DateTime.Now - userState.StartTime;
                    
                    // Note: bytesRead/totalMS is in bytes/ms.  Convert to kb/sec.
                    double kbPerSec = ((userState.BytesRead / totalTime.TotalSeconds) * 8.0f) / 1024.0f;
                    userState.TrackedDownload.DownloadProgressChanged(new DownloadProgress(precent, kbPerSec, totalTime.TotalSeconds));
                }
                else
                {
                    userState.FileStream.Close();
                    userState.ResponseStream.Close();
                    userState.Finished.Set();

                    Decompress(new FileInfo(userState.TrackedDownload._Target + ".gz"));
                    File.SetLastWriteTimeUtc(userState.TrackedDownload._Target, userState.TrackedDownload._LastWriteTimeUtc);
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
        }

        public static void DownloadGzF(string[] urls, string[] localFilenames, DateTime[] lastWriteTimesUtc)
        {
            if ((urls == null) || (localFilenames == null) || (lastWriteTimesUtc == null) || (urls.Length == 0) || (localFilenames.Length != urls.Length) || (lastWriteTimesUtc.Length != urls.Length))
                throw new ArgumentException();

            DownloadAsyncState[] downloadAsyncState = new DownloadAsyncState[localFilenames.Length];
            for (int i = 0; i < localFilenames.Length; i++)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urls[i] + ".gz");
                request.Credentials = CredentialCache.DefaultCredentials;

                downloadAsyncState[i] = new DownloadAsyncState(request, localFilenames[i]);

                request.BeginGetResponse(new AsyncCallback(DownloadGz_HttpWebRequest_OnBeginGetResponseCallback), downloadAsyncState[i]);
            }

            for (int i = 0; i < localFilenames.Length; i++)
                downloadAsyncState[i].Event.WaitOne();

            for (int i = 0; i < localFilenames.Length; i++)
                File.SetLastWriteTimeUtc(localFilenames[i], lastWriteTimesUtc[i]);
        }
        private static void DownloadGz_EndGetResponseCallbackF(IAsyncResult ar)
        {
            DownloadAsyncState state = ar.AsyncState as DownloadAsyncState;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)state.HttpWebRequest.EndGetResponse(ar))
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (GZipStream decompressedStream = new GZipStream(responseStream, CompressionMode.Decompress))
                        {
                            using (FileStream fileStream = File.Create(state.Filename))
                            {
                                decompressedStream.CopyTo(fileStream);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
            finally
            {
                state.Event.Set();
            }
        }

        #region private class DownloadAsyncState
        private class DownloadAsyncState
        {
            public const int SIZE = 8 * 1024 * 50;

            public string Filename;
            public HttpWebRequest HttpWebRequest;
            public DateTime TransferStart;
            public int BufferSize;
            public byte[] Buffer;
            public System.Threading.ManualResetEvent Event;

            public long TotalBytes = 0;
            public int bytesRead = 0;

            public DownloadAsyncState(HttpWebRequest httpWebRequest, string filename)
            {
                this.Filename = filename;
                this.HttpWebRequest = httpWebRequest;
                this.BufferSize = SIZE;
                this.Buffer = new byte[SIZE];
                this.TransferStart = DateTime.Now;
                this.Event = new System.Threading.ManualResetEvent(false);
            }
        }
        #endregion
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
                        throw new Exception("Downloaded repository version is to new. please update the software");

                    return instance;
                }
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
