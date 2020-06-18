using System;

//http://bgcoder.com/Contests/3/CSharp-Fundamentals-2011-2012-Part-1-Test-Exam
//http://telerikacademy.com/Courses/LectureResources/Video/5473/Exam-preparation-%d0%9d%d1%8f%d0%ba%d0%be%d0%bb%d0%ba%d0%be-%d0%b7%d0%b0%d0%b4%d0%b0%d1%87%d0%b8-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be

//You are given a list of N integer numbers all but one of which appears an even number of times.
//Write a program to find the one integer which appears an odd number of times.
//Input
//The input data is being read from the console.
//The number N is written on the first input line.
//On each of the following N lines there is one integer number written – the consequent number from the given list of numbers.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data must be printed on the console.
//On the only output line you must print the integer from the list which appears an odd number of times.
//Constraints
//•	N will be positive odd integer number between 1 and 99 999, inclusive.
//•	All of the numbers in the list will be integer numbers between -9 223 372 036 854 775 808
//and 9 223 372 036 854 775 807, inclusive.
//•	Always only one answer will exists and will be unambiguous.
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.


namespace _21.OddNumbers
{
   class OddNumbers
   {
      static void Main()
      {
         long N = long.Parse(Console.ReadLine());

         long result = long.Parse(Console.ReadLine());

         for (int i = 1; i < N; i++)
         {
            result ^= long.Parse(Console.ReadLine());
         }
         Console.WriteLine(result);
      }
   }
}
