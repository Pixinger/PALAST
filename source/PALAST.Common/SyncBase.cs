using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST
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
                            details[i] = "Datei kopieren: " + _SyncSteps[i].Path.Replace('|', '\\');
                            break;
                        case CompareResult.SyncStepTypes.DeleteFile:
                            details[i] = "Datei löschen: " + _SyncSteps[i].Path.Replace('|', '\\'); ;
                            break;
                        case CompareResult.SyncStepTypes.CreateDirectory:
                            details[i] = "Verzeichnis erstellen: " + _SyncSteps[i].Path.Replace('|', '\\'); ;
                            break;
                        case CompareResult.SyncStepTypes.DeleteDirectory:
                            details[i] = "Verzeichnis löschen: " + _SyncSteps[i].Path.Replace('|', '\\'); ;
                            break;
                        default:
                            details[i] = "Unbekannt: " + _SyncSteps[i].StepType.ToString();
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

        private bool _CancelRequest = false;

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
        protected virtual void OnSynchronizeSuccessfull(SynchronizeUserState userState)
        {
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
            for (int i = index + 1; i < compareResult.Count; i++)
            {
                if ((syncStep.StepType != compareResult[i].StepType)
                    || (!HasSameBaseDir(syncStep.Path, compareResult[i].Path)))
                    return i - 1;
            }

            return compareResult.Count - 1;
        }
        private void CompareDirectory(List<CompareResult.SyncStep> syncSteps, Repository.Directory source, Repository.Directory target)
        {
            if (_CancelRequest)
                throw new ApplicationException("Operation abortred");

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
            if (_CancelRequest)
                throw new ApplicationException("Operation abortred");

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
            if (_CancelRequest)
                throw new ApplicationException("Operation abortred");

            syncSteps.Add(CompareResult.SyncStep.CreateDirectory(target));

            if (source.Files != null)
                foreach (Repository.File file in source.Files)
                    syncSteps.Add(CompareResult.SyncStep.CopyFile(file.Fullname, file.Modified));

            if (source.Directories != null)
                foreach (Repository.Directory subDirectory in source.Directories)
                    CopyDirectory(syncSteps, subDirectory, target + "|" + subDirectory.Name);
        }

        public void RequestCancel()
        {
            _CancelRequest = true;
        }

        #region public class CompareRepositoriesUserState
        public class CompareRepositoriesUserState
        {
            public readonly bool DeleteObsoleteTargetAddons;
            public readonly CompareRepositoriesAsyncResultEventHandler CompletedDeletegate;

            public CompareRepositoriesUserState(bool deleteObsoleteTargetAddons, CompareRepositoriesAsyncResultEventHandler completedDeletegate)
            {
                DeleteObsoleteTargetAddons = deleteObsoleteTargetAddons;
                CompletedDeletegate = completedDeletegate;
            }
        }
        #endregion
        #region public class CompareRepositoriesAsyncResult
        public class CompareRepositoriesAsyncResult
        {
            /// <summary>
            /// Gibt an ab der Vergleich erfolgreich war, oder nicht.
            /// </summary>
            public readonly bool IsFailed;
            /// <summary>
            /// Bei einem Fehler, die genaue Fehlerbeschreibung.
            /// </summary>
            public readonly string Error;
            /// <summary>
            /// Die Anweisungen die ausgeführt werden müssen, um das Zielrepository auf den aktuellen Stand zu bringen.
            /// </summary>
            public readonly CompareResult[] CompareResults;
            /// <summary>
            /// Das Quellrepository (oder nach ausführen der SyncSteps auch die Zielrepository)
            /// </summary>
            public readonly Repository Repository;

            public CompareRepositoriesAsyncResult()
            {
                CompareResults = new CompareResult[0];
                IsFailed = false;
                Error = "";
                Repository = null;
            }
            public CompareRepositoriesAsyncResult(string error)
            {
                CompareResults = new CompareResult[0];
                IsFailed = true;
                Error = error;
                Repository = null;
            }
            public CompareRepositoriesAsyncResult(Repository repository, CompareResult[] compareResults)
            {
                CompareResults = compareResults;
                IsFailed = false;
                Error = "";
                Repository = repository;
            }
        }
        #endregion
        #region public delegate void CompareRepositoriesAsyncResultEventHandler(object sender, CompareRepositoriesAsyncResult e);
        public delegate void CompareRepositoriesAsyncResultEventHandler(object sender, CompareRepositoriesAsyncResult e);
        #endregion
        public void CompareRepositories(CompareRepositoriesAsyncResultEventHandler completedDeletegate)
        {
            CompareRepositories(false, completedDeletegate);
        }
        public void CompareRepositories(bool deleteObsoleteTargetAddons, CompareRepositoriesAsyncResultEventHandler completedDeletegate)
        {
            if (completedDeletegate == null)
                throw new ArgumentNullException();

            _CancelRequest = false;
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(ThreadProc_CompareRepositories));
            thread.Name = "PALAST-Compare";
            thread.Start(new CompareRepositoriesUserState(deleteObsoleteTargetAddons, completedDeletegate));
        }
        private void ThreadProc_CompareRepositories(object data)
        {
            CompareRepositoriesUserState userState = data as CompareRepositoriesUserState;

            try
            {
                if (_CancelRequest)
                    throw new ApplicationException("Operation abortred");
                
                #region LoadRepositories
                // Quellrepository laden
                Repository repositorySource = OnLoadSourceRepository();
                if (repositorySource == null)
                {
                    LOG.Error("OnLoadSourceRepository returned null");
                    throw new ApplicationException("Das Quell-Repository konnte nicht geladen werden.");
                }

                // Zielrepository laden
                Repository repositoryTarget = OnLoadTargetRepository();
                if (repositoryTarget == null)
                {
                    LOG.Error("OnLoadTargetRepository returned null");
                    throw new ApplicationException("Das Ziel-Repository konnte nicht geladen werden.");
                }

                // Source prüfen
                if (repositorySource == null)
                    throw new ApplicationException("Das Quell-Repository wurde nicht geladen.");
                if (repositorySource.Addons == null)
                    throw new ApplicationException("Das Quell-Repository/Addons wurde nicht geladen.");
                if ((repositorySource.Addons.Directories == null) || (repositorySource.Addons.Directories.Length == 0))
                    userState.CompletedDeletegate(this, new CompareRepositoriesAsyncResult()); // No addons in source repository. That's stupid, but it's not a problem!

                // Target prüfen
                if (repositoryTarget == null)
                    throw new ApplicationException("Das Ziel-Repository wurde nicht geladen.");
                if (repositoryTarget.Addons == null)
                    throw new ApplicationException("Das Ziel-Repository/Addons wurde nicht geladen.");
                #endregion

                // Jedes im Online-Repository enthaltene Addon wird nun separat geprüft und die Ergebnisse jeweils zwischen gespeichert.
                List<CompareResult.SyncStep>[] syncSteps = new List<CompareResult.SyncStep>[repositorySource.Addons.Directories.Length];
                for (int i = 0; i < repositorySource.Addons.Directories.Length; i++)
                {
                    if (_CancelRequest)
                        throw new ApplicationException("Operation abortred");

                    syncSteps[i] = new List<CompareResult.SyncStep>();
                    Repository.Directory sourceDirectory = repositorySource.Addons.Directories[i];
                    Repository.Directory targetDirectory = repositoryTarget.Addons.GetDirectory(sourceDirectory.Name);
                    if (targetDirectory == null)
                    {
                        targetDirectory = new Repository.Directory();
                        targetDirectory.Name = sourceDirectory.Name;
                        targetDirectory.UpdateParentReferences(repositoryTarget.Addons);
                        CopyDirectory(syncSteps[i], sourceDirectory, targetDirectory.Fullname);
                    }
                    else
                        CompareDirectory(syncSteps[i], sourceDirectory, targetDirectory);
                }

                // Die Liste in die CompareResult Klasse verpacken. Dadurch ist sie schreibgeschützt.
                List<CompareResult> compareResults = new List<CompareResult>(syncSteps.Length);
                for (int i = 0; i < syncSteps.Length; i++)
                    compareResults.Add(new CompareResult(repositorySource.Addons.Directories[i].Name, syncSteps[i].ToArray()));

                // Prüfen, ob nicht mehr benötigte Addons im Zielrepository gelöscht werden sollen.
                if (userState.DeleteObsoleteTargetAddons)
                {
                    // Nach solchen Addons suchen.
                    Repository.Directory[] obsoleteAddons = repositoryTarget.Addons.GetMissingDirectories(repositorySource.Addons);
                    if (obsoleteAddons != null)
                        foreach (Repository.Directory obsoleteAddon in obsoleteAddons)
                        {
                            List<CompareResult.SyncStep> obsoleteSyncSteps = new List<CompareResult.SyncStep>();
                            DeleteDirectory(obsoleteSyncSteps, obsoleteAddon);
                            compareResults.Add(new CompareResult(obsoleteAddon.Name, obsoleteSyncSteps.ToArray()));
                        }
                }

                // Verpacken und verschicken                
                userState.CompletedDeletegate(this, new CompareRepositoriesAsyncResult(repositorySource, compareResults.ToArray()));
            }
            catch (Exception ex)
            {
                // Ups... something went wrong! Oh noooo...
                LOG.Error(ex);
                userState.CompletedDeletegate(this, new CompareRepositoriesAsyncResult(ex.Message));
            }
        }

        #region public class SynchronizeUserState
        public class SynchronizeUserState
        {
            public readonly CompareResult[] SelectedAddons;
            public readonly SynchronizeAsyncResultEventHandler OnSynchronizeCompleted;
            public readonly CompareRepositoriesAsyncResult CompareRepositoriesAsyncResult;


            public SynchronizeUserState(CompareRepositoriesAsyncResult compareRepositoriesAsyncResult, SynchronizeAsyncResultEventHandler completedDelegate, CompareResult[] selectedAddons)
            {
                SelectedAddons = selectedAddons;
                OnSynchronizeCompleted = completedDelegate;
                CompareRepositoriesAsyncResult = compareRepositoriesAsyncResult;
            }
        }
        #endregion
        #region public class SynchronizeAsyncResult
        public class SynchronizeAsyncResult
        {
            public bool IsFailed = false;
            public string Error = "";
        }
        #endregion
        #region public delegate void SynchronizeAsyncResultEventHandler(object sender, SynchronizeAsyncResult e);
        public delegate void SynchronizeAsyncResultEventHandler(object sender, SynchronizeAsyncResult e);
        #endregion
        public void Synchronize(CompareRepositoriesAsyncResult compareRepositoriesAsyncResult, SynchronizeAsyncResultEventHandler completedDelegate)
        {
            Synchronize(compareRepositoriesAsyncResult, completedDelegate, null);
        }
        public void Synchronize(CompareRepositoriesAsyncResult compareRepositoriesAsyncResult, SynchronizeAsyncResultEventHandler completedDelegate, CompareResult[] selectedAddons)
        {
            if (compareRepositoriesAsyncResult == null)
                throw new ArgumentNullException();
            if (completedDelegate == null)
                throw new ArgumentNullException();
            if (selectedAddons != null)
                foreach (CompareResult cc in selectedAddons)
                    if (!compareRepositoriesAsyncResult.CompareResults.Contains(cc))
                        throw new ArgumentException("selectedAddons");

            _CancelRequest = false;
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(ThreadProc_Synchronize));
            thread.Name = "PALAST-synchronize";
            thread.Start(new SynchronizeUserState(compareRepositoriesAsyncResult, completedDelegate, selectedAddons));
        }
        private void ThreadProc_Synchronize(object data)
        {
            SynchronizeUserState state = data as SynchronizeUserState;
            SynchronizeAsyncResult result = new SynchronizeAsyncResult();

            try
            {
                CompareResult[] compareResults = (state.SelectedAddons != null) ? state.SelectedAddons : state.CompareRepositoriesAsyncResult.CompareResults;
                foreach (CompareResult syncSteps in compareResults)
                {
                    if (_CancelRequest)
                        throw new ApplicationException("Operation abortred");

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
                                    result.Error = "Datei kopieren fehlgeschlagen";
                                }
                                break;
                            case CompareResult.SyncStepTypes.DeleteFile:
                                for (int o = 0; o < sources.Length; o++)
                                    targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                                if (!OnDeleteTargetFiles(targets))
                                {
                                    result.IsFailed = true;
                                    result.Error = "Datei löschen fehlgeschlagen";
                                }
                                break;
                            case CompareResult.SyncStepTypes.CreateDirectory:
                                for (int o = 0; o < sources.Length; o++)
                                    targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                                if (!OnCreateTargetDirectorys(targets))
                                {
                                    result.IsFailed = true;
                                    result.Error = "Verzeichnis erstellen fehlgeschlagen";
                                }
                                break;
                            case CompareResult.SyncStepTypes.DeleteDirectory:
                                for (int o = 0; o < sources.Length; o++)
                                    targets[o] = OnConvertTargetPath(syncSteps[i + o].Path);

                                if (!OnDeleteTargetDirectorys(targets))
                                {
                                    result.IsFailed = true;
                                    result.Error = "Verzeichnis löschen fehlgeschlagen";
                                }
                                break;
                            default:
                                throw new NotImplementedException();
                        }

                        i = lastIndex;
                    }
                }

                OnSynchronizeSuccessfull(state);
            }
            catch (Exception ex)
            {
                result.IsFailed = true;
                result.Error = ex.Message;
                LOG.Error(ex.Message);
            }
            finally
            {
                state.OnSynchronizeCompleted(this, result);
            }
        }
    }
}
