using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST
{
    public interface IDownloadProgressChanged
    {
        void DownloadProgressChanged(DownloadProgress downloadProgress);
    }
    
    public class DownloadProgress
    {
        public double Percent;
        public double Kbs;
        public double TotalTime;

        public DownloadProgress(double percent, double kbs, double time)
        {
            Percent = percent;
            Kbs = kbs;
            TotalTime = time;
        }
    }

    public class TrackedDownload : IDownloadProgressChanged
    {
        public string _Source;
        public string _Target;
        public DateTime _LastWriteTimeUtc;
        private IDownloadProgressChanged _IDownloadProgressChanged;

        public TrackedDownload(string source, string target, DateTime lastWriteTimeUtc, IDownloadProgressChanged iDownloadProgressChanged)
        {
            _IDownloadProgressChanged = iDownloadProgressChanged;
            _Source = source;
            _Target = target;
            _LastWriteTimeUtc = lastWriteTimeUtc;
        }

        public void DownloadProgressChanged(DownloadProgress downloadProgress)
        {
            if (_IDownloadProgressChanged != null)
                _IDownloadProgressChanged.DownloadProgressChanged(downloadProgress);
        }

    }
}
