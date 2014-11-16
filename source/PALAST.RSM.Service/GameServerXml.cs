using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM.Service
{
    public class GameServerXml
    {
        #region public class ProcessXml
        public class ProcessXml
        {
            public string FileName;
            public string WorkingDirectory;
            public string Arguments;

            public bool IsValid()
            {
                if (!File.Exists(FileName))
                    return false;
                if (!Directory.Exists(WorkingDirectory))
                    return false;

                return false;
            }
        }
        #endregion

        #region public class UserXml
        public class UserXml
        {
            public string UserName;
            public string UserGuid;

            public string UserPublicKey;
            public string UserPrivateKey;

            public string ServerPublicKey;
            public string ServerPrivateKey;

            public override string ToString()
            {
                return UserName;
            }
        }
        #endregion

        public string GUID;
        public string Description;
        public bool ForceGameServerStart = true;

        public UserXml[] Users;

        public ProcessXml PreProcess;
        public ProcessXml GamerServerProcess;
        public ProcessXml PostProcess;

        public override string ToString()
        {
            return Description;
        }
    }
}
