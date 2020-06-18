﻿using System;

//http://bgcoder.com/Contests/43/Telerik-Academy-Exam-1-29-Dec-2012
//http://telerikacademy.com/Courses/Courses/Details/212

//In Kaspichan we drink a lot.One evening we drunk enough so we invited an interesting game: Someone says a number. The first person after him rotates the digits of this number by moving its last digit at its start (e.g. 12345  51234). The second person after that again rotates the number(e.g. 51234  45123). Finally the third person after him also rotates the number(e.g. 45123  34512). The obtained number then is sent by SMS to a fellow group of alcoholics who continue the game at their drink place.
//Write a program that helps the Kaspichan drinkers to calculate the triple digits rotation of given number K.Note that zeroes could also take part in the play and the leading digits are lost after each rotation, e.g.the triple rotation of 180001 is 1180 (180001  118000  011800  11800  01180  1180).
//Input
//The input data should be read from the console and consists of a single line holding an integer number K.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//The output should consist of a single line holding the number obtained after applying a triple digits rotation of the number K.
//Constraints
//•	The number K is in the range [1…999 999] inclusive.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _30.TripleRotationOfDigits
{
   class TripleRotationOfDigits
   {
      static void Main(string[] args)
      {
         int number = int.Parse(Console.ReadLine());

         for (int i = 0; i < 3; i++)
         {

            if (number > 9)
            {
               int lastDigit = number % 10; //taking the last digit
               number /= 10; //getting rid of tha last digit

               string result = lastDigit.ToString() + number.ToString();

               number = int.Parse(result);
            }
            
         }
         Console.WriteLine(number);
      }
   }
}
