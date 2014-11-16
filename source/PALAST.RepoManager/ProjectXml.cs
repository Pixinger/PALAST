using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace PALAST.RepoManager
{
    public class ProjectXml
    {
        public class FtpRepositoryXml
        {
            public string Address = "";
            public string Username = "";
            public string Password = "";
            public bool Passive = true;
            public int ConnectionLimit = 4;
        }
        public class LocalRepositoryXml
        {
            public string Directory = "";
        }

        private string _Filename = "";
        public string Filename
        {
            get
            {
                return _Filename;
            }
        }
        
        #region Load/Save
        public static ProjectXml Load(string filename)
        {
            ProjectXml instance = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ProjectXml));
                using (TextReader reader = new StreamReader(filename, System.Text.Encoding.Unicode))
                {
                    instance = serializer.Deserialize(reader) as ProjectXml;
                    reader.Close();
                }

                instance._Filename = filename;
                return instance;
            }
            catch
            {
                return null;
            }
        }
        public void SaveAs(string filename)
        {
            _Filename = filename;
            Save();
        }
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProjectXml));
            using (StreamWriter streamWriter = new StreamWriter(_Filename, false, System.Text.Encoding.Unicode))
            {
                serializer.Serialize(streamWriter, this, null);
                streamWriter.Close();
            }
        }
        public bool SaveAsRequired
        {
            get
            {
                return (_Filename == null) || (_Filename.Length == 0);
            }
        }
        public void Validate()
        {
            if ((FtpRepository == null) && (LocalRepository == null))
                FtpRepository = new ProjectXml.FtpRepositoryXml();

            List<string> addons = new List<string>();
            if (SelectedAddons != null)
                foreach(string addon in SelectedAddons)
                    if (addon != null)
                        addons.Add(addon);
            SelectedAddons = addons.ToArray();
        }
        #endregion

        public string AddonDirectory = "";
        public string[] SelectedAddons;
        public FtpRepositoryXml FtpRepository;
        public LocalRepositoryXml LocalRepository;
    }
}
