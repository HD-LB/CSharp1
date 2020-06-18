using System;

//http://bgcoder.com/Contests/91/Telerik-Academy-Exam-1-23-June-2013
//http://telerikacademy.com/Courses/Courses/Details/212

//Your task is to print on the console a torch of fire with width N following the examples below.
//Input
//The input data is being read from the console.
//On the only line will hold an integer number N, indicating the width of the fire in the torch.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data must be printed on the console.
//You should print the fire on the console. Use the symbol “#” (number sign) to mark the fire, “-“ (dash) to show the top of the torch and “/” (slash) or “\” (backslash) to illustrate the torch.
//Constraints
//•	N will be a positive integer in the range [4…76] and will always be divisible by 4.
//•	Allowed working time for your program: 0.25 second.
//•	Allowed memory: 16 MB.


namespace _42.FireInTheMatrix
{
   class FireInTheMatrix
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());

         //...##...
         //..#..#..
         //.#....#.
         //#......#

         for (int i = 0; i < n/2; i++)
         {
            for (int j = 0; j < n/2 - 1 - i; j++)
            {
               Console.Write('.');
            }
            Console.Write('#');

            for (int j = 0; j < 2 * i; j++)
            {
               Console.Write('.');
            }
            Console.Write('#');

            for (int j = 0; j < n/2 - 1 - i; j++)
            {
               Console.Write('.');
            }
            Console.WriteLine();
         }


         //#......#
         //.#....#.

         for (int i = 0; i < n/4; i++) //the instructions gave a hint
         {            
            for (int j = 0; j < i; j++) //outside left dots
            {
               Console.Write('.');
            }
            Console.Write('#');

            for (int j = 0; j < n - i - i - 2; j++) //inside dots
            {
               Console.Write('.');
            }
            Console.Write('#'); //fire
            

            for (int j = 0; j < i; j++) //outside right dots
            {
               Console.Write('.');
            }
            Console.WriteLine();
         }



         //--------
         for (int i = 0; i < n; i++) //Console.WriteLine(new string('-', n));
         {
            Console.Write('-');
         }
         Console.WriteLine();


         
         //\\\\////
         //.\\\///.
         //..\\//..
         //...\/...

         for (int row = 0; row < n / 2; row++) 
         {
            for (int i = 0; i < row; i++)  //Console.Write(new string('.', row));
            {
               Console.Write('.');
            }

            for (int i = 0; i < n / 2 - row; i++)
            {
               Console.Write('\\');
            }
            for (int i = 0; i < n / 2 - row; i++)
            {
               Console.Write('/');
            }

            for (int i = 0; i < row; i++)  //Console.Write(new string('.', row));
            {
               Console.Write('.');
            }

            Console.WriteLine();
         }
      }
   }
}
