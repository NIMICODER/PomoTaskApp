using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomoTaskApp
{
    public class PomoTimer
    {
        Stopwatch stopwatch = new Stopwatch();

        private int workTim;
        private int restTim;

        public PomoTimer(int workTim, int restTim)
        {
           // _stopwatch = stopwatch;
            this.workTim = workTim;
            this.restTim = restTim;
        }

        

        public void beginWork()
        {
            Stopwatch stopwatch = new Stopwatch();  


            stopwatch.Start();
            var workStartTime = DateTime.Now.ToString("HH:mm");

            Thread.Sleep(workTim);

            stopwatch.Stop();
            var workEndTime = DateTime.Now.ToString("HH:mm");

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTim = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds/10);


            Console.WriteLine($"\n Your work lasted for {elapsedTim}  \n {workStartTime} - {workEndTime} ");

        }

        public void restTime()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var restStartTime = DateTime.Now.ToString("  HH:mm");

            Thread.Sleep(restTim);

            stopWatch.Stop();
            var restEndTime = DateTime.Now.ToString("HH:mm");

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine($"\nRest time lasted for {elapsedTime} \n{restStartTime} - {restEndTime}");
        }
    }
}
