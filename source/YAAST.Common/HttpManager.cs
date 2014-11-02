using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace YAAST
{
    public static class HttpManager
    {
        #region nLog instance (LOG)
        private static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion
		
        #region private class DownloadAsyncState
        private class DownloadAsyncState
        {
            public string Filename;
            public WebRequest WebRequest;
            public System.Threading.ManualResetEvent Event = new System.Threading.ManualResetEvent(false);
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
       
        public static void DownloadGz(string[] urls, string[] localFilenames, DateTime[] lastWriteTimesUtc)
        {
            if ((urls == null) || (localFilenames == null) || (lastWriteTimesUtc == null) || (urls.Length == 0) || (localFilenames.Length != urls.Length) || (lastWriteTimesUtc.Length != urls.Length))
                throw new ArgumentException();

            DownloadAsyncState[] downloadAsyncState = new DownloadAsyncState[localFilenames.Length];     
            for (int i = 0; i < localFilenames.Length; i++)
            {
                WebRequest request = WebRequest.Create(urls[i] + ".gz");
                request.Credentials = CredentialCache.DefaultCredentials;

                downloadAsyncState[i] = new DownloadAsyncState();
                downloadAsyncState[i].Filename = localFilenames[i];
                downloadAsyncState[i].WebRequest = request;

                request.BeginGetResponse(new AsyncCallback(DownloadGz_EndGetResponseCallback), downloadAsyncState[i]);
            }

            for (int i = 0; i < localFilenames.Length; i++)
                downloadAsyncState[i].Event.WaitOne();

            for(int i = 0; i < localFilenames.Length; i++)
                File.SetLastWriteTimeUtc(localFilenames[i], lastWriteTimesUtc[i]);                
        }
        private static void DownloadGz_EndGetResponseCallback(IAsyncResult ar)
        {
            DownloadAsyncState state = ar.AsyncState as DownloadAsyncState;

            try
            {
                using (WebResponse response = state.WebRequest.EndGetResponse(ar))
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
