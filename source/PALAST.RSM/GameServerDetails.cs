
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM
{
    public class GameServerDetails
    {
        public class AddonInfo
        {
            public string Name;
            public bool Enabled;

            public override string ToString()
            {
                return Name;
            }
        }

        public ServerStates Status;
        public AddonInfo[] Addons;
    }
}
