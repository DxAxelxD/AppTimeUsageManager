using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
        private static bool appCatcherRunning;
        public static void Start()
        {
            //Starts the app catcher service
                Process process = catchApps();
            actualActiveApp = process.ProcessName;
        }
        public static void Stop()
        {
            //Stops the app catcher service
            appCatcherRunning = false;
        }
        private static Process catchApps()
        {
            IntPtr handle = GetForegroundWindow();

            if (handle != IntPtr.Zero)
            {
                uint processId;
                GetWindowThreadProcessId(handle, out processId);
                Process process = Process.GetProcessById((int)processId);
                return process;
            }
            else
            {
                actualActiveApp = "Null process (a) test.";
            }
            return null;
        }
        public static string GetActualActiveApp()
        {
            return actualActiveApp;
        }
    }
}
