using System;
using System.Collections.Generic;


//http://telerikacademy.com/Courses/LectureResources/Video/5474/Exam-preparation-Subset-Sums-%d0%af%d0%bd%d0%ba%d0%be
//http://bgcoder.com/Contests/1/CSharp-Fundamentals-2011-2012-Part-1-Sample-Exam

//You are given a list of N numbers.Write a program that counts all non-empty subsets from this list, which have sum of their elements exactly S.
//Example: if you have a list with 4 elements: { 1, 2, 3, 4 }
//and you are searching the number of non-empty subsets which sum is 4, the answer will be 2. The subsets are: { 1, 3 } and { 4 }.
//Input
//The input data is being read from the console.
//On the first input line there will be the number S.
//On the second line you must read the number N.
//On each of the following N lines there will be one integer number written – all the numbers from the list.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output must be printed on the console.
//On the only output line you must print the number of the non-empty subsets, which have sum of all its elements exactly S.
//Constraints
//•	The number N is a positive integer between 1 and 16, inclusive.
//•	All of the N numbers are integer numbers and will be between -1 337 000 000 000 and 1 337 000 000 000, inclusive.
//•	The number S is an integer number between -21 392 000 000 000 and 21 392 000 000 000, inclusive.
//•	All of the N numbers will be distinct.
//•	Allowed work time for your program: 1 second.
//•	Allowed memory: 16 MB.




namespace _17.SubsetSum
{
   class SubsetSum
   {
      static void Main()  //not finished
      {
         long s = long.Parse(Console.ReadLine());
         byte n = byte.Parse(Console.ReadLine());

         long[] numbers = new long[n];
        
         for (int i = 0; i < n; i++)
         {
            numbers[i] = long.Parse(Console.ReadLine());
         }

         List<long> sums = new List<long>();

         for (int i = 0; i < n; i++)
         {
            for (int j = 0; j < sums.Count; j++)
            {
               sums.Add(sums[j] + numbers[i]);
            }
            sums.Add(numbers[i]);
         }
         Console.WriteLine(string.Join(", ", sums));
      }
   }
}
