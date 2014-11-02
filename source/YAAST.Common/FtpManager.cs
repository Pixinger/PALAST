using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using System.Net;
using System.IO;

namespace YAAST
{
    public class FtpManager
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        #region private class UploadGzState
        private class UploadGzState
        {
            public string Filename;
            public FtpWebRequest FtpWebRequest;
            public System.Threading.ManualResetEvent Event = new System.Threading.ManualResetEvent(false);
        }
        #endregion
        #region private class FtpAsyncState
        private class FtpAsyncState
        {
            public FtpWebRequest FtpWebRequest;
            public System.Threading.ManualResetEvent Event = new System.Threading.ManualResetEvent(false);
        }
        #endregion

        private string _Username;
        private string _Password;
        private bool _Passive;
        private string _ConnectionGroupName;
        private int _ConnectionLimit = 4;

        public FtpManager(string username, string password, bool passive)
        {
            _Username = username;
            _Password = password;
            _Passive = passive;
            _ConnectionGroupName = Guid.NewGuid().ToString();
        }

        private static FtpWebRequest CreateFtpWebRequest(string address, string username, string password, bool passive, int connectionLimit, string connectionGroupName)
        {
            FtpWebRequest ftpWebRequest = (FtpWebRequest)FtpWebRequest.Create(address);
            ftpWebRequest.Credentials = new NetworkCredential(username, password);
            ftpWebRequest.UsePassive = passive;
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.KeepAlive = true;
            ftpWebRequest.ConnectionGroupName = connectionGroupName;
            ftpWebRequest.ServicePoint.Expect100Continue = true;
            ftpWebRequest.ServicePoint.ConnectionLimit = connectionLimit;
            return ftpWebRequest;
        }

        public Repository DownloadGz(string ftpFilename)
        {
            FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpFilename + ".gz", _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
            ftpWebRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            using (FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (MemoryStream decompressedFileStream = new MemoryStream())
                    {
                        using (System.IO.Compression.GZipStream decompressionStream = new System.IO.Compression.GZipStream(responseStream, System.IO.Compression.CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                            decompressedFileStream.Seek(0, SeekOrigin.Begin);
                            Repository instance = new System.Xml.Serialization.XmlSerializer(typeof(Repository)).Deserialize(decompressedFileStream) as Repository;

                            // Parent Referenzen aktualisieren:
                            if ((instance != null) && (instance.Addons != null))
                                instance.Addons.UpdateParentReferences(null);

                            if (instance.Version > Repository.SUPPORTED_VERSION)
                                throw new Exception("Downloaded repository version is to new. please update the software");

                            return instance;
                        }
                    }
                }
            }
        }
        
        public void UploadGz(Repository repository, string ftpFilename)
        {
            LOG.Info(ftpFilename);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Repository));
            FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpFilename + ".gz", _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
            using (Stream reqStream = ftpWebRequest.GetRequestStream())
            {
                using (GZipStream compressionStream = new GZipStream(reqStream, CompressionMode.Compress))
                {
                    serializer.Serialize(compressionStream, repository, null);
                }
            }
        }
        
        public void UploadGz(string[] localFilenames, string[] ftpFilenames)
        {
            if ((ftpFilenames == null) || (localFilenames == null) || (ftpFilenames.Length == 0) || (localFilenames.Length != ftpFilenames.Length))
                throw new ArgumentException();

            UploadGzState[] statesUploadGz = new UploadGzState[localFilenames.Length];
            for (int i = 0; i < localFilenames.Length; i++)
            {
                FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpFilenames[i] + ".gz", _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
                ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;

                UploadGzState stateUploadGz = new UploadGzState();
                stateUploadGz.Filename = localFilenames[i];
                stateUploadGz.FtpWebRequest = ftpWebRequest;
                statesUploadGz[i] = stateUploadGz;

                ftpWebRequest.BeginGetRequestStream(new AsyncCallback(UploadGz_BeginGetRequestStreamCallback), stateUploadGz);
            }
            
            for (int i = 0; i < localFilenames.Length; i++)
               statesUploadGz[i].Event.WaitOne();
        }
        private void UploadGz_BeginGetRequestStreamCallback(IAsyncResult ar)
        {
            UploadGzState stateUploadGz = ar.AsyncState as UploadGzState;
            try
            {
                using (Stream requestStream = stateUploadGz.FtpWebRequest.EndGetRequestStream(ar))
                {
                    using (GZipStream compressionStream = new GZipStream(requestStream, CompressionMode.Compress))
                    {
                        FileInfo fileToCompress = new FileInfo(stateUploadGz.Filename);
                        using (FileStream originalFileStream = fileToCompress.OpenRead())
                        {
                            originalFileStream.CopyTo(compressionStream);
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
                stateUploadGz.Event.Set();
            }
        }

        public void MakeDirectory(string[] ftpDirectory)
        {
            if ((ftpDirectory == null) || (ftpDirectory.Length == 0))
                return;

            // Array für die Asynchronen Zustände
            FtpAsyncState[] ftpAsyncState = new FtpAsyncState[ftpDirectory.Length];

            // Löschen starten
            for (int i = 0; i < ftpDirectory.Length; i++)
            {
                FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpDirectory[i], _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
                ftpWebRequest.Method = WebRequestMethods.Ftp.MakeDirectory;

                ftpAsyncState[i] = new FtpAsyncState();
                ftpAsyncState[i].FtpWebRequest = ftpWebRequest;

                ftpWebRequest.BeginGetResponse(new AsyncCallback(MakeDirectory_BeginGetResponseCallback), ftpAsyncState[i]);
            }

            // Warten bis das Löschen beendet wurde
            for (int i = 0; i < ftpDirectory.Length; i++)
                ftpAsyncState[i].Event.WaitOne();
        }
        private void MakeDirectory_BeginGetResponseCallback(IAsyncResult ar)
        {
            FtpAsyncState ftpAsyncState = ar.AsyncState as FtpAsyncState;
            try
            {
                using (WebResponse response = ftpAsyncState.FtpWebRequest.EndGetResponse(ar))
                {
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
            finally
            {
                ftpAsyncState.Event.Set();
            }
        }
      
        public void RemoveFileGz(string[] ftpFilenames)
        {
            if ((ftpFilenames == null) || (ftpFilenames.Length == 0))
                return;

            // Array für die Asynchronen Zustände
            FtpAsyncState[] ftpAsyncState = new FtpAsyncState[ftpFilenames.Length];

            // Löschen starten
            for (int i = 0; i < ftpFilenames.Length; i++)
            {
                FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpFilenames[i], _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
                ftpWebRequest.Method = WebRequestMethods.Ftp.DeleteFile;

                ftpAsyncState[i] = new FtpAsyncState();
                ftpAsyncState[i].FtpWebRequest = ftpWebRequest;

                ftpWebRequest.BeginGetResponse(new AsyncCallback(RemoveFileGz_BeginGetResponseStreamCallback), ftpAsyncState[i]);
            }

            // Warten bis das Löschen beendet wurde
            for (int i = 0; i < ftpFilenames.Length; i++)
                ftpAsyncState[i].Event.WaitOne();
        }
        private void RemoveFileGz_BeginGetResponseStreamCallback(IAsyncResult ar)
        {
            FtpAsyncState ftpAsyncState = ar.AsyncState as FtpAsyncState;
            try
            {
                using (WebResponse response = ftpAsyncState.FtpWebRequest.EndGetResponse(ar))
                {
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
            finally
            {
                ftpAsyncState.Event.Set();
            }
        }
        
        public void RemoveDirectory(string[] ftpDirectory)
        {
            if ((ftpDirectory == null) || (ftpDirectory.Length == 0))
                return;

            // Array für die Asynchronen Zustände
            FtpAsyncState[] ftpAsyncState = new FtpAsyncState[ftpDirectory.Length];

            // Löschen starten
            for (int i = 0; i < ftpDirectory.Length; i++)
            {
                FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpDirectory[i], _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
                ftpWebRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;

                ftpAsyncState[i] = new FtpAsyncState();
                ftpAsyncState[i].FtpWebRequest = ftpWebRequest;

                ftpWebRequest.BeginGetResponse(new AsyncCallback(RemoveDirectory_BeginGetResponseStreamCallback), ftpAsyncState[i]);
            }

            // Warten bis das Löschen beendet wurde
            for (int i = 0; i < ftpDirectory.Length; i++)
                ftpAsyncState[i].Event.WaitOne();
        }
        private void RemoveDirectory_BeginGetResponseStreamCallback(IAsyncResult ar)
        {
            FtpAsyncState ftpAsyncState = ar.AsyncState as FtpAsyncState;
            try
            {
                using (WebResponse response = ftpAsyncState.FtpWebRequest.EndGetResponse(ar))
                {
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
            finally
            {
                ftpAsyncState.Event.Set();
            }
        }

        public string Username
        {
            get
            {
                return _Username;
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
        }
        public bool Passive
        {
            get
            {
                return _Passive;
            }
            set
            {
                _Passive = value;
            }
        }
        public int ConnectionLimit
        {
            get
            {
                return _ConnectionLimit;
            }
            set
            {
                _ConnectionLimit = value;
            }
        }

        [Obsolete("unused")]
        public void UploadGz(string localFilename, string ftpFilename)
        {
            LOG.Info(ftpFilename);
            FileInfo fileToCompress = new FileInfo(localFilename);
            FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpFilename + ".gz", _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
            
            using (Stream requestStream = ftpWebRequest.GetRequestStream())
            {
                using (GZipStream compressionStream = new GZipStream(requestStream, CompressionMode.Compress))
                {
                    using (FileStream fileStream = fileToCompress.OpenRead())
                    {
                        fileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
        [Obsolete("unused")]
        public void RemoveFileGz(string ftpFilename)
        {
            LOG.Info(ftpFilename);
            FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpFilename + ".gz", _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
            ftpWebRequest.Method = WebRequestMethods.Ftp.DeleteFile;

            using (FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse())
            {
            }
        }
        [Obsolete("unused")]
        public void RemoveDirectory(string ftpDirectory)
        {
            LOG.Info(ftpDirectory);
            FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpDirectory, _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
            ftpWebRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;
            using (FtpWebResponse ftpResponse = (FtpWebResponse)ftpWebRequest.GetResponse())
            {
            }
        }
        [Obsolete("unused")]
        public void MakeDirectory(string ftpDirectory)
        {
            LOG.Info(ftpDirectory);
            FtpWebRequest ftpWebRequest = CreateFtpWebRequest(ftpDirectory, _Username, _Password, _Passive, _ConnectionLimit, _ConnectionGroupName);
            ftpWebRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
            using (FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse())
            {
            }
        }
    }
}
