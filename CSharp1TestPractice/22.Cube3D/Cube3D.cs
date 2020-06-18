using System;

//http://bgcoder.com/Contests/203/Telerik-Academy-Exam-1-2-February-2015-Evening
//http://telerikacademy.com/Courses/Courses/Details/323


//Your task is to wright a program that supplies him with cubes (basic building blocks). He will give you a number N and you should print a cube with width = height = depth = N as shown in the examples. Mark the sides with “:” (colon). In addition you will have to fill in some of the sides of the cube:
//•	The side should be filled in with “|” (vertical line)
//•	The bottom should be filled in with “-” (minus)

//Input
//The input data should be read from the console.
//On the first row you have an integer number N between 4 and 100 (inclusive) – the size of the cube.
//The input data will always be valid and in the format described.There is no need to check it explicitly.

//Output
//The output should be printed on the console.
//You should print the cube on the console. Each row can contain only the following characters: “ ” (space),”|” (vertical line), “-” (minus) and “:” (colon). As shown in the example.

//Constraints
//•	The number N will be a positive integer number between 4 and 100, inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _22.Cube3D
{
   class Cube3D
   {
      static void Main()

      {

         int N = int.Parse(Console.ReadLine());

         char[,] cube = new char[2 * N - 1, 2 * N - 1]; //row, column


         //int N = int.Parse(Console.ReadLine());

         //cube outline
         for (int i = 0; i < N; i++)
         {

            ////upper horizontal side
            //Console.SetCursorPosition(i, 0); // first the column (X), than row (Y) !!!
            //Console.Write(':');
            cube[0, i] = ':'; // first the row (Y), than the column (X) !!!

            ////bottom horizontal side
            //Console.SetCursorPosition(i, N - 1);
            //Console.Write(':');
            cube[N - 1, i] = ':';

            ////left vertical side
            //Console.SetCursorPosition(0, i);
            //Console.Write(':');
            cube[i, 0] = ':';


            ////right vertical side
            //Console.SetCursorPosition(N - 1, i);
            //Console.Write(':');
            cube[i, N - 1] = ':';

            ////hind bottom horizontal side
            //Console.SetCursorPosition(i + (N - 1), 2 * (N - 1));
            //Console.Write(':');
            cube[2 * (N - 1), i + (N - 1)] = ':';

            ////hind right vertical side
            //Console.SetCursorPosition(2 * (N - 1), i + (N - 1));
            //Console.Write(':');
            cube[i + N - 1, 2 * (N - 1)] = ':';

            ////top right diagonal line
            //Console.SetCursorPosition(N - 1 + i, i);
            //Console.Write(':');
            cube[i, N - 1 + i] = ':';

            ////bottom right diagonal line
            //Console.SetCursorPosition(N - 1 + i, N - 1 + i);
            //Console.Write(':');
            cube[N - 1 + i, N - 1 + i] = ':';

            ////bottom left diagonal line
            //Console.SetCursorPosition(i, N - 1 + i);
            //Console.Write(':');
            cube[N - 1 + i, i] = ':';

         }


         //fill the cube sides
         for (int i = 2; i < N; i++)
         {


            ////this is the conection N + j and i + j
            //Console.SetCursorPosition(N, i);
            //Console.Write('|');

            //Console.SetCursorPosition(N + 1, i + 1);
            //Console.Write('|');

            //Console.SetCursorPosition(N + 2, i + 2);
            //Console.Write('|');



            for (int j = 0; j < N - 2; j++) // N - 2, because there are 5 - 2 = 3 '|'
            {
               //Console.SetCursorPosition(N + j, i + j);
               //Console.Write('|');
               cube[i + j, N + j] = '|';

               //Console.SetCursorPosition(i + j, N + j);
               //Console.Write('-');
               cube[N + j, i + j] = '-';
            }           

         }

         for (int row = 0; row < 2 * N - 1; row++)
         {
            for (int col = 0; col < 2 * N - 1; col++)
            {
               char symbol = cube[row, col];

               if (symbol != 0)
               {
                  Console.Write(symbol);

               }
               else
               {
                  Console.Write(' ');
               }
            }
            Console.WriteLine();
         }
      }
   }
}
