
using System.Diagnostics;
using Microsoft.Win32.TaskScheduler;


namespace WinShu
{
    public class Utils
    {
        
        public static Process Shutty(DateTime time) 
        {

            var now = DateTime.Now;
            if (time < now)
            {
                time = time.AddDays(1);
            }

            TimeSpan timeUntilShutdown = time - now;
            int totalSeconds = (int)timeUntilShutdown.TotalSeconds;

            var proces =Process.Start("shutdown", $"-s -t {totalSeconds}");
            return proces;
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
    }
}
