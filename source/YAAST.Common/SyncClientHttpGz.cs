using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace YAAST
{
    public class SyncClientHttpGz: SyncClient
    {
        private string _HttpAddress;
        private string _AddonDirectory;

        public SyncClientHttpGz(string httpAddress, string addonDirectory)
        {
            _HttpAddress = httpAddress;
            if (_HttpAddress.EndsWith("/"))
                _HttpAddress = _HttpAddress.Remove(_HttpAddress.Length - 1, 1);

            _AddonDirectory = addonDirectory;
            if (_AddonDirectory.EndsWith("\\"))
                _AddonDirectory = _AddonDirectory.Remove(_HttpAddress.Length - 1, 1);
        }

        protected override Repository OnLoadSourceRepository()
        {
            try
            {
                return HttpManager.DownloadGz(_HttpAddress + "/yaast.xml");
            }
            catch (System.Net.WebException ex)
            {
                System.Net.HttpWebResponse response = ex.Response as System.Net.HttpWebResponse;
                if ((response != null) && (response.StatusCode == System.Net.HttpStatusCode.NotFound))
                    throw new ApplicationException("No YAAST-Repository found at: " + _HttpAddress + "/yaast.xml");
                else
                    throw ex;
            }
        }
        protected override Repository OnLoadTargetRepository()
        {
            if (!Directory.Exists(_AddonDirectory))
                throw new ApplicationException("Addon directory not found: " + _AddonDirectory);

            return Repository.FromDirectory(_AddonDirectory, null);           
        }

        protected override string OnConvertSourcePath(string source)
        {
            return _HttpAddress + source.Replace('|', '/'); 
        }
        protected override string OnConvertTargetPath(string destination)
        {
            return _AddonDirectory + destination.Replace('|', '\\');
        }

        protected override bool OnCopyFiles(string[] sources, string[] targets, DateTime[] lastWriteTimesUtc)
        {
            try
            {
                if (targets != null)
                    foreach (string target in targets)
                        LogList.Info("copy: " + target);
                
                HttpManager.DownloadGz(sources, targets, lastWriteTimesUtc);

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }        
        protected override bool OnDeleteTargetFiles(string[] filenames)
        {
            try
            {
                if (filenames != null)
                    foreach (string filename in filenames)
                        LogList.Info("delete: " + filename);

                for (int i = 0; i < filenames.Length; i++)
                    File.Delete(filenames[i]);

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }
        protected override bool OnDeleteTargetDirectorys(string[] directorynames)
        {
            try
            {
                if (directorynames != null)
                    foreach (string directoryname in directorynames)
                        LogList.Info("delete: " + directoryname);
                for (int i = 0; i < directorynames.Length; i++)
                    Directory.Delete(directorynames[i]);

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }
        protected override bool OnCreateTargetDirectorys(string[] directorynames)
        {
            try
            {
                if (directorynames != null)
                    foreach (string directoryname in directorynames)
                        LogList.Info("create: " + directoryname);
                for (int i = 0; i < directorynames.Length; i++)
                    Directory.CreateDirectory(directorynames[i]);

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }
    }
}
