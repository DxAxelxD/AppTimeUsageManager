using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.DxAxelxD.Classes
{
    public static class AppCatcher
    {

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        private static string actualActiveApp;
        private static DateTime startTime;
        public static void Start()
        {
            //Starts the app catcher service
            startTime = DateTime.Now;
        }
        private static void catchApps()
        {
            IntPtr handle = GetForegroundWindow();

            if (handle != IntPtr.Zero)
            {
                uint processId;
                GetWindowThreadProcessId(handle, out processId);
                Process process = Process.GetProcessById((int)processId);
                actualActiveApp = process.ProcessName;
            }
            else
            {
                actualActiveApp = "Null process";
            }
        }
    }
}
