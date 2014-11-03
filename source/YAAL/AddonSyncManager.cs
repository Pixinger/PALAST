
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAAL
{
 /*   class AddonSyncManager
    {
        private YAAST.Repository _RepositorySource;
        private YAAST.Repository _RepositoryDestintion;

        public AddonSyncManager(YAAST.Repository repositorySource, YAAST.Repository repositoryDestination)
        {
            _RepositorySource = repositorySource;
            if (_RepositorySource == null)
                throw new Exception();

            _RepositoryDestintion = repositoryDestination;
            if (_RepositoryDestintion == null)
                throw new Exception();
        }

        public bool UpdateTasklist()
        {
            _TaskList = new YAAST.TaskList();
            AnalyseRepositories(_RepositorySource.Addons, _RepositoryDestintion.Addons);
            return (_TaskList.Count > 0);
        }

        private void AnalyseRepositories(YAAST.Repository.Directory source, YAAST.Repository.Directory destination)
        {
            // Dateien die gelöscht werden müssen (auf dem Remote)
            YAAST.Repository.File[] filesToDelete = destination.GetMissingFiles(source);
            foreach (YAAST.Repository.File remoteFile in filesToDelete)
                _TaskList.Add(new YAAST.TaskDeleteFile2(remoteFile));

            if (source.Files != null)
            {
                // Dateien die kopiert/überschrieben werden müssen (auf dem Remote)
                foreach (YAAST.Repository.File localFile in source.Files)
                {
                    YAAST.Repository.File remoteFile = destination.GetFile(localFile.Name);
                    if (remoteFile == null)
                    {
                        remoteFile = new YAAST.Repository.File();
                        remoteFile.Name = localFile.Name;
                        remoteFile.Size = localFile.Size;
                        remoteFile.Modified = localFile.Modified;
                        remoteFile.UpdateParentReference(destination);
                        _TaskList.Add(new YAAST.TaskCopyFile2(localFile, remoteFile));
                    }
                    else if (remoteFile.Modified != localFile.Modified)
                        _TaskList.Add(new YAAST.TaskCopyFile2(localFile, remoteFile));
                }
            }

            // Ordner die Gelöscht werden müssen
            YAAST.Repository.Directory[] directoriesToDelete = destination.GetMissingDirectories(source);
            if (directoriesToDelete != null)
            {
                foreach (YAAST.Repository.Directory directory in directoriesToDelete)
                    _TaskList.Add(new YAAST.TaskDeleteDirectory2(directory));
            }

            // Ordner die Synchronisiert werden müssen
            if (source.Directories != null)
            {
                foreach (YAAST.Repository.Directory localSubDirectory in source.Directories)
                {
                    YAAST.Repository.Directory remoteSubDirectory = destination.GetDirectory(localSubDirectory.Name);
                    if (remoteSubDirectory == null)
                    {
                        remoteSubDirectory = new YAAST.Repository.Directory();
                        remoteSubDirectory.Name = localSubDirectory.Name;
                        remoteSubDirectory.UpdateParentReferences(destination);
                        _TaskList.Add(new YAAST.TaskCopyDirectory2(localSubDirectory, remoteSubDirectory));
                    }
                    else
                        AnalyseRepositories(localSubDirectory, remoteSubDirectory);
                }
            }
        }
    }*/
}
