//#define SYNCEXECUTOR_SIMULATE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PALAST
{
    public class SyncServerFtpGz : SyncServer
    {
        private string _SourcePath;
        private string _FtpPath;
        private FtpManager _FtpManager;
        private string[] _SelectedAddons;

        public SyncServerFtpGz(string sourcePath, string address, string username, string password, bool passive,  int connectionLimit, string[] selectedAddons)
        {
            _SourcePath = sourcePath;
            if (_SourcePath.EndsWith("\\"))
                _SourcePath = _SourcePath.Remove(_SourcePath.Length - 1, 1);

            _FtpPath = address;
            if (_FtpPath.EndsWith("/"))
                _FtpPath = _FtpPath.Remove(_FtpPath.Length - 1, 1);

            _SelectedAddons = selectedAddons;

            _FtpManager = new FtpManager(username, password, passive);
            _FtpManager.ConnectionLimit = connectionLimit;
            _FtpManager.Passive = passive;
        }

        protected override Repository OnLoadSourceRepository()
        {
            if (!Directory.Exists(_SourcePath))
                throw new ApplicationException("Addon directory not found: " + _SourcePath);

            return Repository.FromDirectory(_SourcePath, _SelectedAddons);
        }
        protected override Repository OnLoadTargetRepository()
        {
            try
            {
                return _FtpManager.DownloadGz(_FtpPath + "/yaast.xml");
            }
            catch (System.Net.WebException ex)
            {
                System.Net.FtpWebResponse response = ex.Response as System.Net.FtpWebResponse;
                if ((response != null) && (response.StatusCode == System.Net.FtpStatusCode.ActionNotTakenFileUnavailable))
                {
                    // Fragen ob ein neues Repo erstellt werden soll, oder nicht.
                    DialogResult result = MessageBox.Show("There is no repository at the specified address. Create a new repository?", "Warning", MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                        throw new ApplicationException("Operation aborted");

                    // Neues Repo erstellen
                    Repository repository = new Repository();
                    repository.Addons = new Repository.Directory();
                    repository.Addons.Name = "";
                    return repository;
                }
                else
                    throw ex;
            }
        }
        protected override void OnUpdateTargetRepositoryXml(Repository repository)
        {
            _FtpManager.UploadGz(repository, _FtpPath + "/yaast.xml");
        }

        protected override string OnConvertSourcePath(string source)
        {
            return _SourcePath + source.Replace('|', '\\');
        }
        protected override string OnConvertTargetPath(string destination)
        {
            return _FtpPath + destination.Replace('|', '/');
        }

        protected override bool OnCopyFiles(string[] sources, string[] targets, DateTime[] lastWriteTimesUtc) 
        {
            try
            {
                //for (int i = 0; i < sources.Length; i++)
                //    _FtpManager.UploadGz(sources[i], targets[i]);

                _FtpManager.UploadGz(sources, targets);
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
                _FtpManager.MakeDirectory(directorynames);

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
                _FtpManager.RemoveFileGz(filenames);

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
                _FtpManager.RemoveDirectory(directorynames);

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
