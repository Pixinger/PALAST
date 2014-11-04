using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace PALAST
{
    public class SyncClientHttpGz: SyncClient
    {
        #region private class TrackListViewItem : ListViewItem, IDownloadProgressChanged
        private class TrackListViewItem : ListViewItem, IDownloadProgressChanged
        {
            Control _Control;
            
            public TrackListViewItem(string filename, Control control)
                : base("")
            {
                SubItems.Add(filename);
                _Control = control;
            }
            public TrackListViewItem(string status, string filename)
                : base(status)
            {
                SubItems.Add(filename);
            }

            private delegate void DownloadProgressChangedDelegate(DownloadProgress downloadProgress);
            public void DownloadProgressChanged(DownloadProgress downloadProgress)
            {
                if (_Control.InvokeRequired)
                    _Control.BeginInvoke(new DownloadProgressChangedDelegate(DownloadProgressChanged), new object[] { downloadProgress });
                else
                {
                    if (downloadProgress.Percent >= 100)
                        SubItems[0].Text = "Heruntergeladen";
                    else
                        SubItems[0].Text = string.Format("{0:###}% ({1:###} kbit/s)", downloadProgress.Percent, downloadProgress.Kbs);
                }
            }
        }
        #endregion

        delegate void TrackListViewItemDelegate(TrackListViewItem[] items);

        private string _HttpAddress;
        private string _AddonDirectory;
        private ListView _ListView;

        public SyncClientHttpGz(string httpAddress, string addonDirectory, ListView listView)
        {
            _HttpAddress = httpAddress;
            if (_HttpAddress.EndsWith("/"))
                _HttpAddress = _HttpAddress.Remove(_HttpAddress.Length - 1, 1);

            _AddonDirectory = addonDirectory;
            if (_AddonDirectory.EndsWith("\\"))
                _AddonDirectory = _AddonDirectory.Remove(_HttpAddress.Length - 1, 1);

            _ListView = listView;
        }

        private void AddListViewItem(TrackListViewItem[] items)
        {
            if (_ListView.InvokeRequired)
                _ListView.Invoke(new TrackListViewItemDelegate(AddListViewItem), new object[] { items });
            else
            {
                foreach (TrackListViewItem item in items)
                    _ListView.Items.Add(item);

                _ListView.EnsureVisible(_ListView.Items.Count - 1);
            }
        }

        protected override Repository OnLoadSourceRepository()
        {
            try
            {
                return HttpManager.DownloadGz(_HttpAddress + "/yaast.xml");
            }
            catch (System.Net.WebException ex)
            {
                System.Net.HttpWebResponse response = ex.Response as System.Net.HttpWebResponse;
                if ((response != null) && (response.StatusCode == System.Net.HttpStatusCode.NotFound))
                    throw new ApplicationException("No YAAST-Repository found at: " + _HttpAddress + "/yaast.xml");
                else
                    throw ex;
            }
        }
        protected override Repository OnLoadTargetRepository()
        {
            if (!Directory.Exists(_AddonDirectory))
                throw new ApplicationException("Addon directory not found: " + _AddonDirectory);

            return Repository.FromDirectory(_AddonDirectory, null);           
        }

        protected override string OnConvertSourcePath(string source)
        {
            return _HttpAddress + source.Replace('|', '/'); 
        }
        protected override string OnConvertTargetPath(string destination)
        {
            return _AddonDirectory + destination.Replace('|', '\\');
        }

        protected override bool OnCopyFiles(string[] sources, string[] targets, DateTime[] lastWriteTimesUtc)
        {
            try
            {
                // Listen vorbereiten
                TrackListViewItem[] items = new TrackListViewItem[sources.Length];
                TrackedDownload[] trackedDownloads = new TrackedDownload[sources.Length];
                for (int i = 0; i < sources.Length; i++)
                {
                    items[i] = new TrackListViewItem(targets[i].Remove(0, _AddonDirectory.Length), _ListView);
                    trackedDownloads[i] = new TrackedDownload(sources[i], targets[i], lastWriteTimesUtc[i], items[i]);
                }
                
                // Zur ListView hinzufügen
                AddListViewItem(items);
                
                // Herunterladen
                HttpManager.DownloadGz_HttpWebRequest(trackedDownloads);

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }        
        protected override bool OnDeleteTargetFiles(string[] filenames)
        {
            try
            {
                for (int i = 0; i < filenames.Length; i++)
                {
                    TrackListViewItem[] p = new TrackListViewItem[1];
                    p[0] = new TrackListViewItem("Entfernen", filenames[i].Remove(0, _AddonDirectory.Length));
                    AddListViewItem(p);

                    File.Delete(filenames[i]);
                }

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }
        protected override bool OnDeleteTargetDirectorys(string[] directorynames)
        {
            try
            {
                for (int i = 0; i < directorynames.Length; i++)
                {
                    TrackListViewItem[] p = new TrackListViewItem[1];
                    p[0] = new TrackListViewItem("Entfernen", directorynames[i].Remove(0, _AddonDirectory.Length));
                    AddListViewItem(p);
                    Directory.Delete(directorynames[i]);
                }

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }
        protected override bool OnCreateTargetDirectorys(string[] directorynames)
        {
            try
            {
                for (int i = 0; i < directorynames.Length; i++)
                {
                    TrackListViewItem[] p = new TrackListViewItem[1];
                    p[0] = new TrackListViewItem("Erstellen", directorynames[i].Remove(0, _AddonDirectory.Length));
                    AddListViewItem(p);
                    Directory.CreateDirectory(directorynames[i]);
                }

                return true;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return false;
            }
        }

    }
}
