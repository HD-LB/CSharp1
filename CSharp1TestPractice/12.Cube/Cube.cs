using System;

//Ivcho is a big computer genius.One day he was bored from all the girls that wanted to be with him and instead decided to wright a computer game. Because he always likes to do things the hard way he decided to make a console game, but not any console game – a 3D one! Just for the fun of it. But because he isn’t very good with graphics he needs your help with the basic building blocks witch he can feed to his magic algorithm that produces HD 3D-reality in the console.
//Your task is to wright a program that supplies him with cubes (basic building blocks). He will give you a number N and you should print a cube with width = height = depth = N as shown in the examples.Mark the sides with “:” (colon).
//In addition you will have to fill in some of the sides of the cube:
//•	The top should be filled in with “/” (slash)
//•	The side should be filled in with “X” (capital letter X)
//Input
//The input data should be read from the console.
//On the first row you have an integer number N between 4 and 100 (inclusive) – the size of the cube.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//You should print the cube on the console. Each row can contain only the following characters: “ ” (space),”X” (letter X), “/” (slash) and “:” (colon). As shown in the example.
//Constraints
//•	The number N will be a positive integer number between 4 and 100, inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _12.Cube
{
   class Cube
   {
      static void Main()
      {
         //read input

         int n = int.Parse(Console.ReadLine());
         int fieldSize = n * 2 - 1;
         int mid = n - 1;


         char empty = ' ';
         char top = '/';
         char side = 'X';
         char edge = ':';


         //logic

         for (int row = 0; row < fieldSize; row++)
         {
            for (int col = 0; col < fieldSize; col++)
            {
               if (col == 0 && row >= mid || //verical lines
                  col == mid && row >= mid ||
                  col == fieldSize - 1 && row <= mid ||
                  col >= mid && row == 0 || //horizontal lines
                  col <= mid && row == mid ||
                  col <= mid && row == fieldSize - 1 ||
                  col + row == mid || //diagonals
                  col + row == fieldSize - 1 + mid ||
                  col + row == fieldSize - 1 && row <= mid)
               {
                  Console.Write(edge); // edges
               }

               else if (col > mid &&
                        col + row <= fieldSize - 1 + mid &&
                        col + row >= fieldSize - 1)
               {
                  Console.Write(side);
               }

               else if (row < mid &&
                        col + row >= mid)
               {
                  Console.Write(top);
               }

               else
               {
                  Console.Write(empty);
               }

            }
            Console.WriteLine();
         }
      }
   }
}
