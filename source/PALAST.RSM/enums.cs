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
        Starting_Prelaunch,
        Starting_Gameserver,
        Starting_Postlaunch,
        Started,
        Started_WithErrors,
        Stopping,
        Stopped,
    }
    public enum MissionResults
    {
        OK,
        ErrorUnknown,
        ErrorNotAllowed,
        ErrorNoMissionFolder,
        ErrorFileExists,
        ErrorFileExistsServerOnline,
        ErrorMaximumSize,
    }
}
