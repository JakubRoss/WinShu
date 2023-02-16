using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinShu
{
    public class Utils
    {
        public static string Shutty(DateTime time) 
        {

            var now = DateTime.Now;
            if (time < now)
            {
                time = time.AddDays(1);
            }

            TimeSpan timeUntilShutdown = time - now;
            int totalSeconds = (int)timeUntilShutdown.TotalSeconds;

            Process.Start("shutdown", $"-s -t {totalSeconds}");

            var when = timeUntilShutdown.Hours.ToString();
            return when;
        }
        public static void GetProcess()
        {
            Process[] processes = Process.GetProcessesByName("shutdown");

            if (processes.Length > 0)
            {
                foreach (Process shutdownProcess in processes)
                {
                    // tutaj możesz wykonywać operacje na każdym z procesów "shutdown.exe"
                }
            }
            else
            {
                // nie ma żadnego procesu "shutdown.exe" uruchomionego
            }
        }
        public static void hidePanel(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
        }
        public static void showPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                hidePanel(panel);
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }
        public static void hideAllPanels()
        {
            
        }
    }
}
