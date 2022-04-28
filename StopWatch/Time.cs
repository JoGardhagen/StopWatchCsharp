using System;
namespace StopWatch
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;


        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public Time(string currentTime)
        {
            string[] time = currentTime.Split(":");
            hour = int.Parse(time[0]);
            minute = int.Parse(time[1]);
            second = int.Parse(time[2]);
        }
        public string getCurrentTime()
        {
            return hour + ":" + minute + ":" + second;
        }
        public string timeReset(string currentTime)
        {
            string[] time = currentTime.Split(":");
            hour = int.Parse(time[0]);
            minute = int.Parse(time[1]);
            second = int.Parse(time[2]);

            //hour = Integer.parseInt(time[0]);
            //minute = Integer.parseInt(time[1]);
            //second = Integer.parseInt(time[2]);
            hour = 0;
            minute = 0;
            second = 0;
            return hour + ":" + minute + ":" + second;
        }
        public void oneSecondPassed()
        {
            second++;
            if (second == 60)
            {
                minute++;
                second = 0;
                if (minute == 60)
                {
                    hour++;
                    minute = 0;
                    if (hour == 24)
                    {
                        hour = 0;
                        Console.WriteLine("Next day");
                    }
                }
            }
        }
    }
}
