﻿using System;
using System.Linq;

//http://bgcoder.com/Contests/2/Telerik-Academy-Exam-1-6-Dec-2011-Morning
//http://telerikacademy.com/Courses/LectureResources/Video/5473/Exam-preparation-%d0%9d%d1%8f%d0%ba%d0%be%d0%bb%d0%ba%d0%be-%d0%b7%d0%b0%d0%b4%d0%b0%d1%87%d0%b8-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be

//One of the things the programmers love the most is bitwise operations.The "bitwise guy" is a synonym for a programmer that loves bits more than everything else in programming.Mitko is a "bitwise guy". He invented a new bitwise algorithm.The algorithm takes one positive integer number P, makes magic with it and returns a new positive integer number.He also defined a new number P̃ which represents the number P in binary numeral system with inverted bits.All zeros in P are ones in P̃ and all ones in P are zeros in P̃.For example if we have P = 9(which is 1001 in binary numeral system) its inverted number P̃ will be equal to 6 (which is 110 in binary numeral system). But that’s not all! He invented another number P̈, which represents reversed number P in binary numeral system.For example if we have P = 11 (which is 1011 in binary numeral system) its reversed number P̈ is equal to 13 (which is 1101 in binary numeral system). The Mitko's magical algorithm takes a number P and transforms it to a new number Pnew using the following bitwise transformation: Pnew = (P ^ P̃) & P̈.
//Your task is to write a program that transforms a sequence of N positive integer numbers using Mitko's algorithm.
//Input
//The input data should be read from the console.
//At the first input line there will be one positive integer – the number N.
//At each of the next N lines there will be one positive integer – the consequent number that must be converted using Mitko's algorithm.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//The output must consist of N lines, containing the transformed numbers for each number from the input.
//Constraints
//•	The number N will be positive integer number between 1 and 20 000, inclusive.
//•	Each of the N numbers will be positive integer numbers between 1 and 2 147 483 647, inclusive.
//•	Allowed working time for your program: 0.20 seconds.
//•	Allowed memory: 16 MB.


namespace _22.WeAllLoveBits
{
   class WeAllLoveBits
   {
      static void Main()
      {
         int N = int.Parse(Console.ReadLine());

         for (int i = 0; i < N; i++)
         {
            int number = int.Parse(Console.ReadLine());

            string normalNumberAsString = Convert.ToString(number, 2);
            string reversedNumberAsString = ""; //string.Empty;

            for (int j = normalNumberAsString.Length - 1; j >= 0; j--) //reversing the number
            {
               reversedNumberAsString += normalNumberAsString[j];
            }

            int endResult = Convert.ToInt32(reversedNumberAsString, 2);
            Console.WriteLine(endResult);

         }
      }
   }
}
