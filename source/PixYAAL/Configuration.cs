using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace YAAL
{
    public class Configuration
    {
        public const string filename = "configuration.xml";

        #region Load/Save
        public static Configuration Load()
        {
            Configuration cfg = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                using (TextReader reader = new StreamReader(filename, System.Text.Encoding.Unicode))
                {
                    cfg = serializer.Deserialize(reader) as Configuration;
                    reader.Close();
                }
            }
            catch
            {
                cfg = new Configuration();
            }

            
            if ((cfg.Presets == null) || (cfg.Presets.Length == 0))
            {
                cfg.Presets = new Preset[1];
                cfg.Presets[0] = new Preset();
                cfg.Presets[0].Name = "Default";
                cfg.SelectedPreset = "Default";
            }

            return cfg;
        }
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
            using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                serializer.Serialize(streamWriter, this, null);
                streamWriter.Close();
            }
        }
        #endregion

        public class Preset
        {
            public string Name;
            public string[] SelectedAddons;

            public bool ParamNoSplash = true;
            public bool ParamWorldEmpty = true;
            public bool ParamSkipIntro = true;

            public int ParamMaxMem = -1;
            public int ParamMaxVRam = -1;
            public bool ParamWinXP = false;//
            public bool ParamNoCB = false;//
            public int ParamCpuCount = -1;
            public int ParamExThreads = -1;
            public bool ParamNoLogs = false;

            public string ParamName = "";

            public bool ParamNoPause = true;
            public bool ParamShowScriptErrors = true;
            public bool ParamNoFilePatching = false;
            public bool ParamCheckSignatures = false;

            public bool AutoConnectEnabled = false;
            public string ParamServer = "";
            public string ParamPort = "2302";
            public string ParamPassword = "";

            public string ParamAdditionalParameters = "";

            public override string ToString()
            {
                return Name;
            }
            public Preset Clone()
            {
                Preset preset = new Preset();
                
                preset.Name = this.Name;

                preset.ParamNoSplash = this.ParamNoSplash;
                preset.ParamWorldEmpty = this.ParamWorldEmpty;
                preset.ParamSkipIntro = this.ParamSkipIntro;
                
                preset.ParamMaxMem = this.ParamMaxMem;
                preset.ParamMaxVRam = this.ParamMaxVRam;
                preset.ParamWinXP = this.ParamWinXP;
                preset.ParamNoCB = this.ParamNoCB;
                preset.ParamCpuCount = this.ParamCpuCount;
                preset.ParamExThreads = this.ParamExThreads;
                preset.ParamNoLogs = this.ParamNoLogs;
                
                preset.ParamName = this.ParamName;
                
                preset.ParamNoPause = this.ParamNoPause;
                preset.ParamShowScriptErrors = this.ParamShowScriptErrors;
                preset.ParamNoFilePatching = this.ParamNoFilePatching;
                preset.ParamCheckSignatures = this.ParamCheckSignatures;

                preset.ParamServer = this.ParamServer;
                preset.ParamPort = this.ParamPort;
                preset.ParamPassword = this.ParamPassword;

                preset.ParamAdditionalParameters = this.ParamAdditionalParameters;


                if (this.SelectedAddons != null)
                {
                    preset.SelectedAddons = new string[this.SelectedAddons.Length];
                    for (int i = 0; i < preset.SelectedAddons.Length; i++)
                        preset.SelectedAddons[i] = this.SelectedAddons[i];
                }
                else
                    preset.SelectedAddons = null;

                return preset;
            }
        }

        public string Arma3Exe = "";
        public string SelectedPreset = "";
        public bool CloseAfterStart = true;
        public Preset[] Presets = null;
    }
}
