using System;

//http://bgcoder.com/Contests/41/Telerik-Academy-Exam-1-27-Dec-2012
//http://telerikacademy.com/Courses/Courses/Details/212

//We are given a date(day + month + year). Write a program to print the next day.
//Input
//The input data consists of 3 lines holding the integer numbers: day, month and year.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console in the format day.month.year (no leading zeroes).
//Constraints
//•	The number day is in the range[1…31] inclusive.
//•	The number month is in the range[1…12] inclusive.
//•	The number year is in the range[2000…2013] inclusive.
//•	The date is valid according to the classical calendar system.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _29.NextDate
{
   class NextDate
   {
      static void Main()
      {
         int day = int.Parse(Console.ReadLine());
         int month = int.Parse(Console.ReadLine());
         int year = int.Parse(Console.ReadLine());

         DateTime currentDate = new DateTime(year, month, day);

         currentDate = currentDate.AddDays(1); //adds 1 day to the date

         Console.WriteLine(currentDate.Day + "." + currentDate.Month + "." + currentDate.Year);
      }
   }
}
