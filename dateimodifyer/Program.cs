using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection;
using System.IO;



namespace dateimodifyer
{

    internal static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        internal static extern Boolean AllocConsole();
    }

    static class Program
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        [DllImport("kernel32", SetLastError = true)]
        static extern bool AttachConsole(int dwProcessId);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        static String datei = "", options = "", dt = "";

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //als Windows Anwendung starten
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            { // als Consolenanwendung starten


                IntPtr ptr = GetForegroundWindow();
                int u;

                GetWindowThreadProcessId(ptr, out u);
                Process process = Process.GetProcessById(u);

                appinfo ai = new appinfo();
                String copyright = ai.getCopyright();
                String description = ai.getDescription();
                String firma = ai.getCompany();
                String features = "\nEnthaltene Features:\n- editieren des Erstellungsdatums\n- editieren der letzten Zugriffszeit\n- editieren der zuletzt geänderten Zeit";

                String starttext = "\n==============\n" +
                    Application.ProductName + " " +
                    "Version " + Application.ProductVersion +
                                "\n" + copyright +
                                " (" + firma + ")" +
                                "\n\n" + description + features +
                                                                                         "\n==============";

                if (process.ProcessName == "cmd")    //Is the uppermost window a cmd process?
                {
                    //In der existierenden Console fortsetzen
                    AttachConsole(process.Id);


                    Console.Write("\n");
                    Console.WriteLine(starttext);

                    miniTool(args);
                    //Console.ReadLine();
                }
                else
                {
                    //in neuer Console fortsetzen
                    NativeMethods.AllocConsole();
                    Console.Write("\n");
                    Console.WriteLine(starttext);
                    //Console.ReadLine();                    
                }
            }

        }

        static void miniTool(string[] args)
{
             //start debugging
    Console.WriteLine("Number of command line parameters = {0}",
args.Length);
    for (int i = 0; i < args.Length; i++)
    {
        Console.Write("{0} ", args[i]);
    }

    foreach (String value in args)
    {
        String eingabe = value.ToLower();

        switch(eingabe)
        {
            case "/file":
            case "-file":
            case "file=":
            case "file =":
            case "file = ":
                Console.Write("\n filename ausgewählt");
                break;

            default:
            Console.Write("\ndateiname: " + eingabe);
            break;
    }

        String[] arguments = Environment.GetCommandLineArgs();
              Console.WriteLine("\neingabe: {0}", String.Join(", ", arguments));
        
        Console.Write("");
    }                


               
            Console.WriteLine("\n" + datei);
    //aktuelle uhrzeit ermitteln
    String datum = DateTime.Now.ToShortDateString();
    String uhr = DateTime.Now.ToLongTimeString();
    Console.WriteLine("\nuhrzeit: " + datum + " " + uhr);
    //end debugging
         }


        //änderungen durchführen
        static int filechange(string dateiname, String op, String zeit)
        {
            if (dateiname == null || dateiname.Length <=0)
                return 0;
                                                   /*
            if (zeit.Length <= 0)
                return 0;

            if (dt.Length <= 0)
                return 0;
                                                     */
            

            return 0;
        }


    }
}
