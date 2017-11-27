using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Time
    {

        private int sec;
        private int min;
        private int hour;
        private int day;
        private int year;
        private ulong mill;
        public Time(ulong time)
        {
            this.mill = 0;
            this.year = 0;
            this.day = (int)(time / 86400);
            this.hour = (int)((time % 86400) / 3600);
            int min = (int)((time % 86400) % 3600);
            this.min = min / 60;
            this.sec = min % 60;
        }
        public Time(ulong mill, int year, int day, int hour, int min, int sec)
        {
            this.mill = mill;
            this.year = year;
            this.day = day;
            this.hour = hour;
            this.min = min;
            this.sec = sec;

            if (this.sec >= 60)
            {
                this.min += this.sec / 60;
                this.sec = this.sec % 60;
            }
            if (this.min >= 60)
            {
                this.hour += this.min / 60;
                this.min = this.min % 60;
            }
            if (this.hour >= 24)
            {
                this.day += this.hour / 24;
                this.hour = this.hour % 24;
            }
            if (this.day >= 365)
            {
                this.year += this.day / 365;
                this.day = this.day % 365;
            }
            if (this.year >= 1000000)
            {
                this.mill += (ulong)(this.year / 1000000);
                this.year = this.year % 1000000;
            }
        }

        private void Add(ulong mill, int year, int day, int hour, int min, int sec)
        {
            this.mill += mill;
            this.year += year;
            this.day += day;
            this.hour += hour;
            this.min += min;
            this.sec += sec;

            if (this.sec >= 60)
            {
                this.min += this.sec / 60;
                this.sec = this.sec % 60;
            }
            if (this.min >= 60)
            {
                this.hour += (this.min / 60);
                this.min = this.min % 60;
            }
            if (this.hour >= 24)
            {
                this.day += this.hour / 24;
                this.hour = this.hour % 24;
            }
            if ((this.day >= 365 && this.year % 4 != 0))
            {
                this.year += this.day / 365;
                this.day = this.day % 365;
            }
            if (this.year >= 1000000)
            {
                this.mill += (ulong)(this.year / 1000000);
                this.year = this.year % 1000000;
            }
        }

        private void Add(int sec)
        {
            this.sec += sec;

            if (this.sec >= 60)
            {
                this.min += this.sec / 60;
                this.sec = this.sec % 60;
            }
            if (this.min >= 60)
            {
                this.hour += (this.min / 60);
                this.min = this.min % 60;
            }
            if (this.hour >= 24)
            {
                this.day += this.hour / 24;
                this.hour = this.hour % 24;
            }
            if ((this.day >= 365 && this.year % 4 != 0))
            {
                this.year += this.day / 365;
                this.day = this.day % 365;
            }
            if (this.year >= 1000000)
            {
                this.mill += (ulong)(this.year / 1000000);
                this.year = this.year % 1000000;
            }
        }

        private void Sub(int sec)
        {
            this.sec -= sec;
            bool did = false;
            do
            {
                did = false;
                if (this.sec < 0)
                {
                    this.min -= 1;
                    this.sec = 60;
                    did = true;
                }
                if (this.min < 0)
                {
                    this.hour -= 1;
                    this.min += 60;
                    did = true;
                }
                if (this.hour < 0)
                {
                    this.day -= 1;
                    this.hour += 24;
                    did = true;
                }
                if (this.day < 0)
                {
                    this.year -= 1;
                    this.day += 365;
                    did = true;
                }
                if (this.year < 0)
                {
                    this.mill -= 1;
                    this.year += 1000000;
                    did = true;
                }
            } while (did);

        }

        public static Time operator +(Time t, int t1)
        {
            Time time = new Time(t.mill, t.year, t.day, t.hour, t.min, t.sec);
            time.Add(t1);
            return time;
        }

        public static Time operator -(Time t, int t1)
        {
            Time time = new Time(t.mill, t.year, t.day, t.hour, t.min, t.sec);
            time.Sub(t1);
            return time;
        }

        public static Time operator +(Time t, Time t1)
        {
            Time time = new Time(t.mill, t.year, t.day, t.hour, t.min, t.sec);
            time.Add(t1.mill, t1.year, t1.day, t1.hour, t1.min, t1.sec);
            return time;
        }

        public static Time operator *(Time t, int mult)
        {
            mult = Math.Abs(mult);
            Time time = new Time(t.mill * (ulong)mult, t.year * mult, t.day * mult, t.hour * mult, t.min * mult, t.sec * mult);
            return time;
        }

        public override string ToString()
        {
            return string.Format("mill {0} years {1} days {2} {3, 2}:{4, 2}:{5, 2}", mill, year, day, string.Format("{0:00}", hour), string.Format("{0:00}", min), string.Format("{0:00}", sec));
        }
    }
}
