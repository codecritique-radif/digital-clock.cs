using System;
using System.Timers;

namespace DigitalClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Update the clock every second
            timer.Elapsed += TimerElapsed;
            timer.Start();

            Console.WriteLine("Press any key to stop the clock...");
            Console.ReadKey();

            timer.Stop();
        }

        static void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}