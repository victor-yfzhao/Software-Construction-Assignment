using System.Reflection;

namespace Task2
{
    public delegate void ClockHandler(object sender, ClockEventArgs args);

    public class ClockEventArgs
    {
        public ClockEventArgs(int s)
        {
            this.s = s;
        }

        public int s { get; set; }
    }

    public class Clock
    {
        public int seconds { get; set; }

        public Clock() { seconds = -1; }
        
        public event ClockHandler OnTick;
        public event ClockHandler OnAlarm;

        public void runClock()
        {
            ClockEventArgs args = new ClockEventArgs(seconds);
            while (seconds > 0)
            {
                args.s = seconds;
                OnTick(this, args);
                seconds--;
                Thread.Sleep(1000);
            }
            args.s = seconds;
            OnAlarm(this, args);
        }
    }

    public class ClockApp
    {
        public Clock clock = new Clock();

        public ClockApp()
        {
            clock.OnTick += Clock_OnTick;
            clock.OnAlarm += Clock_OnAlarm;
        }

        private void Clock_OnAlarm(object sender, ClockEventArgs args)
        {
            Console.WriteLine("Time is up!");
        }

        private void Clock_OnTick(object sender, ClockEventArgs args)
        {
            Console.WriteLine("Tick! "+ args.s + " second(s) last!");
        }
    }

    public class TestDemo
    {
        public static void Main()
        {
            ClockApp myApp = new ClockApp();
            myApp.clock.seconds = 30;
            myApp.clock.runClock();
        }
    }
}