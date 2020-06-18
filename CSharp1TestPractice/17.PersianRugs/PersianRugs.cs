using System;

//http://bgcoder.com/Contests/204/Telerik-Academy-Exam-1-3-February-2015-Morning
//http://telerikacademy.com/Courses/Courses/Details/323

//Your task is to help Ivcho with his production by writing a program that prints rug designs on the console.He needs the rugs to come out in different sizes depending on his client’s preferences and have variations in the design pattern as well.Draw the two diagonals with “\” and “/” and big X mark in the center of the rug, where the two diagonals cross.Fill in the two side triangles with “#” and draw a smaller triangle in the top and bottom triangles.
//The client will enter two numbers each on separate lines.
//•	The first number N between 2 and 100 (inclusive) determines the rug’s width = height = 2 * N + 1.
//•	The second number D between 0 and 100 (inclusive) is for the distance between the smaller triangle and the larger as shown on the examples.
//Note: D can be larger than N.
//Input
//The input data should be read from the console.
//On the first row you have an integer number N between 2 and 100 (inclusive) – determines the height and width of the rug: height = width = 2 * N + 1. 
//On the second row you have an integer number D between 0 and 100 (inclusive) – the distance(in spaces) between the small triangle and the large one as shown in the examples.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//You should print the Persian rug on the console.Each row can contain only the following characters: “ ” (space),”.” (dot), “X” (letter X), “/” (slash), “\” (backslash) and “#” (hashtag). As shown in the example.


namespace _17.PersianRugs
{
   class PersianRugs
   {
      static void Main()
      {

         int N = int.Parse(Console.ReadLine());
         int D = int.Parse(Console.ReadLine());

         int width = (2 * N) + 1;

         for (int row = 0; row < N; row++) //the rows are N as per instrictions
         {
            Console.Write(new string('#', row)); //the row = #
            Console.Write('\\');

            
            int spaceLeft = width - row - row - 1 - 1 - D - D; // the inside triangle
            if (spaceLeft >= 2)
            {
               Console.Write(new string(' ', D));
               Console.Write('\\');
               Console.Write(new string('.', spaceLeft - 2));
               Console.Write('/');
               Console.Write(new string(' ', D));
            }
            else
            {
               Console.Write(new string(' ', width - row -row - 2));
            }            
            

            Console.Write('/');
            Console.Write(new string('#', row)); //the row = #



            Console.WriteLine();
         }


         Console.WriteLine(new string('#', N) + "X" + new string('#', N)); //the middle row


         for (int row = N -1; row >= 0; row--)
         {
            Console.Write(new string('#', row)); //the row = #
            Console.Write('/');


            int spaceLeft = width - row - row - 1 - 1 - D - D; // the inside triangle
            if (spaceLeft >= 2)
            {
               Console.Write(new string(' ', D));
               Console.Write('/');
               Console.Write(new string('.', spaceLeft - 2));
               Console.Write('\\');
               Console.Write(new string(' ', D));
            }
            else
            {
               Console.Write(new string(' ', width - row - row - 2));
            }


            Console.Write('\\');
            Console.Write(new string('#', row)); //the row = #



            Console.WriteLine();
         }
      }
   }
}
