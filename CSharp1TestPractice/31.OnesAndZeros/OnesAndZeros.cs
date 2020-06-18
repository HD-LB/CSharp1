using System;

//http://bgcoder.com/Contests/105/Telerik-Academy-Exam-1-5-December-2013-Evening
//http://telerikacademy.com/Courses/Courses/Details/212

//You are given a non-negative integer number N.Your task is to print the last 16 bits of the binary representation of N on the console. Every bit is printed in a rectangular area with 5 rows and 3 columns.

//A bit with value of 1 should be printed in the format:
//.#.
//##.
//.#. 
//.#.
//###

//A bit with value of 0 should be printed in the format:
//###
//#.#
//#.#
//#.#
//###

//Between every single bit there should be an empty column containing only dots (".").
//Input
//The input data should be read from the console.
//On the only input line there will be a non-negative integer number N which bits must be printed on the console.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//You should print the last 16 bits of N on the console in the described format.
//Your output should contain exactly 5 lines with 63 symbols on each line. Symbols should be only hashes ("#") and dots(".").
//Constraints
//•	The number N will be a non-negative integer number between 0 and 2147483647, inclusive.
//•	The only C# Console methods that you are allowed to use are Console.Write() and Console.WriteLine(). This means that Console.SetCursorPosition() will not work. 
//•	Allowed working time for your program: 0.10 seconds.
//•	Allowed memory: 16 MB.


namespace _31.OnesAndZeros
{
   class OnesAndZeros
   {
      static void Main()
      {
         //read input

         int num = int.Parse(Console.ReadLine());
         string bin = Convert.ToString(num, 2).PadLeft(32, '0');

         ////logic

         //string oneRow0 = ".#.";
         //string oneRow1 = "##.";
         //string oneRow2 = ".#.";
         //string oneRow3 = ".#.";
         //string oneRow4 = "###";

         //string zeroRow0 = "###";
         //string zeroRow1 = "#.#";
         //string zeroRow2 = "#.#";
         //string zeroRow3 = "#.#";
         //string zeroRow4 = "###";

         ////row 0
         //for (int i = 16; i < bin.Length; i++) //it starts from right to left
         //{
         //   if (bin[i] == '1')
         //   {
         //      Console.Write(oneRow0);
         //   }
         //   else
         //   {
         //      Console.Write(zeroRow0);
         //   }
         //   if (i != bin.Length - 1)
         //   {
         //      Console.Write('.');
         //   }

         //}
         //Console.WriteLine();

         ////row 1
         //for (int i = 16; i < bin.Length; i++) //it starts from right to left
         //{
         //   if (bin[i] == '1')
         //   {
         //      Console.Write(oneRow1);
         //   }
         //   else
         //   {
         //      Console.Write(zeroRow1);
         //   }
         //   if (i != bin.Length - 1)
         //   {
         //      Console.Write('.');
         //   }

         //}
         //Console.WriteLine();

         ////row 2
         //for (int i = 16; i < bin.Length; i++) //it starts from right to left
         //{
         //   if (bin[i] == '1')
         //   {
         //      Console.Write(oneRow2);
         //   }
         //   else
         //   {
         //      Console.Write(zeroRow2);
         //   }
         //   if (i != bin.Length - 1)
         //   {
         //      Console.Write('.');
         //   }

         //}
         //Console.WriteLine();

         ////row 3
         //for (int i = 16; i < bin.Length; i++) //it starts from right to left
         //{
         //   if (bin[i] == '1')
         //   {
         //      Console.Write(oneRow3);
         //   }
         //   else
         //   {
         //      Console.Write(zeroRow3);
         //   }
         //   if (i != bin.Length - 1)
         //   {
         //      Console.Write('.');
         //   }

         //}
         //Console.WriteLine();

         ////row4 
         //for (int i = 16; i < bin.Length; i++) //it starts from right to left
         //{
         //   if (bin[i] == '1')
         //   {
         //      Console.Write(oneRow4);
         //   }
         //   else
         //   {
         //      Console.Write(zeroRow4);
         //   }
         //   if (i != bin.Length - 1)
         //   {
         //      Console.Write('.');
         //   }

         //}
         //Console.WriteLine();



         string[] one = { ".#.",
                          "##.",
                          ".#.",
                          ".#.",
                          "###" };

         string[] zero = { "###",
                           "#.#",
                           "#.#",
                           "#.#",
                           "###" };

         for (int row = 0; row < one.Length; row++)
         {
            for (int i = 16; i < bin.Length; i++) //it starts from right to left
            {
               if (bin[i] == '1')
               {
                  Console.Write(one[row]);
               }
               else
               {
                  Console.Write(zero[row]);
               }
               if (i != bin.Length - 1)
               {
                  Console.Write('.');
               }

            }
            Console.WriteLine();
         }
      }
   }
}
