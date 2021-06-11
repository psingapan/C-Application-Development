using System;

namespace Singapan_CSC205_Week2Assignment
{
    class Time

    {
        static void Main(string[] args)
        {
            int hour, minute, second;
            hour = 17;
            minute = 03;
            second = 53; //Problem 2 Following the example in Section 2.6, create variables named hour, minute and second, and assign them values that are roughly the current time.
            
            Console.Write("Number of seconds since midnight: "); //Problem 3 Make the program calculate and print the number of seconds since midnight.
            int secondsMidnight = hour * 3600 + second;
            Console.WriteLine(secondsMidnight); 
           
            Console.Write("The number of seconds remaining in the day is: "); //Problem 4 Make the program calculate and print the number of seconds remaining in the day.
            int secondsLeftDay = 86400 - secondsMidnight;
            Console.WriteLine(secondsLeftDay);

            Console.Write("The percentage of the day that has passed: ");
            int percentageOfDay = secondsMidnight * 100 / 86400;
            Console.WriteLine(percentageOfDay + "%");


        }
    }
}
