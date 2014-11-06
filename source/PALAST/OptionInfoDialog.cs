using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST
{
    public partial class OptionInfoDialog : Form
    {
        public class HelpTextManager
        {
            public string GetText(string option)
            {
                System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.CurrentCulture;

                while (true)
                {
                    string methodname = option + "_" + cultureInfo.Name;
                    methodname = methodname.Replace('-', '_');
                    MethodInfo methodInfo = GetType().GetMethod(methodname);
                    if (methodInfo != null)
                        return (methodInfo.Invoke(this, null) as string);

                    if (cultureInfo.Name == "")
                        return "no info";
                    else
                        cultureInfo = cultureInfo.Parent;
                }
            }

            #region neutral
            private string WIKI()
            {
                return "\n\n\n(Weitere Informationen finden Sie im WIKI: https://community.bistudio.com/wiki/Arma3:_Startup_Parameters)";
            }
            public string _noSplash_()
            {
                return "Disables splash screens at startup.";
            }
            public string _worldEmpty_()
            {
                return "For faster game loading this parameter will load no world in the main menu.\n" +
                    "(To be precise, the parameter is -world=empty instead of -worldEmtpy.)" +
                    WIKI();
            }
            public string _skipIntro_()
            {
                return "Disables world intros in the main menu permanently.";
            }
            public string _maxMem_()
            {
                return "Defines memory allocation limit to number (in MegaBytes).\n\n" +
                    "256 is hard-coded minimum (anything lower falls backs to 256). 3072 is hard-coded maximum (anything higher falls back to 3072). \n" +
                    "Engine uses automatic values (512-1536 MB) w/o maxMem parameter." +
                    WIKI();
            }
            public string _maxVRAM_()
            {
                return "Defines Video Memory allocation limit to number (in MegaBytes).\n\n" +
                    "128 is hard-coded minimum (anything lower falls backs to 128). 2047 is soft-coded maximum , any value over 2GB might result into unforseen consequences!\n\n" +
                    "Use to resolve e.g. Windows problem." +
                    WIKI();
            }
            public string _winXP_()
            {
                return "Forces the game to use Direct3D version 9 only, not the extended Vista / Win7 Direct3D 9Ex." +
                    "- the most visible feature the Direct3D 9Ex version offers is a lot faster alt-tabing. May help with problems using older drivers on multi-GPU systems." +
                    WIKI();
            }
            public string _noCB_()
            {
                return "Turns off multicore use. It slows down rendering but may resolve visual glitches.";
            }
            public string _cpuCount_()
            {
                return "Change to a number less or equal than numbers of available cores.\n" +
                    "This will override auto detection (which equate to native cores).\n\n" +
                    "The best way to simulate dual core on quad core is to use -cpuCount=2 when you run the game and then change the affinity to 2 cores to make sure additional cores can never be used when some over-scheduling happens. It might be also possible to set the affinity in the OS before you launch the process, that would work as well." +
                    WIKI();
            }
            public string _exThreads_()
            {
                return "Defines how many extra threads are used.\n\n" +
                    "All file operations go through a dedicated thread. This offloads some processing from the main thread, however it adds some overhead at the same time. The reason why threaded file ops were implemented was to serve as a basement for other threads ops. When multiple threads are running at the same time, OS is scheduling them on different cores. Geometry and Texture loading (both done by the same thread) are scheduled on different cores outside the main rendering loop at the same time with the main rendering loop.\n\n" +
                    "Ex(tra)threads table:\n" +
                    "(N) | (G) (T) (F)\n" +
                    " 0  |  0   0   0\n" +
                    " 1  |  0   0   1\n" +
                    " 3  |  0   1   1\n" +
                    " 5  |  1   0   1\n" +
                    " 7  |  1   1   1\n" +
                    "(N): exThreads value\n" +
                    "(G): Geometry loading on extra thread.\n" +
                    "(T): Texture loading on extra thread.\n" +
                    "(F): File loading on extra thread.\n" +
                    WIKI();
            }
            public string _noLogs_()
            {
                return "Be aware this means none errors saved to RPT file (report log). Yet in case of crash the fault address block info is saved." +
                    WIKI();
            }
            public string _name_()
            {
                return "Defines which profile will be used by the game.";
            }
            public string _noPause_()
            {
                return "Allow the game running even when its window does not have focus (i.e. running in the background). This may improve system stability when switching between game and desktop.";
            }
            public string _showScriptErrors_()
            {
                return "Show script errors in a small black box on the screen.";
            }
            public string _noFilePatching_()
            {
                return "Ensures that only PBOs are loaded and NO unpacked data." +
                    WIKI();
            }
            public string _checkSignatures_()
            {
                return "Introduced to provide thorough test of all signatures of all loaded banks at the start game. Output is in .rpt file.";
            }
            public string _autoConnect_()
            {
                return "Automatically connects to the configured server. This feature seems not to work in Arma right now." +
                    WIKI();
            }
            #endregion

            #region de
            private string WIKI_de()
            {
                return "\n\n\n(Weitere Informationen finden Sie im WIKI: https://community.bistudio.com/wiki/Arma3:_Startup_Parameters)";
            }
            public string _noSplash_de()
            {
                return "Deaktiviert das Intro beim Spielstart.";
            }
            public string _worldEmpty_de()
            {
                return "Deaktiviert das Laden einer Welt im Hauptmenu, wodurch das Spiel ein wenig schneller geladen werden kann.\n" +
                    "(Um genau zu sein, lautet der Parameter -world=empty statt -worldEmtpy.)" +
                    WIKI_de();
            }
            public string _skipIntro_de()
            {
                return "Deaktiviert dauerhaft das \"world intro\" im Hauptmenu.";
            }
            public string _maxMem_de()
            {
                return "Definiert das Speicherlimit auf die angegebene Zahl (in MegaByte).\n\n" +
                    "256 ist das vorgegebene Minimum (alle kleineren Werte werden auf 256MB gesetzt). 3072 ist das vorgegebene Maximum (alle höheren Werte werden auf 3072 gesetzt).\n" +
                    "Die Game-Engine verwendet automatisch Werte zwischen (512-1536 MB) wenn kein maxMem parameter verwendet wird." +
                    "Diese angeben verändern sich von Zeit zu Zeit bei den Updates des Spiels.\n" +
                    WIKI_de();
            }
            public string _maxVRAM_de()
            {
                return "Definiert das Grafik Speicherlimit auf die angegebene Zahl (in MegaByte).\n\n" +
                     "128 ist das vorgegebene Minimum (alle kleineren Werte werden auf 128MB gesetzt). 2047 ist das vorgegebene Maximum (alle höheren Werte könnten unverhergesehene Konsequenzen haben).\n" +
                     "Durch Anpassung dieses parameters können Probleme mit Windows behoben werden." +
                     WIKI_de();
            }
            public string _winXP_de()
            {
                return "Zwingt das Spiel Direct3D 9 zu verwenden, anstatt dem Direct3D 9Ex (Vista/W7)." +
                    "- Könnte stabilitäts Probleme beheben, besonders bei der Verwendung von älteren Treiben auf Multi-GPU Systemen.\n" +
                    "- ALT-TAB arbeitet in Direct3d 9Ex anscheinend deutlich schneller" +
                    WIKI_de();
            }
            public string _noCB_de()
            {
                return "Deaktiviert die Verwendung von mehreren Kernen.\n"+
                    "Dies wird das Rendering verlangsamen, aber unter Umständen optische Störungen beheben.";
            }
            public string _cpuCount_de()
            {
                return "Definert die Anzahl der zu verwendenden Kerne. Kann auf eine Zahl kleiner oder gleicher der verfügbaren Kerne gestellt werden.\n" +
                    "Dieser Parameter wird die automatische Erkennung überschreiben (=alle verfügbaren Kerne).\n\n" +
                    "Der beste Weg um einen Dual-Core auf einem Quad-Core zu simulieren, ist -cpuCount=2 zu verwenden und die Affinität auf 2 Kerne zu setzen um sicher zu gehen, dass zusätzliche Kerne niemals verwendet werden wen Over-SCheduling auftritt. Es sollte auch funktionieren im Betriebssystem die Affinität zu setzen, bevor dsa Spiel gestartet wird." +
                    WIKI_de();
            }
            public string _exThreads_de()
            {
                return "Definiert wie viele zusätzliche Threads verwendet werden sollen.\n\n" +
                    "Wenn genug Kerne vorhanden sind, können zusätliche Threads parallel laufen und damit den Hauptthread entlasten. Jeder zusätzliche Thread bedeutet gleichzeitig aber auch zusätzliche Arbeit.\n\n"+
                    "Es gibt drei mögliche Zusatzthreads: Geometrie / Texturen / Dateien\n\n"+
                    "Ex(tra)threads Tabelle:\n" +
                    "(N) | (G) (T) (D)\n" +
                    " 0  |  0   0   0\n" +
                    " 1  |  0   0   1\n" +
                    " 3  |  0   1   1\n" +
                    " 5  |  1   0   1\n" +
                    " 7  |  1   1   1\n" +
                    "(N): exThreads Wert\n" +
                    "(G): Geometrie wird auf einem zusätzlichem Thread geladen.\n" +
                    "(T): Texturen werden auf einem zusätzlichem Thread geladen.\n" +
                    "(D): Dateien werden auf einem zusätzlichem Thread geladen.\n" +
                    WIKI_de();
            }
            public string _noLogs_de()
            {
                return "Speichert keine Fehlermeldungen in der RPT-Datei. Im Falle eines Crashs wird nur der Fehlerhafte Adressblock gespeichert." +
                    WIKI_de();
            }
            public string _name_de()
            {
                return "Definiert mit welchem (Spieler)Profil das Spiel gestartet wird.";
            }
            public string _noPause_de()
            {
                return "Erlaubt es dem Spiel im Hintergrund weiter zu laufen, auch wenn das Fenster keinen Fokus hat (zum Beispiel im Hintergrund läuft).";
            }
            public string _showScriptErrors_de()
            {
                return "Zeigt Skriptfehler in einer schwarzen Fenster auf dem Bildschirm an - wenn welche auftreten.";
            }
            public string _noFilePatching_de()
            {
                return "Stellt sicher, dass ausschließlich PBOs geladen werden und KEINE ungepackten Daten (nur für Entwickler notwendig)." +
                    WIKI_de();
            }
            public string _checkSignatures_de()
            {
                return "Wurde eingeführt um einen gründlichen Test aller geladenen Banken beim Spielstart durchzuführen. Die Ergebnisse werden in der RPT-Datei ausgegeben.";
            }
            public string _autoConnect_de()
            {
                return "Verbindet automatisch zum dem definierten Server. Diese Funktion scheint momentan in Arma nicht richtig zu laufen." +
                    WIKI_de();
            }
            #endregion
        }
        private OptionInfoDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ExecuteDialog(string option)
        {
            if (option == null)
                return DialogResult.Cancel;

            using (OptionInfoDialog dlg = new OptionInfoDialog())
            {
                HelpTextManager hm = new HelpTextManager();
                dlg.Text = string.Format(dlg.Text, option);
                dlg._Label.Text = hm.GetText(option);
                DialogResult result = dlg.ShowDialog();
                return result;
            }
        }
    }
}
