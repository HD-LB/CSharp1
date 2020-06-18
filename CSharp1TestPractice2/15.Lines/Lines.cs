using System;

//http://bgcoder.com/Contests/5/Telerik-Academy-Exam-1-7-Dec-2011-Morning
//http://telerikacademy.com/Courses/LectureResources/Video/5471/Exam-preparation-Lines-%d0%9f%d0%b5%d0%bd%d0%ba%d0%b0

//You are given a list of 8 bytes(positive integers in the range [0…255]) n0, n1, …, n7.These numbers represent a square grid consisting of 8 lines and 8 columns.Each cell of the grid could either be empty or full.The first line is represented by the bits of n0, the second – by the bits of n1 and so on, and the last line is represented by the bits of n7.Each bit with value 1 denotes a full cell and each bit with value 0 denotes an empty cell. The lines are numbered from the first (top) to the last(bottom) with the numbers 0, 1, …, 7. The columns are numbered from right to left with the indices 0, 1, …, 7. The figure shows a sample square grid and its representation by a sequence of 8 numbers n0, n1, …, n7:
//	7	6	5	4	3	2	1	0	
//0					■				n0 = 8
//1		■			■				n1 = 72
//2					■				n2 = 8
//3					■				n3 = 8
//4				■					n4 = 16
//5				■	■	■			n5 = 28
//6	■	■	■	■					n6 = 240
//7									n7 = 0
//A line is any sequence of full cells staying on the same row or column.At the figure above we have two lines of 4 cells and two lines of 3 cells and one line of 1 cell.You need to create a program that finds the longest line in the grid and the number of lines with the longest length.At the figure we have two largest lines with length of 4 cells.
//Input
//The input data is should be read from the console. There will be exactly 8 lines each holding the integer numbers n0, n1, …, n7.It is guaranteed that there exists at least one line in the grid (the grid is not empty).
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output consists of two integers placed on separate lines. The first line should hold the length of the longest line in the grid. The second line should hold the number of lines with the maximal length.
//Constraints
//•	The numbers n0, n1, …, n7 are positive integers in the range [0…255].
//•	Allowed work time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.




namespace _15.Lines
{
   class Lines
   {
      static void Main()
      {
         int n = 8;
         int[,] matrix = new int[n, n];
         for (int i = 0; i < n; i++)
         {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
               int bit = (number >> j) & 1;
               matrix[i, j] = bit;
            }
         }


         int longestLine = 0;
         int longestCount = 0;

         for (int i = 0; i < n; i++)
         {
            int currentLine = 0;

            //horizontal Lines
            for (int j = 0; j < n; j++)
            {
               while (j < n && matrix[i, j] == 1)
               {
                  currentLine++;
                  j++;
               }
               if (currentLine > longestLine)
               {
                  longestLine = currentLine;
                  longestCount = 1;
               }
               else if(longestCount == currentLine)   
               {
                  longestCount++;
               }
               currentLine = 0; //starting the count again from 0

            }
         }

         //verical Lines
         for (int j = 0; j < n; j++) //first the columns
         {
            int currentLine = 0;
            for (int i = 0; i < n; i++)
            {
               while (i < n && matrix[i, j] == 1)
               {
                  currentLine++;
                  i++;
               }
               if (currentLine > longestLine)
               {
                  longestLine = currentLine;
                  longestCount = 1;
               }
               else if (longestCount == currentLine)
               {
                  longestCount++;
               }
               currentLine = 0;

            }
         }
         if (longestLine == 1)
         {
            longestCount = longestCount / 2;
         }


         Console.WriteLine(longestLine);
         Console.WriteLine(longestCount);
      }
   }
}
