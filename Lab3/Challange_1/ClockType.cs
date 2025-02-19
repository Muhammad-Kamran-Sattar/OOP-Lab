using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    public class ClockType
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        public ClockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public ClockType(int h)
        {
            hours = h;
        }
        public ClockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public ClockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void increamentSeconds()
        {
            seconds++;
        }
        public void increamentMinutes()
        {
            minutes++;
        }
        public void increamentHours()
        {
            hours++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(ClockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ClockType GetRemainingTime()
        {
            // Total seconds in a day
            int totalSecondsInDay = 24 * 3600;

            // Convert current time to total seconds
            int currentTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

            // Calculate remaining seconds
            int remainingSeconds = totalSecondsInDay - currentTimeInSeconds;

            // Handle case where current time is exactly 24:00:00
            if (remainingSeconds < 0)
            {
                remainingSeconds = 0;
            }

            // Convert remaining seconds back to hours, minutes, and seconds
            int remainingH = remainingSeconds / 3600;
            int remainingM = (remainingSeconds % 3600) / 60;
            int remainingS = remainingSeconds % 60;

            return new ClockType(remainingH, remainingM, remainingS);
        }

        // Override ToString to display time in HH:MM:SS format

        public static ClockType GetElapsedTime(ClockType startTime, ClockType endTime)
        {
            // Convert both times to total seconds
            int startTimeInSeconds = startTime.hours * 3600 + startTime.minutes * 60 + startTime.seconds;
            int endTimeInSeconds = endTime.hours * 3600 + endTime.minutes * 60 + endTime.seconds;

            // Handle case where end time is on the next day (e.g., start at 23:00:00, end at 01:00:00)
            if (endTimeInSeconds < startTimeInSeconds)
            {
                endTimeInSeconds += 24 * 3600; // Add 24 hours in seconds
            }

            // Calculate elapsed time in seconds
            int elapsedSeconds = endTimeInSeconds - startTimeInSeconds;

            // Convert elapsed seconds back to hours, minutes, and seconds
            int elapsedH = elapsedSeconds / 3600;
            int elapsedM = (elapsedSeconds % 3600) / 60;
            int elapsedS = elapsedSeconds % 60;

            return new ClockType(elapsedH, elapsedM, elapsedS);
        }

        // Override ToString to display time in HH:MM:SS format
        public override string ToString()
        {
            return $"{hours:D2} : {minutes:D2} : {seconds:D2}";
        }

    }
}
