using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Project_1.PresentationLayer
{  
    public class Timer
    {
        delegate void Handler(object sender, EventArgs e);
        event Handler durationChange;

        public int interval { get; private set; }
        public int TimeLeft { get; private set; }
        public int Elapsed { get; private set; }

        int defaultInterval, defaultTimeLeft;
        long StartTime = 0, PauseStart = 0;

        Thread thread;
        public Thread GetThread()
        {
            return thread;
        }
        public void SetInterval(int intervalMS)
        {
            defaultInterval = intervalMS;
        }
        public void SetDuration(int durationMS)
        {
            defaultTimeLeft = durationMS;
        }
        public Timer(int durationMS, int intervalMS = 1000)
        {
            Elapsed = 0;
            TimeLeft = durationMS;
            interval = 0;
            defaultInterval = intervalMS;
            defaultTimeLeft = durationMS;
            thread = new Thread(ThreadStart);
        }
        public void Start()
        {
            Init();
            thread.Start();
        }
        public void Pause()
        {
            PauseStart = DateTime.Now.Ticks;
            interval = 0;
        }
        public void Resume()
        {
            if (PauseStart > 0)
            {
                StartTime += TimeSpan.FromTicks(DateTime.Now.Ticks - PauseStart).Ticks;
                PauseStart = 0;
            }
            interval = defaultInterval;
        }
        public void Restart()
        {
            Init();

            if (!thread.IsAlive)
                thread.Start();
        }
        void Init()
        {
            TimeLeft = defaultTimeLeft;
            interval = defaultInterval;
            StartTime = DateTime.Now.Ticks;
        }
        void ThreadStart()
        {
            durationChange += new Handler(OnInterval);
            EventArgs e = new EventArgs();

            while (TimeLeft > 0)
                durationChange.Invoke(this, e);
        }
        void OnInterval(object sender, EventArgs e)
        {
            if (interval > 0)
            {
                Thread.Sleep(interval);
                Elapsed = (int)TimeSpan.FromTicks(DateTime.Now.Ticks - StartTime).TotalMilliseconds;

                TimeLeft = defaultTimeLeft - Elapsed;
            }
        }
    }
}