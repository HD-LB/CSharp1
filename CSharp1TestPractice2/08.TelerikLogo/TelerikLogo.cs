using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://bgcoder.com/Contests/42/Telerik-Academy-Exam-1-28-Dec-2012
//http://telerikacademy.com/Courses/LectureResources/Video/5461/Exam-preparation-Telerik-Logo-Matrix-%d0%98%d0%b2%d0%be-%d0%9a%d0%b5%d0%bd%d0%be%d0%b2

//Telerik Academy is considering opening a new office in Great Britain.Therefore the whole Trainers team is traveling to the United Kingdom for the important event. They’ve decided that they need to print some advertising posters and give them away to the local citizens. Please help them and print some posters with the Telerik Logo in different sizes. As a little reminder, here it is the logo itself (n.b.the letters are for reference only and denote the lengths of the sides):
//Input
//The input data should be read from the console.You will receive an integer number X. Note that X will always be equal to Y and Z will always be (X / 2) + 1. (Refer to the examples).
//Output
//The output should be printed on the console.
//Use the “*” (asterisk) character to print the logo and “.” (dot) for the rest.
//Constraints
//•	X will always be a positive odd number between 3 and 27 inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

//output

//3

//	.*...*.
//*.*.*.*
//...*...
//..*.*..
//.*...*.
//..*.*..
//...*...


//5

//..*.......*..
//.*.*.....*.*.
//*...*...*...*
//.....*.*.....
//......*......
//.....*.*.....
//....*...*....
//...*.....*...
//..*.......*..
//...*.....*...
//....*...*....
//.....*.*.....
//......*......



namespace _08.TelerikLogo
{
   class TelerikLogo
   {
      static void Main(string[] args)
      {
         ////Initialization

         //int x = int.Parse(Console.ReadLine());
         //int y = x;
         //int z = x / 2 + 1;

         //int width = (2 * x + 2 * z) - 3; //the width of the whole figure
         //int hight = width;

         //int[,] matrix = new int[width, width];

         ////Solution

         //int currentRow = x / 2;
         //int currentCol = 0; //starting to count from 0

         //while (true)
         //{
         //   matrix[currentRow, currentCol] = 1; //printig a '*'

         //   currentRow--;
         //   currentCol++;

         //   if (currentRow < 0)
         //   {
         //      currentRow++;
         //      currentCol--;
         //      break;
         //   }

         //}

         //while (true)
         //{
         //   matrix[currentRow, currentCol] = 1;
         //   currentRow++;
         //   currentCol++;

         //   if (currentRow == 2 * x - 1)
         //   {
         //      currentRow--;
         //      currentCol--;
         //      break;
         //   }

         //}

         //while (true)
         //{
         //   matrix[currentRow, currentCol] = 1;

         //   currentRow++;
         //   currentCol--;

         //   if (currentRow == width)
         //   {
         //      currentRow--;
         //      currentCol++;
         //      break;
         //   }
         //}
         //while (true)
         //{
         //   matrix[currentRow, currentCol] = 1;

         //   currentRow--;
         //   currentCol--;

         //   if (currentCol == x / 2 - 1)
         //   {
         //      currentRow++;
         //      currentCol++;
         //      break;
         //   }
         //}

         //while (true)
         //{
         //   matrix[currentRow, currentCol] = 1;

         //   currentRow--;
         //   currentCol++;

         //   if (currentRow < 0)
         //   {
         //      currentRow++;
         //      currentCol--;
         //      break;
         //   }
         //}

         //while (true)
         //{
         //   matrix[currentRow, currentCol] = 1;

         //   currentRow++;
         //   currentCol++;

         //   if (currentCol == width)
         //   {
         //      break;
         //   }
         //}


         ////Printing

         //for (int row = 0; row < width; row++)
         //{
         //   for (int col = 0; col < width; col++)
         //   {
         //      if (matrix[row, col] == 0)
         //      {
         //         Console.Write('.');
         //      }
         //      else if (matrix[row, col] == 1)
         //      {
         //         Console.Write('*');
         //      }
         //   }
         //   Console.WriteLine();
         //}







         int x = int.Parse(Console.ReadLine());

         int width = (x + x) + ((x / 2) + 1) + ((x / 2) + 1) - 3;
         int hornsLenght = x / 2;
         int middleDots = width - 2 * ((x / 2) + 1);

         Console.Write(new string('.', hornsLenght));
         Console.Write("*");
         Console.Write(new string('.', middleDots));
         Console.Write("*");
         Console.WriteLine(new string('.', hornsLenght));

         middleDots -= 2;

         int firstHornDots = x / 2 - 1;
         int dotsAfterHorn = 0;

         for (int i = 1; i < x - 1; i++)
         {
            //add real horns

            if (i <= x / 2)
            {
               Console.Write(new string('.', firstHornDots));
               Console.Write('*');
               Console.Write(new string('.', dotsAfterHorn));

            }
            else
            {
               Console.Write(new string('.', hornsLenght));
            }

            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', i));

            middleDots -= 2;

            if (i <= x / 2)
            {
               Console.Write(new string('.', dotsAfterHorn));
               Console.Write('*');
               Console.Write(new string('.', firstHornDots));

               firstHornDots--;
               dotsAfterHorn++;
            }
            else
            {
               Console.Write(new string('.', hornsLenght));
            }

            Console.WriteLine();
         }


         Console.Write(new string('.', width / 2));
         Console.Write("*");
         Console.Write(new string('.', width / 2));
         Console.WriteLine();


         int leftRightDots = x - 2;
         middleDots = 1;

         for (int i = 0; i < x - 1; i++)
         {
            Console.Write(new string('.', hornsLenght));
            Console.Write(new string('.', leftRightDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', leftRightDots));
            Console.Write(new string('.', hornsLenght));

            middleDots += 2;
            leftRightDots--;
            Console.WriteLine();
         }

         middleDots -= 4;

         for (int i = 1; i < x - 1; i++)
         {
            Console.Write(new string('.', hornsLenght));
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.Write(new string('.', i));

            Console.Write(new string('.', hornsLenght));

            middleDots -= 2;
            Console.WriteLine();
         }


         Console.Write(new string('.', width / 2));
         Console.Write("*");
         Console.Write(new string('.', width / 2));
         Console.WriteLine();
      }
   }
}
