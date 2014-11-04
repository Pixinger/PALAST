using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST
{
    public abstract class SyncServer: SyncBase
    {
        protected abstract bool OnUpdateTargetRepositoryXml(Repository repository);

        public bool UpdateTargetRepositoryXml()
        {
            return OnUpdateTargetRepositoryXml(_RepositorySource);
        }
    }
}
