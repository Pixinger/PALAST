using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO.Compression;

namespace PALAST
{
    public class Repository
    {
        public const int SUPPORTED_VERSION = 1;
        public static string PathSeparator = "|";

        public class File
        {
            [XmlAttribute("N")]
            public string Name;

            [XmlAttribute("S")]
            public long Size;
            
            [XmlAttribute("M")]
            public DateTime Modified;

            [XmlIgnore]
            public Directory Parent = null;

            public File()
            {
            }

            [XmlIgnore]
            public string Fullname
            {
                get
                {
                    if (Parent != null)
                        return Parent.Fullname + PathSeparator + Name;
                    else
                        return Name;
                }
            }
            public void UpdateParentReference(Directory parent)
            {
                Parent = parent;
            }
            public override string ToString()
            {
                return "Remote-File: " + Fullname;
            }

        }
        public class Directory
        {
            [XmlElement("N")]
            public string Name = null;

            [XmlElement("F")]
            public File[] Files = null;

            [XmlElement("D")]
            public Directory[] Directories = null;

            [XmlIgnore]
            public Directory Parent = null;

            public Directory()
            {
            }

            [XmlIgnore]
            public string Fullname
            {
                get
                {
                    if (Parent != null)
                        return Parent.Fullname + PathSeparator + Name;
                    else
                        return Name;
                }
            }
            public void UpdateParentReferences(Directory parent)
            {
                Parent = parent;

                if (Files != null)
                    foreach (File file in Files)
                        file.UpdateParentReference(this);
                
                if (Directories != null)
                    foreach (Directory directory in Directories)
                        directory.UpdateParentReferences(this);
            }
            public override string ToString()
            {
                return "Remote-Directory: " + Fullname;
            }

            /// <summary>
            /// Durchsucht die Dateien der eigenen Instanz (this) nach einem übereinstimmenden Namen.
            /// Wird eine Übereinstimmung gefunden, so wird diese zurückgegeben. Sonst null.
            /// </summary>
            public File GetFile(string name)
            {
                if (Files != null)
                    foreach (Repository.File file in Files)
                        if (file.Name == name)
                            return file;

                return null;
            }
            /// <summary>
            /// Durchsucht die Ordner der eigenen Instanz (this) nach einem übereinstimmenden Namen.
            /// Wird eine Übereinstimmung gefunden, so wird diese zurückgegeben. Sonst null.
            /// </summary>
            public Directory GetDirectory(string name)
            {
                if (Directories != null)
                    foreach (Directory directory in Directories)
                        if (directory.Name == name)
                            return directory;

                return null;
            }

            /// <summary>
            /// Durchsucht die Dateien der eigenen Instanz (this) nach Dateien die nicht in der übergebenen Instanz (directory) vorkommen. Diese werden dann zurückgegeben.
            /// </summary>
            public File[] GetMissingFiles(Directory directory)
            {
                List<File> list = new List<File>();

                if (Files != null)
                    foreach (File file in Files)
                        if (directory.GetFile(file.Name) == null)
                            list.Add(file);

                return list.ToArray();
            }
            /// <summary>
            /// Durchsucht die Ordner der eigenen Instanz (this) nach Ordnern die nicht in der übergebenen Instanz (directory) vorkommen. Diese werden dann zurückgegeben.
            /// </summary>
            public Directory[] GetMissingDirectories(Directory directory)
            {
                List<Directory> list = new List<Directory>();

                if (Directories != null)
                    foreach (Directory thisDirectory in Directories)
                        if (directory.GetDirectory(thisDirectory.Name) == null)
                            list.Add(thisDirectory);

                return list.ToArray();
            }
        }

        [XmlElement("V")]
        public int Version = SUPPORTED_VERSION;

        [XmlElement("A")]
        public Directory Addons = null;

        public Repository()
        {
        }

        public void SaveGz(string filename)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Repository));
            using (FileStream reqStream = new FileStream(filename + ".gz", FileMode.Create))
            {
                using (GZipStream compressionStream = new GZipStream(reqStream, CompressionMode.Compress))
                {
                    serializer.Serialize(compressionStream, this, null);
                }
            }
        }
        public static Repository FromFilenameGz(string filename)
        {
            Repository instance = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Repository));
            using (FileStream compressedStream = new FileStream(filename + ".gz", FileMode.Open, FileAccess.Read))
            {
                using (GZipStream decompressedStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    instance = serializer.Deserialize(decompressedStream) as Repository;
                    compressedStream.Close();
                }
            }

            // Parent Referenzen aktualisieren:
            if ((instance != null) && (instance.Addons != null))
                instance.Addons.UpdateParentReferences(null);

            if (instance.Version > Repository.SUPPORTED_VERSION)
                throw new Exception("Downloaded repository version is to new. please update the software");

            return instance;
        }
        public static Repository FromDirectory(string directoryname, string[] selectedAddonsOnly)
        {
            Repository instance = new Repository();

            instance.Addons = new Repository.Directory();
            instance.Addons.Name = "";
            instance.Addons.Files = null;
            instance.Addons.Parent = null;

            // Addonverzeichnis lesen
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryname);
            if (directoryInfo == null)
                throw new Exception();

            // Unterverzeichnisse suchen
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories("@*");
            if (directoryInfos == null)
                directoryInfos = new DirectoryInfo[0];
            List<Repository.Directory> filteredDirectoryInfos = new List<Repository.Directory>(directoryInfos.Length);

            // IgnoredAddons ausfiltern
            for (int i = 0; i < directoryInfos.Length; i++)
                if ((selectedAddonsOnly == null) || (selectedAddonsOnly.Contains(directoryInfos[i].Name)))
                    filteredDirectoryInfos.Add(CreateRepositoryDirectory(instance.Addons, directoryInfos[i].FullName));

            // Ergebnis speichern
            instance.Addons.Directories = filteredDirectoryInfos.ToArray();

            return instance;
        }
        private static Repository.Directory CreateRepositoryDirectory(Repository.Directory parent, string directoryname)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryname);

            Repository.Directory instance = new Repository.Directory();
            instance.Name = directoryInfo.Name;
            instance.Parent = parent;

            FileInfo[] fileInfos = directoryInfo.GetFiles();
            instance.Files = new Repository.File[fileInfos.Length];
            for (int i = 0; i < fileInfos.Length; i++)
            {
                instance.Files[i] = new Repository.File();
                instance.Files[i].Name = fileInfos[i].Name;
                instance.Files[i].Size = fileInfos[i].Length;
                instance.Files[i].Modified = fileInfos[i].LastWriteTimeUtc;
                instance.Files[i].UpdateParentReference(instance);
            }

            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            instance.Directories = new Repository.Directory[directoryInfos.Length];
            for (int i = 0; i < directoryInfos.Length; i++)
                instance.Directories[i] = CreateRepositoryDirectory(instance, directoryInfos[i].FullName);

            return instance;
        }

        [Obsolete("unused")]
        public void Save(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Repository));
            using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                serializer.Serialize(streamWriter, this, null);
                streamWriter.Close();
            }
        }
        [Obsolete("unused")]
        public static Repository FromFilename(string filename)
        {
            Repository instance = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Repository));
            using (TextReader reader = new StreamReader(filename, System.Text.Encoding.Unicode))
            {
                instance = serializer.Deserialize(reader) as Repository;
                reader.Close();
            }

            // Parent Referenzen aktualisieren:
            if ((instance != null) && (instance.Addons != null))
                instance.Addons.UpdateParentReferences(null);

            if (instance.Version > Repository.SUPPORTED_VERSION)
                throw new Exception("Downloaded repository version is to new. please update the software");

            return instance;
        }
        [Obsolete("unused")]
        public static Repository FromDirectory(string directoryname)
        {
            return FromDirectory(directoryname, null);
        }

    }
}
