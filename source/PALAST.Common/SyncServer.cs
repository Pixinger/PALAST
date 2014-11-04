using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST
{
    public abstract class SyncServer: SyncBase
    {
        protected abstract void OnUpdateTargetRepositoryXml(Repository repository);

        public void UpdateTargetRepositoryXml()
        {
            OnUpdateTargetRepositoryXml(_RepositorySource);
        }
    }
}
