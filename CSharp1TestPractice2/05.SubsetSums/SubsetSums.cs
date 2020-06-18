using System;

//http://bgcoder.com/Contests/1/CSharp-Fundamentals-2011-2012-Part-1-Sample-Exam
//http://telerikacademy.com/Courses/LectureResources/Video/5454/%d0%9f%d1%80%d0%b8%d0%bc%d0%b5%d1%80%d0%b5%d0%bd-%d0%b8%d0%b7%d0%bf%d0%b8%d1%82-26-%d0%bd%d0%be%d0%b5%d0%bc%d0%b2%d1%80%d0%b8-2012-%d0%9d%d0%b8%d0%ba%d0%b8

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
//Examples


namespace _05.SubsetSums
{
   class SubsetSums
   {
      static void Main()
      {
         long s = long.Parse(Console.ReadLine());
         int n = int.Parse(Console.ReadLine());

         long[] nums = new long[n];

         for (long i = 0; i < n; i++)
         {
            nums[i] = int.Parse(Console.ReadLine());
         }

         int maxI = 1;


         for (int i = 1; i <= n; i++)  // 2*n - 1 //2^n - 1 (2 to the power on n -1)
         {
            maxI *= 2;
         }
         maxI -= 1;

         // maxI = (int)Math.Pow((double)2, n) - 1;


         int count = 0;
         for (int i = 1; i <= maxI; i++)
         {

            long currentSum = 0;
            for (int j = 0; j < n; j++)
            {
               int mask = 1 << j;
               int nAndMask = i & mask;
               int bit = nAndMask >> j;
               if (bit == 1)
               {
                  currentSum += nums[j];
               }
            }
            if (currentSum == s)
            {
               count++;
            }
         }
         Console.WriteLine(count);
      }
   }
}
