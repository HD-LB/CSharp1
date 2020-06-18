using System;

//http://bgcoder.com/Contests/41/Telerik-Academy-Exam-1-27-Dec-2012
//http://telerikacademy.com/Courses/LectureResources/Video/5470/Exam-preparation-Formula-Bit-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be

//The residents of Bitlandia are huge sports fans.The bits have played almost every single sport that they have learned from watching human TV i.e.EuroBitSport and BitTV.Today for the first time they watched Formula 1 and now they certainly want to build a local track and start practicing right away.Of course the bits don’t want to copy the humans. They want to be unique and therefore they’ve added some special rules:
//1.	The track must be built on a grid of 8x8 cells, containing only zeros and ones.
//2.	The track itself must contain only zeros.The width of the track will be one cell.
//3.	The track must start from the upper right corner and end on the lower left corner.
//4.	The cars can move only in 3 directions – South (down), West(left) And North(up). 
//5.	The first direction must always be south.
//6.	The cars must move in the current direction, while it is possible i.e.the cars can turn only when it reaches the end of the grid or a cell, containing a bit with a value of one.
//7.	The cars can switch between directions only in the following order:
//South -> West -> North -> West (and then again South -> West and so on)
//You will receive information about the grid as a list of 8 bytes(positive integers in the range [0…255]) n0, n1, …, n7.The grid itself is represented by the bits of those bytes.
//Your task is to find whether a track can be built on the given grid.If the grid is appropriate, you should print the length of the track and the count of the turns in it (the switches between directions), otherwise you should print “No” and the length of the track until it was interrupted.
//Input
//The input data should be read from the console.
//There will be exactly 8 lines each holding an integer number (n0, n1… n7).
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the only output row you should print two numbers in the following format “X Y”, where X is the length of the track and Y is the count of the turns.If a track cannot be built, you should print “No X”, where X is the length of the track, until it was interrupted.
//Constraints
//•	The numbers n0, n1, …, n7 are positive integers in the range [0…255]
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _14.FormulaBit
{
   class FormulaBit
   {
      static void Main()
      {
         bool[,] track = new bool[8, 8];
         for (int i = 0; i < 8; i++)
         {
            int currentNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
               track[i, j] = ((currentNumber >> j) & 1) != 0;
            }
         }

         int row = 0;
         int col = 0;

         string direction = "down";
         string lastDirection = "down";

         int pathCount = 0;
         int directionCount = 0;

         bool exitFound = false;

         while (true)
         {
            if (track[row, col]) //if different than 1
            {
               break;
            }
            pathCount++;

            if (row == 7 && col == 7) //getting to the end, lower left
            {
               exitFound = true;
               break;
            }


            if (direction == "down" && (row + 1 > 7 || track[row + 1, col]))
            {
               direction = "left";
               lastDirection = "down";
               directionCount++;

               if (col + 1 > 7 || track[row, col + 1])
               {
                  break;
               }
            }


            else if (direction == "up" && (row - 1 < 0 || track[row - 1, col]))
            {
               direction = "left";
               lastDirection = "up";
               directionCount++;

               if (col + 1 > 7 || track[row, col + 1])
               {
                  break;
               }
            }


            else if (direction == "left" && lastDirection == "down" && (col + 1 > 7 || track[row, col + 1]))
            {
               direction = "up";
               directionCount++;

               if (row - 1 < 0 || track[row - 1, col])
               {
                  break;
               }
            }


            else if (direction == "left" && lastDirection == "up" && (col + 1 > 7 || track[row, col + 1]))
            {
               direction = "down";
               directionCount++;

               if (row + 1 > 7 || track[row + 1, col])
               {
                  break;
               }
            }

            

            if (direction == "down")
            {
               row++;
            }
            else if (direction == "left")
            {
               col++;
            }
            else if (direction == "up")
            {
               row--;
            }
         }

         if (exitFound)
         {
            Console.WriteLine("{0} {1}", pathCount, directionCount);
         }
         else
         {
            Console.WriteLine("No " + pathCount);
         }
      }
   }
}
