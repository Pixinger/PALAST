using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM
{
    public enum ServerStates
    {
        Unknown,
        Starting,
        StartingPreLaunch,
        StartingGamerServer,
        StartingPostLaunch,
        Started,
        StartedWithErrors,
        Stopping,
        Stopped,
    }
}
