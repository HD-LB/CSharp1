using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://bgcoder.com/Contests/41/Telerik-Academy-Exam-1-27-Dec-2012
//http://telerikacademy.com/Courses/LectureResources/Video/5460/Exam-preparation-Carpets-Matrix-%d0%98%d0%b2%d0%be-%d0%9a%d0%b5%d0%bd%d0%be%d0%b2

//Telerik Academy is considering opening a new office in Great Britain.Therefore the whole Trainers team is traveling to the United Kingdom for the important event. Of course all of them want to feel exactly like home in the new office, so they ordered some special carpets from Chiprovtsi.Those carpets consist of many embedded rhombs. Please help them and print some carpets in different sizes for the new Telerik Academy Head Quarters.
//Input
//The input data should be read from the console.
//You have an integer number N (always even number) showing the width and the height of the most outer rhomb.The width and the height will always be equal.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Use the “/” and “\” characters to print the rhomb sides and “.” (dot) for the rest.You should print exactly one space between each rhomb.
//Constraints
//•	N will always be a positive even number between 6 and 80 inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB


/*
...../\.....
..../  \....
.../ /\ \...
../ /  \ \..
./ / /\ \ \.
/ / /  \ \ \
\ \ \  / / /
.\ \ \/ / /.
..\ \  / /..
...\ \/ /...
....\  /....
.....\/.....

*/


namespace _07.CarpetsMatrix
{
   class CarpetsMatrix
   {
      static void Main(string[] args)
      {
         //int N = int.Parse(Console.ReadLine());

         //int[,] matrix = new int[N, N];

         //int startSlash = N / 2 - 1;
         //int endSlash = N / 2 - 1;

         //bool isSlash = true;

         //for (int row = 0; row < N / 2; row++)
         //{
         //   for (int col = 0; col < N / 2; col++)
         //   {
         //      if (startSlash <= col && col <= endSlash)
         //      {
         //         if (isSlash)
         //         {
         //            matrix[row, col] = 2;
         //            matrix[row, N - 1 - col] = 3;
         //            matrix[N - 1 - row, col] = 3;
         //            matrix[N - 1 - row, N - 1 - col] = 2;
         //            isSlash = false;
         //         }
         //         else
         //         {
         //            matrix[row, col] = 1;
         //            matrix[row, N - 1 - col] = 1;
         //            matrix[N - 1 - row, col] = 1;
         //            matrix[N - 1 - row, N - 1 - col] = 1;
         //            isSlash = true;
         //         }
         //      }
         //   }
         //   isSlash = true;
         //   startSlash--;
         //}

         ////Printing
         //for (int row = 0; row < N; row++)
         //{
         //   for (int col = 0; col < N; col++)
         //   {
         //      if (matrix[row, col] == 0)
         //      {
         //         Console.Write('.');
         //      }

         //      else if (matrix[row, col] == 1)
         //      {
         //         Console.Write(' ');
         //      }
         //      else if (matrix[row, col] == 2)
         //      {
         //         Console.Write('/');
         //      }
         //      else if (matrix[row, col] == 3)
         //      {
         //         Console.Write('\\');
         //      }

         //   }
         //   Console.WriteLine();
         //}



         string input = Console.ReadLine();
         int lines = int.Parse(input);
         int elementsOnLines = lines;
         int center = elementsOnLines / 2;

         for (int i = 1; i <= lines / 2; i++)
         {
            int elementPosition = 1;
            while (elementPosition <= elementsOnLines)
            {
               if ((elementPosition <= center - i) || (elementPosition > center + i))
               {
                  Console.Write('.');
                  elementPosition++;

               }
               else
               {
                  for (int j = 0; j < i; j++)
                  {
                     if (j % 2 == 0)
                     {
                        Console.Write('/');
                        elementPosition++;
                     }
                     else
                     {
                        Console.Write(' ');
                        elementPosition++;
                     }

                  }
                  for (int j = i; j > 0; j--)
                  {
                     if (j % 2 != 0)
                     {
                        Console.Write('\\');
                        elementPosition++;
                     }
                     else
                     {
                        Console.Write(' ');
                        elementPosition++;
                     }
                  }
               }

            }
            Console.WriteLine();
         }



         for (int i = lines / 2; i > 0; i--)
         {
            int elementPosition = 1;
            while (elementPosition <= elementsOnLines)
            {
               if ((elementPosition <= center - i) || (elementPosition > center + i))
               {
                  Console.Write('.');
                  elementPosition++;

               }
               else
               {
                  for (int j = 0; j < i; j++)
                  {
                     if (j % 2 == 0)
                     {
                        Console.Write('\\');
                        elementPosition++;
                     }
                     else
                     {
                        Console.Write(' ');
                        elementPosition++;
                     }

                  }
                  for (int j = i; j > 0; j--)
                  {
                     if (j % 2 != 0)
                     {
                        Console.Write('/');
                        elementPosition++;
                     }
                     else
                     {
                        Console.Write(' ');
                        elementPosition++;
                     }
                  }
               }
            }
            Console.WriteLine();
         }
      }  
   }
}
