using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST
{
    internal class ArmaCfgManager
    {
        private string _Filename;
        private bool _FoundArma3Cfg = false;

        private const string _ParameterName_ForceAdapterId = "forcedAdapterId";
        private int _ParameterValue_ForceAdapterId = -1;
        private bool _ParameterValid_ForceAdapterId = false;

        public ArmaCfgManager()
        {
            _Filename = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Arma 3", "Arma3.cfg");

            if (File.Exists(_Filename))
            {
                _FoundArma3Cfg = true;
                string[] lines = File.ReadAllLines(_Filename);
                if (lines != null)
                {
                    foreach (string line in lines)
                    {
                        #region forcedAdapterId
                        if (line.StartsWith(_ParameterName_ForceAdapterId + "="))
                        {
                            string item = line.Remove(0, (_ParameterName_ForceAdapterId + "=").Length);
                            if (item.EndsWith(";"))
                            {
                                item = item.Remove(item.Length - 1, 1);
                                try
                                {
                                    _ParameterValue_ForceAdapterId = Convert.ToInt32(item);
                                    _ParameterValid_ForceAdapterId = true;
                                }
                                catch
                                {
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
        }

        private bool Replace(string parameter, string value)
        {
            if (_FoundArma3Cfg)
            {
                try
                {
                    string[] lines = File.ReadAllLines(_Filename);
                    string[] linesOut = new string[lines.Length];

                    bool replaced = false;
                    if (lines != null)
                    {
                        for(int i = 0; i < lines.Length; i++)
                        {
                            if (lines[i].StartsWith(parameter + "="))
                            {
                                string item = lines[i].Remove(0, (parameter + "=").Length);
                                if (item.EndsWith(";"))
                                {
                                    if (parameter == _ParameterName_ForceAdapterId)
                                    {
                                        int id = Convert.ToInt32(value);
                                        if (id > 3)
                                            return false;
                                        if (id < -1)
                                            return false;

                                        linesOut[i] = parameter + "=" + value + ";";
                                        replaced = true;
                                        _ParameterValue_ForceAdapterId = id;
                                    }
                                    //else if (parameter == _ParameterName_ForceAdapterId)
                                    //{
                                    //}
                                    else
                                        linesOut[i] = lines[i];
                                }
                                else
                                    linesOut[i] = lines[i];
                            }
                            else
                                linesOut[i] = lines[i];
                        }
                    }

                    if (replaced)
                    {
                        File.WriteAllLines(_Filename, linesOut);
                        return true;
                    }
                }
                catch
                {
                }
            }

            return false;
        }

        public bool FoundArma3Cfg
        {
            get
            {
                return _FoundArma3Cfg;
            }
        }

        public bool GetForceAdapterId(out int id)
        {

            if (!_ParameterValid_ForceAdapterId)
            {
                id = -1;
                return false;
            }
            else
            {
                id = _ParameterValue_ForceAdapterId;
                return true;
            }
        }
        public bool SetForceAdapterId(int id)
        {
            if (!_ParameterValid_ForceAdapterId)
                return false;
            return Replace(_ParameterName_ForceAdapterId, id.ToString());            
        }
    }
}
