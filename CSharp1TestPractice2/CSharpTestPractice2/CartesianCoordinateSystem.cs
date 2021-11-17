using System;

//http://bgcoder.com/Contests/1/CSharp-Fundamentals-2011-2012-Part-1-Sample-Exam
//http://telerikacademy.com/Courses/Courses/Details/212
//http://telerikacademy.com/Courses/LectureResources/Video/5480/Exam-preparation-Coordinate-System-Tasks-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8
//http://telerikacademy.com/Courses/LectureResources/Video/5454/%d0%9f%d1%80%d0%b8%d0%bc%d0%b5%d1%80%d0%b5%d0%bd-%d0%b8%d0%b7%d0%bf%d0%b8%d1%82-26-%d0%bd%d0%be%d0%b5%d0%bc%d0%b2%d1%80%d0%b8-2012-%d0%9d%d0%b8%d0%ba%d0%b8

//You are given a two-dimensional Cartesian coordinate system and the two coordinates(X and Y) of a point in the coordinate system.If you don't know what 
Cartesian coordinate system is Google it with Bing. As you will find, the coordinate system is divided by 2 lines (see the picture bellow) which divide the 
plain in four parts. Each of these parts has a lot of points that are numbered between 1 and 4. There is one point where our lines are crossing. This point 
has the following coordinates: X=0 and Y=0. As a result this point is numbered 0. The points on the lines are also numbered with the numbers 5 and 6 (again 
see the picture below).
//Your task is to write a program that finds the number of the location of the given point in the coordinate system.

//Input
//Input data is being read from the console.
//The number X is on the first input line.
//The number Y is on the second input line.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data must be printed on the console.
//On the only output line you must print an integer number between 0 and 6, depending on the location of the given point in the coordinate system.
//Constraints
//•	The numbers X and Y are numbers between -2 000 000 000 001 337 and 2 000 000 000 001 337, inclusive.
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.



namespace CSharpTestPractice2
{
   class CartesianCoordinateSystem
   {
      static void Main()
      {
         decimal x = decimal.Parse(Console.ReadLine());
         decimal y = decimal.Parse(Console.ReadLine());

         if (x > 0 && y > 0)
         {
            Console.WriteLine(1);
         }
         else if (x < 0 && y > 0)
         {
            Console.WriteLine(2);
         }
         else if (x < 0 && y < 0)
         {
            Console.WriteLine(3);
         }
         else if (x > 0 && y < 0)
         {
            Console.WriteLine(4);
         }
         else if (x == 0 && y != 0)
         {
            Console.WriteLine(5);
         }
         else if (y == 0 && x != 0)
         {
            Console.WriteLine(6);
         }
         else if (x == 0 && y == 0)
         {
            Console.WriteLine(0);
         }
      }
   }
}
