using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAAST
{
    public abstract class SyncBase
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        #region public class CompareResult
        public class CompareResult
        {
            #region public enum SyncStepTypes
            public enum SyncStepTypes
            {
                CopyFile,
                DeleteFile,
                CreateDirectory,
                DeleteDirectory,
            }
            #endregion
            #region public class SyncStep
            public class SyncStep
            {
                public readonly SyncStepTypes StepType;
                public readonly string Path;
                public readonly DateTime Date;

                private SyncStep(SyncStepTypes stepType, string path, DateTime date)
                {
                    StepType = stepType;
                    Path = path;
                    Date = date;
                    LOG.Debug("{0}: {1} / {2}", stepType, path, date);
                }
                private SyncStep(SyncStepTypes stepType, string path)
                {
                    StepType = stepType;
                    Path = path;
                    LOG.Debug("{0}: {1}", stepType, path);
                }

                public static SyncStep CopyFile(string filename, DateTime date)
                {
                    return new SyncStep(SyncStepTypes.CopyFile, filename, date);
                }
                public static SyncStep DeleteFile(string filename)
                {
                    return new SyncStep(SyncStepTypes.DeleteFile, filename);
                }
                public static SyncStep CreateDirectory(string directoryname)
                {
                    return new SyncStep(SyncStepTypes.CreateDirectory, directoryname);
                }
                public static SyncStep DeleteDirectory(string directoryname)
                {
                    return new SyncStep(SyncStepTypes.DeleteDirectory, directoryname);
                }

                public override string ToString()
                {
                    return string.Format("{0}: {1}/{2}", StepType, Path, Date);
                }
            }
            #endregion

            private string _Name;
            private SyncStep[] _SyncSteps = null;

            public CompareResult(string name, SyncStep[] steps)
            {
                _Name = name;
                _SyncSteps = steps;
            }

            public SyncStep this[int index]
            {
                get 
                {
                    return _SyncSteps[index]; 
                }
            }

            public int Count
            {
                get
                {
                    return _SyncSteps.Length;
                }
            }
            public string Name
            {
                get
                {
                    return _Name;
                }
            }

            public string[] GetDetailStrings()
            {
                string[] details = new string[_SyncSteps.Length];
                for (int i = 0; i < _SyncSteps.Length; i++)
                {
                    switch (_SyncSteps[i].StepType)
                    {
                        case CompareResult.SyncStepTypes.CopyFile:
                            details[i] = "copy file: " + _SyncSteps[i].Path.Replace('|', '\\');
                            break;
                        case CompareResult.SyncStepTypes.DeleteFile:
                            details[i] = "delete file: " + _SyncSteps[i].Path.Replace('|','\\');;
                            break;
                        case CompareResult.SyncStepTypes.CreateDirectory:
                            details[i] = "create directory: " + _SyncSteps[i].Path.Replace('|', '\\'); ;
                            break;
                        case CompareResult.SyncStepTypes.DeleteDirectory:
                            details[i] = "delete directory: " + _SyncSteps[i].Path.Replace('|','\\');;
                            break;
                        default:
                            details[i] = "Unknown: " + _SyncSteps[i].StepType.ToString();
                            break;
                    }
                }

                return details;
            }

            public override string ToString()
            {
                return _Name;
            }
        }
        #endregion

        protected Repository _RepositorySource;
        protected Repository _RepositoryTarget;

        public SyncBase()
        {
        }

        protected abstract Repository OnLoadSourceRepository();
        protected abstract Repository OnLoadTargetRepository();
        protected abstract string OnConvertSourcePath(string source);
        protected abstract string OnConvertTargetPath(string destination);

        protected abstract bool OnCopyFiles(string[] sources, string[] targets, DateTime[] lastWriteTimesUtc);
        protected abstract bool OnDeleteTargetFiles(string[] filenames);
        protected abstract bool OnCreateTargetDirectorys(string[] directorynames);
        protected abstract bool OnDeleteTargetDirectorys(string[] directorynames);

        private void CompareDirectory(List<CompareResult.SyncStep> syncSteps, Repository.Directory source, Repository.Directory target)
        {
            // Dateien die gelöscht werden müssen (auf dem Remote)
            Repository.File[] filesToDelete = target.GetMissingFiles(source);
            foreach (Repository.File remoteFile in filesToDelete)
                syncSteps.Add(CompareResult.SyncStep.DeleteFile(remoteFile.Fullname));

            if (source.Files != null)
            {
                // Dateien die kopiert/überschrieben werden müssen (auf dem Remote)
                foreach (Repository.File sourceFile in source.Files)
                {
                    Repository.File remoteFile = target.GetFile(sourceFile.Name);
                    if (remoteFile == null)
                    {
                        remoteFile = new Repository.File();
                        remoteFile.Name = sourceFile.Name;
                        remoteFile.Size = sourceFile.Size;
                        remoteFile.Modified = sourceFile.Modified;
                        remoteFile.UpdateParentReference(target);
                        syncSteps.Add(CompareResult.SyncStep.CopyFile(sourceFile.Fullname, sourceFile.Modified));
                    }
                    else if (remoteFile.Modified != sourceFile.Modified)
                        syncSteps.Add(CompareResult.SyncStep.CopyFile(sourceFile.Fullname, sourceFile.Modified));
                }
            }

            // Ordner die Gelöscht werden müssen
            Repository.Directory[] directoriesToDelete = target.GetMissingDirectories(source);
            foreach (Repository.Directory directory in directoriesToDelete)
                DeleteDirectory(syncSteps, directory);

            // Ordner die Synchronisiert werden müssen
            if (source.Directories != null)
            {
                foreach (Repository.Directory sourceSubDirectory in source.Directories)
                {
                    Repository.Directory targetSubDirectory = target.GetDirectory(sourceSubDirectory.Name);
                    if (targetSubDirectory == null)
                    {
                        targetSubDirectory = new Repository.Directory();
                        targetSubDirectory.Name = sourceSubDirectory.Name;
                        targetSubDirectory.UpdateParentReferences(target);
                        CopyDirectory(syncSteps, sourceSubDirectory, targetSubDirectory.Fullname);
                    }
                    else
                        CompareDirectory(syncSteps, sourceSubDirectory, targetSubDirectory);
                }
            }
        }
        private void DeleteDirectory(List<CompareResult.SyncStep> syncSteps, Repository.Directory target)
        {
            if (target.Files != null)
                foreach (Repository.File file in target.Files)
                    syncSteps.Add(CompareResult.SyncStep.DeleteFile(file.Fullname));

            if (target.Directories != null)
                foreach (Repository.Directory subDirectory in target.Directories)
                    DeleteDirectory(syncSteps, subDirectory);

            syncSteps.Add(CompareResult.SyncStep.DeleteDirectory(target.Fullname));
        }
        private void CopyDirectory(List<CompareResult.SyncStep> syncSteps, Repository.Directory source, string target)
        {
            syncSteps.Add(CompareResult.SyncStep.CreateDirectory(target));

            if (source.Files != null)
                foreach (Repository.File file in source.Files)
                    syncSteps.Add(CompareResult.SyncStep.CopyFile(file.Fullname, file.Modified));

            if (source.Directories != null)
                foreach (Repository.Directory subDirectory in source.Directories)
                    CopyDirectory(syncSteps, subDirectory, target + "|" + subDirectory.Name);
        }

        public void LoadRepositories()
        {
            // Quellrepository laden
            _RepositorySource = OnLoadSourceRepository();
            if (_RepositorySource == null)
            {
                LOG.Error("OnLoadSourceRepository returned null");
                throw new ApplicationException("Unable to load source repository");
            }

            // Zielrepository laden
            _RepositoryTarget = OnLoadTargetRepository();
            if (_RepositoryTarget == null)
            {
                LOG.Error("OnLoadTargetRepository returned null");
                throw new ApplicationException("Unable to load target repository");
            }
        }
        public CompareResult[] CompareRepositories()
        {
            return CompareRepositories(false);
        }
        public CompareResult[] CompareRepositories(bool deleteObsoleteTargetAddons)
        {
            // Source prüfen
            if (_RepositorySource == null)
                throw new ApplicationException("Source repository not loaded");
            if (_RepositorySource.Addons == null)
                throw new ApplicationException("Source repository.addons == null");
            if ((_RepositorySource.Addons.Directories == null) || (_RepositorySource.Addons.Directories.Length == 0))
                return new CompareResult[0]; // No addons in source repository. That's stupid, but it's not a problem!

            // Target prüfen
            if (_RepositoryTarget == null)
                throw new ApplicationException("Target repository not loaded");
            if (_RepositoryTarget.Addons == null)
                throw new ApplicationException("Target repository.addons == null");

            // Jedes im Online-Repository enthaltene Addon wird nun separat geprüft und die Ergebnisse jeweils zwischen gespeichert.
            List<CompareResult.SyncStep>[] syncSteps = new List<CompareResult.SyncStep>[_RepositorySource.Addons.Directories.Length];
            for (int i = 0; i < _RepositorySource.Addons.Directories.Length; i++)
            {
                syncSteps[i] = new List<CompareResult.SyncStep>();
                Repository.Directory sourceDirectory = _RepositorySource.Addons.Directories[i];
                Repository.Directory targetDirectory = _RepositoryTarget.Addons.GetDirectory(sourceDirectory.Name);
                if (targetDirectory == null)
                {
                    targetDirectory = new Repository.Directory();
                    targetDirectory.Name = sourceDirectory.Name;
                    targetDirectory.UpdateParentReferences(_RepositoryTarget.Addons);
                    CopyDirectory(syncSteps[i], sourceDirectory, targetDirectory.Fullname);
                }
                else
                    CompareDirectory(syncSteps[i], sourceDirectory, targetDirectory);
            }
          
            // Die Liste in die CompareResult Klasse verpacken. Dadurch ist sie schreibgeschützt.
            List<CompareResult> compareResults = new List<CompareResult>(syncSteps.Length);
            for (int i = 0; i < syncSteps.Length; i++)
                compareResults.Add(new CompareResult(_RepositorySource.Addons.Directories[i].Name, syncSteps[i].ToArray()));

            // Prüfen, ob nicht mehr benötigte Addons im Zielrepository gelöscht werden sollen.
            if (deleteObsoleteTargetAddons)
            {
                // Nach solchen Addons suchen.
                Repository.Directory[] obsoleteAddons = _RepositoryTarget.Addons.GetMissingDirectories(_RepositorySource.Addons);
                if (obsoleteAddons != null)
                    foreach (Repository.Directory obsoleteAddon in obsoleteAddons)
                    {
                        List<CompareResult.SyncStep> obsoleteSyncSteps = new List<CompareResult.SyncStep>();
                        DeleteDirectory(obsoleteSyncSteps, obsoleteAddon);
                        compareResults.Add(new CompareResult(obsoleteAddon.Name, obsoleteSyncSteps.ToArray()));
                    }
            }


            // Fertig
            return compareResults.ToArray();
        }
        public bool Synchronize(CompareResult[] selectedAddons)
        {
            foreach (CompareResult syncSteps in selectedAddons)
            {
                for (int i = 0; i < syncSteps.Count; i++)
                {
                    int lastIndex = LastCombinedIndex(syncSteps, i);
                    string[] sources = new string[lastIndex - i + 1];
                    string[] targets = new string[lastIndex - i + 1];
                    DateTime[] dates = new DateTime[lastIndex - i + 1];
                    switch (syncSteps[i].StepType)
                    {
                        case CompareResult.SyncStepTypes.CopyFile:
                            for (int o = 0; o < sources.Length; o++)
                            {
                                sources[o] = OnConvertSourcePath(syncSteps[i + o].Path);
                                targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);
                                dates[o] = syncSteps[i + o].Date;
                            }

                            if (!OnCopyFiles(sources, targets, dates))
                            {
                                LogList.Error("copy file failed");
                                return false;
                            }
                            break;
                        case CompareResult.SyncStepTypes.DeleteFile:
                            for (int o = 0; o < sources.Length; o++)
                                targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                            if (!OnDeleteTargetFiles(targets))
                            {
                                LogList.Error("copy file failed");
                                return false;
                            }
                            break;
                        case CompareResult.SyncStepTypes.CreateDirectory:
                            for (int o = 0; o < sources.Length; o++)
                                targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                            if (!OnCreateTargetDirectorys(targets))
                            {
                                LogList.Error("copy file failed");
                                return false;
                            }
                            break;
                        case CompareResult.SyncStepTypes.DeleteDirectory:
                            for (int o = 0; o < sources.Length; o++)
                                targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                            if (!OnDeleteTargetDirectorys(targets))
                            {
                                LogList.Error("copy file failed");
                                return false;
                            }
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    i = lastIndex;
                }
            }

            return true;
        }


        public class SyncStateObject
        {
            public CompareResult[] SelectedAddons;
            public SynchronizeCompletedEventHandler OnSynchronizeCompleted;
        }
        public class SynchronizeResultObject
        {
            public bool IsFailed = false;
            public string Error = "";
        }

        public delegate void SynchronizeCompletedEventHandler(object sender, SynchronizeResultObject e);
        
        private void SynchronizeThreadProc(object data)
        {
            SyncStateObject state = data as SyncStateObject;
            SynchronizeResultObject result = new SynchronizeResultObject();

            try
            {
                foreach (CompareResult syncSteps in state.SelectedAddons)
                {
                    for (int i = 0; i < syncSteps.Count; i++)
                    {
                        int lastIndex = LastCombinedIndex(syncSteps, i);
                        string[] sources = new string[lastIndex - i + 1];
                        string[] targets = new string[lastIndex - i + 1];
                        DateTime[] dates = new DateTime[lastIndex - i + 1];
                        switch (syncSteps[i].StepType)
                        {
                            case CompareResult.SyncStepTypes.CopyFile:
                                for (int o = 0; o < sources.Length; o++)
                                {
                                    sources[o] = OnConvertSourcePath(syncSteps[i + o].Path);
                                    targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);
                                    dates[o] = syncSteps[i + o].Date;
                                }

                                if (!OnCopyFiles(sources, targets, dates))
                                {
                                    result.IsFailed = true;
                                    result.Error = "copy file failed";
                                }
                                break;
                            case CompareResult.SyncStepTypes.DeleteFile:
                                for (int o = 0; o < sources.Length; o++)
                                    targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                                if (!OnDeleteTargetFiles(targets))
                                {
                                    result.IsFailed = true;
                                    result.Error = "delete file failed";
                                }
                                break;
                            case CompareResult.SyncStepTypes.CreateDirectory:
                                for (int o = 0; o < sources.Length; o++)
                                    targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                                if (!OnCreateTargetDirectorys(targets))
                                {
                                    result.IsFailed = true;
                                    result.Error = "create directory failed";
                                }
                                break;
                            case CompareResult.SyncStepTypes.DeleteDirectory:
                                for (int o = 0; o < sources.Length; o++)
                                    targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                                if (!OnDeleteTargetDirectorys(targets))
                                {
                                    result.IsFailed = true;
                                    result.Error = "delete directory failed";
                                }
                                break;
                            default:
                                throw new NotImplementedException();
                        }

                        i = lastIndex;
                    }
                }

            }
            finally
            {
                state.OnSynchronizeCompleted(this, result);
            }
        }


        public void SynchronizeAsync(CompareResult[] selectedAddons, SynchronizeCompletedEventHandler onSynchronizeCompleted)
        {
            SyncStateObject state = new SyncStateObject();
            state.SelectedAddons = selectedAddons;
            state.OnSynchronizeCompleted = onSynchronizeCompleted;
 
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(SynchronizeThreadProc));
            thread.Start(state);
        }

        private bool HasSameBaseDir(string path1, string path2)
        {
            int index1 = path1.LastIndexOf('|');
            int index2 = path2.LastIndexOf('|');

            string a1 = path1.Remove(index1, path1.Length - index1);
            string a2 = path2.Remove(index2, path2.Length - index2);

            return a1 == a2;
        }
        private int LastCombinedIndex(CompareResult compareResult, int index)
        {
            CompareResult.SyncStep syncStep = compareResult[index];
            for (int i = index+1; i < compareResult.Count; i++)
            {
                if ((syncStep.StepType != compareResult[i].StepType)
                    || (!HasSameBaseDir(syncStep.Path, compareResult[i].Path)))
                    return i - 1;
            }

            return compareResult.Count - 1;
        }
    }
}
