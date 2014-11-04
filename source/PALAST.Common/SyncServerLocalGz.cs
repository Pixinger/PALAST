using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;

namespace PALAST
{
    public class SyncServerLocalGz : SyncServer
    {
        private string _SourcePath;
        private string _TargetPath;
        private string[] _SelectedAddons;

        public SyncServerLocalGz(string sourcePath, string destinationPath, string[] selectedAddons)
        {
            _SourcePath = sourcePath;
            _TargetPath = destinationPath;
            _SelectedAddons = selectedAddons;
        }

        protected override Repository OnLoadSourceRepository()
        {
            return Repository.FromDirectory(_SourcePath, _SelectedAddons);
        }
        protected override Repository OnLoadTargetRepository()
        {
            if (File.Exists(_TargetPath + "/yaast.xml.gz"))
                return Repository.FromFilenameGz(_TargetPath + "/yaast.xml");
            else
            {
                DialogResult result = MessageBox.Show("There is no repository at the specified address. Create a new repository?", "Warning", MessageBoxButtons.OKCancel);
                if (result != DialogResult.OK)
                    throw new ApplicationException("Operation aborted");

                // Neues Repo erstellen
                Repository repository = new Repository();
                repository.Addons = new Repository.Directory();
                repository.Addons.Name = "";
                return repository;
            }
        }
        protected override bool OnUpdateTargetRepositoryXml(Repository repository)
        {
            try
            {
                repository.SaveGz(_TargetPath + "/yaast.xml");
                return true;
            }
            catch (Exception ex)
            {
                LogList.Error(ex.Message);
                return false;
            }
        }

        protected override string OnConvertSourcePath(string source)
        {
            LOG.Debug(source);
            return _SourcePath + source.Replace('|', '\\');
        }
        protected override string OnConvertTargetPath(string target)
        {
            LOG.Debug(target);
            return _TargetPath + target.Replace('|', '\\');
        }

        protected override bool OnCopyFiles(string[] sources, string[] targets, DateTime[] lastWriteTimesUtc)
        {
            try
            {
                for (int i = 0; i < sources.Length; i++)
                    CopyFileCompressed(sources[i], targets[i], lastWriteTimesUtc[i]);

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
        protected override bool OnDeleteTargetFiles(string[] filenames)
        {
            try
            {
                for (int i = 0; i < filenames.Length; i++)
                    File.Delete(filenames[i] + ".gz");

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

        private void CopyFileCompressed(string source, string target, DateTime lastWriteTimeUtc)
        {
            using (FileStream originalFileStream = new FileStream(source, FileMode.Open))
            {
                using (FileStream compressedFileStream = File.Create(target + ".gz"))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }

            File.SetLastWriteTimeUtc(target + ".gz", lastWriteTimeUtc);
        }
    }
}
