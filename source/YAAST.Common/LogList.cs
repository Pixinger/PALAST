using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAAST
{
    public static class LogList
    {
        public interface ILogWriter
        {
            void WriteLog(string text);
            void ClearLog();
        }
            
        private static ILogWriter _ILogWriter = null;

        public static void SetLogTarget(ILogWriter iLogWriter)
        {
            _ILogWriter = iLogWriter;
        }

        public static void Info(string text)
        {
            if (_ILogWriter != null)
                _ILogWriter.WriteLog(text);
        }
        public static void Error(string text)
        {
            if (_ILogWriter != null)
                _ILogWriter.WriteLog("ERROR: " + text);
        }
        public static void Fatal(string text)
        {
            if (_ILogWriter != null)
                _ILogWriter.WriteLog("FATAL-ERROR: " + text);
        }
        public static void Clear()
        {
            if (_ILogWriter != null)
                _ILogWriter.ClearLog();
        }


    }
}
