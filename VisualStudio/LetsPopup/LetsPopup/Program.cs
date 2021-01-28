using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LetsPopup
{
    static class Program
    {
        public static int count = 1;

        private static readonly List<string> blackList = new List<string>() {
            "porn",
            "sex",
        };

        [STAThread]
        static void Main() {
            while (count < 50) {
                while (CheckAllProcesses()) {
                    UpdateWindowsRecs();
                    foreach (var win in windowsOnScreen) {
                        Console.WriteLine(win);
                    }
                    Console.WriteLine();
                    Thread.Sleep(4000);
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                count++;
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private static string GetActiveWindowTitle() {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0) {
                return Buff.ToString();
            }

            return null;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }

            public override string ToString() {
                return "("+ Left + "," + Top +")" + "(" + Right + "," + Bottom + ")";
            }
        }

        public struct Window
        {
            public Process Pros { get; set; }
            public Rect Rec { get; set; }

            public override string ToString()
            {
                return Rec + " - " + Pros.MainWindowTitle;
            }
        }

        public static Window[] windowsOnScreen = new Window[0];

        private static void UpdateWindowsRecs() {
            List<Window> windows = new List<Window>();

            foreach (var proc in GetAllProcesses()) {
                IntPtr ptr = proc.MainWindowHandle;
                if (ptr != IntPtr.Zero)
                {
                    WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
                    GetWindowPlacement(ptr, ref placement);
                    // if (placement.showCmd == 2) continue;
                }

                Window win = new Window();
                win.Pros = proc;
                Rect rect = new Rect();
                GetWindowRect(ptr, ref rect);
                win.Rec = rect;
                windows.Add(win);
            }

            windowsOnScreen = windows.ToArray();
        }

        private static bool CheckAllProcesses() {
            foreach (var proc in GetAllProcesses()) {
                foreach (var item in blackList)
                {
                    if (proc.MainWindowTitle.ToLower().Contains(item))
                    {
                        Console.Write(proc.MainWindowTitle + " - ");
                        Console.WriteLine(proc.Id.ToString());
                        proc.Kill();
                    }
                }
            }
            return true;
        }

        private static Process[] GetAllProcesses() {
            Process[] processes = Process.GetProcesses();
            List<Process> retList = new List<Process>();
            foreach (Process proc in processes)
            {
                if (proc.MainWindowTitle != null && proc.MainWindowTitle != "") retList.Add(proc);
            }
            return retList.ToArray();
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        private struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        
        
    }
}
