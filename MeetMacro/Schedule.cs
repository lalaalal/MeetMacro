﻿using System;
namespace MeetMacro
{
    public abstract class Schedule
    {
        public class Time
        {
            public int Hour { get; set; }
            public int Minute { get; set; }

            public static Time Now { get => new Time(DateTime.Now.Hour, DateTime.Now.Minute); }

            public Time(int hour = 0, int minute = 0)
            {
                Hour = hour;
                Minute = minute;
            }

            public static Time Parse(string str)
            {
                string[] s = str.Split(':');

                return new Time(int.Parse(s[0]), int.Parse(s[1]));
            }

            public static Time[] Parse(string[] arr)
            {
                Time[] times = new Time[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                    times[i] = Parse(arr[i]);

                return times;
            }

            public int ToMinute()
            {
                return Hour * 60 + Minute;
            }

            public static Time operator +(Time a, Time b)
            {
                int sumMinute = (a.Minute + b.Minute);
                int carry = sumMinute / 60;
                int minute = sumMinute % 60;
                int hour = (a.Hour + b.Hour + carry) % 24;

                return new Time(hour, minute);
            }

            public static Time operator -(Time a, Time b)
            {
                int sumMinute = a.Minute - b.Minute;
                int carry = (sumMinute + 60) / 60 - 1;
                int minute = (sumMinute + 60) % 60;
                int hour = (a.Hour - b.Hour + carry + 24) % 24;

                return new Time(hour, minute);
            }

            public static bool operator ==(Time a, Time b) => a.Hour == b.Hour && a.Minute == b.Minute;

            public static bool operator !=(Time a, Time b) => !(a == b);

            public static bool operator <(Time a, Time b) => a.ToMinute() < b.ToMinute();

            public static bool operator >(Time a, Time b) => a.ToMinute() > b.ToMinute();

            public static bool operator <=(Time a, Time b) => !(a > b);

            public static bool operator >=(Time a, Time b) => !(a < b);

            public override bool Equals(object obj)
            {
                return obj is Time time &&
                       Hour == time.Hour &&
                       Minute == time.Minute;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Hour, Minute);
            }

            public override string ToString()
            {
                return string.Format("{0:00}:{1:00}", Hour, Minute);
            }
        }

        public Time[] StartTime;

        public Time[] EndTime;

        protected string[,] _code;

        public static readonly string[] DayOfWeekCode =
{
            "mon", "tue", "wed", "thu", "fri"
        };

        public static readonly string[] Type =
        {
            "isdj", "sat"
        };

        // <summary>
        // Code[dayOfWeek, classNo]
        // </summary>
        public string[,] Code { private set => _code = value; get => _code; }

        public void SetCode(int dayOfWeek, int classNo, string code)
            => _code[dayOfWeek, classNo] = code;

        public abstract void SetDefault(string classroom);

        public static Schedule CreateSchedule(string type) => type switch
        {
            "isdj" => new ISDJSchedule(),
            "sat" => new SATSchedule(),
            _ => null,
        };

        protected Schedule(string[] startTime, string[] endTime, string[,] code)
        {
            StartTime = Time.Parse(startTime);
            EndTime = Time.Parse(endTime);
            _code = code;
        }

        public int GetNextClassNo(Time time)
            => _GetNextClassNo(time, 0, StartTime.Length - 1);

        private int _GetNextClassNo(Time time, int from, int to)
        {
            if (from >= to)
            {
                if (time > StartTime[from])
                    return from + 1;
                return from;
            }                

            int pick = (to + from + 1) / 2;

            if (time < StartTime[pick])
                return _GetNextClassNo(time, from, pick - 1);
            if (time == StartTime[pick])
                return pick + 1;
            else
                return _GetNextClassNo(time, pick + 1, to);

        }
    }
}
