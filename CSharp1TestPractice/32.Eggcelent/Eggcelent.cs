using System;

//http://bgcoder.com/Contests/105/Telerik-Academy-Exam-1-5-December-2013-Evening
//http://telerikacademy.com/Courses/Courses/Details/212

//Dumpty Humpty was climbing a tower.
//Dumpty Humpty did not have enough power…
//Eh, I can’t rhyme so I will give you the abridged version – Dumpty Humpty was a huge egg with hands and legs and a very annoying attitude towards life.One day when he was very bored he decided to climb Bat’Goiko’s tower along with his family. But it was very tall and it was very windy on the top – so the wind pushed Dumpty Humpty and every egg in his family, they all fell to the ground and all of them cracked right down the middle.Your task is to ignore the possibility of a delicious omelet and to help the egg family by sewing them together. 
//You will be given a number N which is the size of the egg that you are currently trying to fix.
//Each egg’s height is 2 times the input (2 * N), the width is 3 * N – 1 and the width of the drawing area is 3 * N + 1. The sizes of the top and the bottom of the egg are N – 1.
//The cracks are in the middle of the egg.They must be fixed on 2 lines and with the ‘@’ and ‘.’ characters alternating.The first line must start with a ‘@’ and the second ‘.’.
//Input
//The input data should be read from the console.
//You have an integer number N - the size of the egg.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Use the “*” character for the outer shell, the “@” character for the cracks and “.” (dot) for the rest.
//Constraints
//•	N will always be a positive even number between 2 and 26 inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

namespace _32.Eggcelent
{
   class Eggcelent
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());

         int height = 2 * n;
         int width = 3 * n + 1; // the top row 3n + 1 - (n - 1) = 2n + 2 , devide by 2 => n + 1 for the '*'

         for (int r = 0; r < height; r++)
         {
            for (int c = 0; c < width; c++)
            {
               if ((c > n && c < 2 * n) && (r == 0 || r == height - 1)) // first and last row
               {                 
                  Console.Write('*');
               }
               else if ((c == 1 || c == width - 2) && (r >= n/2 && r < 2 * n - n / 2))
               {
                  Console.Write('*');
               }
               else if (2 * r - c == - (2 * n - 1) || 2 * r - c == 3 * n - 3)
               {
                  Console.Write('*');
               }
               else if (2 * r + c == n + 1 || 2 * r + c == 6 * n - 3)
               {
                  Console.Write('*');
               }
               else if ((r == n - 1 || r == n) && (c > 1 && c < width - 2) && (r + c) % 2 == 1)
               {
                  Console.Write('@');
               }
               else
               {
                  Console.Write('.');
               }
               
            }
            Console.WriteLine();
         }
      }
   }
}
