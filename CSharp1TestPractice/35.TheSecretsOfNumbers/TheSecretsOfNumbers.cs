﻿using System;
using System.Numerics;

//http://bgcoder.com/Contests/93/Telerik-Academy-Exam-1-24-June-2013-Evening
//http://telerikacademy.com/Courses/Courses/Details/212

//The special sum of a number is the sum of its digits calculated by the following algorithm:
//•	Each digit with odd position from right to left adds to the special sum its value multiplied by the square of its position in the number.
//•	Each digit with even position from right to left adds to the special sum the square of its value multiplied by its position in the number.
//For example if the number is 37 its special sum is 7 * 12 + 32 * 2 = 25. Another example: if the number is 111 its special sum is 1 * 12 + 12 * 2 + 1 * 32 = 12.
//The secret alpha-sequence of a number is a sequence of capital letters from the English alphabet constructed by the number’s special sum.The length of the sequence is indicated by the last digit of the number’s special sum.If this length is 0 the number has no secret alpha-sequence.
//The number R represents the remainder of a number’s special sum divided by the number of letters in the alphabet (26). The first letter of the alpha-sequence is the letter from the English alphabet at position equal to the sum R + 1. Every next letter in the secret alpha-sequence is the next letter of the alphabet.If the last letter (‘Z’) is reached the sequence afterwards continues from the first letter of the alphabet(‘A’).
//For example if the special sum of a number is 3, its secret alpha-sequence is “DEF”. Another example: if the special sum of a number is 48 its secret alpha-sequence is “WXYZABCD”.
//Write a program that finds the special sum and the secret alpha-sequence of an integer number N.
//Input
//The input data should be read from the console.The only input line contains the integer number N to which the secret alpha-sequence is to be found.The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console. The output consists of two lines. On the first output line you must print input number’s special sum and on the second output line you must print its secret alpha-sequence or indicate its absence in format: “X has no secret alpha-sequence” where ‘X’ is the input number.
//Constraints
//•	The integer number N will have no more than 400 digits.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB


namespace _35.TheSecretsOfNumbers
{
   class TheSecretsOfNumbers
   {
      static void Main()
      {
         BigInteger n = BigInteger.Parse(Console.ReadLine()); //as per instructions

         int specialSum = 0;
         BigInteger number = n; // so we don't loose n 

         if (number < 0) //if the number is negative, turn it to a positive
         {
            number *= -1;
         }


         int position = 1;

         while (number > 0)
         {
            int digit = (int)(number % 10); //taking tha most right number
            number /= 10; //getting rid of the most right number

            if (position % 2 == 0)
            {
               specialSum += digit * digit * position;
            }
            else
            {
               specialSum += digit * position * position;
            }
            ++position;
         }
         Console.WriteLine(specialSum);


         int sequenceLenght = specialSum % 10; // the last digit in the number
         if (sequenceLenght == 0)
         {
            Console.WriteLine("{0} has no secret alpha-sequence", n);
         }
         else
         {
            int start = specialSum % 26;

            for (int i = 0; i < sequenceLenght; i++)
            {
               Console.Write((char)('A' + (start + i) % 26));
            }
            Console.WriteLine();
         }
      }
   }
}
