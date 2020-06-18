﻿using System;

//http://bgcoder.com/Contests/41/Telerik-Academy-Exam-1-27-Dec-2012
//http://telerikacademy.com/Courses/LectureResources/Video/5473/Exam-preparation-%d0%9d%d1%8f%d0%ba%d0%be%d0%bb%d0%ba%d0%be-%d0%b7%d0%b0%d0%b4%d0%b0%d1%87%d0%b8-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be

//Asya loves confetti.One day she decided to create exactly N small pieces of sheets with paper size A10.
//A10 is a standard for paper sizes. A9 is another standard that is twice as bigger as A10, so A9 can be cut into 2 pieces of size A10. A8 is twice as bigger as A9 and so on. A0 is twice as bigger as A1.See the picture on the left.
//Asya has only one sheet of each type (totally 11 sheets). She wants to have exactly N pieces of size A10 by cutting as few sheets as possible.
//Asya should not have any wasted sheets.
//Write a program for her.
//For example if we want to cut sheets into 9 pieces with the size of A10, we will use the only A7 sheet(cut into 8 pieces of size A10) and the only sheet with size A10.Then we will use 2 sheets.All other 9 sheets will not be used.
//Input
//On the only line of the input there will be the number N.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//Print the sizes of the sheets that will not be used after Asya’s cutting. Print one size on a single line.
//The order of the paper sizes doesn’t matter. See the examples below.
//Constraints
//•	N will be between 0 and 2046, inclusive.
//•	Allowed work time for your program: 0.1 seconds.Allowed memory: 16 MB.


namespace _19.Sheets
{
   class Sheets
   {
      static void Main()
      {
         int input = int.Parse(Console.ReadLine());

         for (int i = 0; i < 11; i++)
         {
            int bitToTake = i;
            int mask = 1 << bitToTake;
            int numberAndMask = input & mask;
            int bashSiBit = numberAndMask >> bitToTake; 


            if (bashSiBit == 0 )
            {
               Console.WriteLine("A" + (10 - i));
            }
         }
      }
   }
}
