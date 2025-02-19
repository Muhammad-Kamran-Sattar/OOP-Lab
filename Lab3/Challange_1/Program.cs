using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClockType empty_time = new ClockType();
            Console.WriteLine("Empty Time: ");
            empty_time.printTime();

            ClockType hour_time = new ClockType(8);
            Console.Write("Hour time: ");
            hour_time.printTime();

            ClockType minute_time = new ClockType(8, 10);
            Console.Write("Minute time: ");
            minute_time.printTime();

            ClockType full_time = new ClockType(8, 10, 10);
            Console.Write("Full time: ");
            full_time.printTime();

            // increment second.
            full_time.increamentSeconds();
            Console.Write("Full time (Increment Second): ");
            full_time.printTime();

            full_time.increamentHours();
            Console.Write("Full time (Increment hours): ");
            full_time.printTime();

            full_time.increamentMinutes();
            Console.Write("Full time (Increment Mintues): ");
            full_time.printTime();
            

            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag:" + flag); 

            ClockType cmp = new ClockType(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag:" + flag);



            ClockType currentTime = new ClockType(20, 20, 20);
            ClockType remainingTime = currentTime.GetRemainingTime();

            Console.WriteLine("Current Time: " + currentTime);
            Console.WriteLine("Remaining Time until 24:00:00: " + remainingTime);




            // Define start and end times
            ClockType startTime = new ClockType(14, 30, 45); // 2:30:45 PM
            ClockType endTime = new ClockType(16, 45, 10);  // 4:45:10 PM

            // Calculate elapsed time
            ClockType elapsedTime = ClockType.GetElapsedTime(startTime, endTime);

            // Display the results
            Console.WriteLine("Start Time: " + startTime);
            Console.WriteLine("End Time: " + endTime);
            Console.WriteLine("Elapsed Time: " + elapsedTime);

        }
    }
}
