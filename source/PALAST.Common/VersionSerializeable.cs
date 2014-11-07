using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST
{
    [Serializable]
    public class VersionSerializeable
    {
        [XmlAttribute]
        public int Major;
        [XmlAttribute]
        public int Minor;
        [XmlAttribute]
        public int Build;
        [XmlAttribute]
        public int Revision;

        public VersionSerializeable()
        {
        }
        public VersionSerializeable(int major, int minor, int build, int revision)
        {
            Major = major;
            Minor = minor;
            Build = build;
            Revision = revision;
        }

        public static VersionSerializeable FromVersion(Version version)
        {
            return new VersionSerializeable(version.Major, version.Minor, version.Build, version.Revision);
        }

        public Version ToVersion()
        {
            return new Version(Major, Minor, Build, Revision);
        }
    }
}
