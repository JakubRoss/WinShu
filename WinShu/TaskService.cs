using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinShu
{
    internal class TaskService
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
    }
}
