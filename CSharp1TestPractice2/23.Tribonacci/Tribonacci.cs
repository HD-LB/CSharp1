using System;
using System.Numerics;

//http://telerikacademy.com/Courses/LectureResources/Video/5476/Exam-preparation-Tribonacci-Quadronacci-Rectangle-%d0%af%d0%bd%d0%ba%d0%be
//http://bgcoder.com/Contests/2/Telerik-Academy-Exam-1-6-Dec-2011-Morning

//The Tribonacci sequence is a sequence in which every next element is made by the sum of the previous three elements from the sequence.

//Write a computer program that finds the Nth element of the Tribonacci sequence, if you are given the first three elements of the sequence and the number N. Mathematically said: with given T1, T2 and T3 – you must find Tn.
//Input
//The input data should be read from the console.
//The values of the first three Tribonacci elements will be given on the first three input lines.
//The number N will be on the fourth line.This is the number of the consecutive element of the sequence that must be found by your program.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//At the only output line you must print the Nth element of the given Tribonacci sequence.
//Constraints
//•	The values of the first three elements of the sequence will be integers between -2 000 000 000 and 2 000 000 000.
//•	The number N will be a positive integer between 1 and 15 000, inclusive.
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.


namespace _23.Tribonacci
{
   class Tribonacci
   {
      static void Main()
      {
         BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
         BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
         BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());

         int n = int.Parse(Console.ReadLine());

         if (n == 1)
         {
            Console.WriteLine(firstNumber);
         }
         else if (n == 2)
         {
            Console.WriteLine(secondNumber);
         }
         else if (n == 3)
         {
            Console.WriteLine(thirdNumber);
         }
         else
         {
            BigInteger result = 0;

            for (int i = 3; i < n; i++) //we already have the first 3 numbers
            {
               result = firstNumber + secondNumber + thirdNumber;
               firstNumber = secondNumber;
               secondNumber = thirdNumber;
               thirdNumber = result;
            }

            Console.WriteLine(result);
         }
      }
   }
}
