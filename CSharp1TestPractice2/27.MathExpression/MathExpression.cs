﻿using System;

//http://bgcoder.com/Contests/3/CSharp-Fundamentals-2011-2012-Part-1-Test-Exam
//http://telerikacademy.com/Courses/LectureResources/Video/5481/Exam-preparation-Math-Expressions-Sevenland-Numbers-%d0%a1%d1%8a%d0%b1%d0%be

//You are given the following mathematical expression:

//The sin(x) is a trigonometric function that returns the sine from the angle x(measured in radians).
//The mod operator finds the remainder of division of one number by another.
//Here are some examples for how the mod operator should work:
//•	5 mod 2 = 1
//•	5.99 mod 3 = 2
//•	6 mod 3 = 0
//Your task is to write a computer program that calculates the result from the shown mathematical expression, depending on the values of the variables N, M and P.
//Input
//The input data is being read from the console.
//The input consists of exactly 3 lines.In each line you consequently enter the variables N, M and P.
//The separator between the integer and the fractional part of the number is “.” (dot).
//The number of digits that follow the decimal point will not be more than 6.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data must be printed on the console.
//There must be only one line, showing the result from the mathematical expression.
//The result must show exactly 6 digits after the “.” (decimal point).
//Constraints
//•	The numbers N, M and P are fractional numbers.
//•	N, M and P will be between -10 000 000 and 10 000 000, inclusive.
//•	The numbers M and P will always have values other than 0
//•	It is guaranteed that none of the combinations of the numbers N, M and P will lead to dividing by zero.
//•	Allowed working time for your program: 0.10 seconds.
//•	Allowed memory: 16 MB.


namespace _27.MathExpression
{
   class MathExpression
   {
      static void Main()
      {
         string inputN = Console.ReadLine();
         string inputM = Console.ReadLine();
         string inputP = Console.ReadLine();

         double n = double.Parse(inputN);
         double m = double.Parse(inputM);
         double p = double.Parse(inputP);

         const double numberNom = 1337;
         double nominator = n * n + (1 / (m * p)) + numberNom;

         const double numberDenom = 128.523123123;
         double denominator = n - numberDenom * p;

         double result = (nominator / denominator) + Math.Sin((int)m % 180);


         Console.WriteLine("{0:F6}", result);
      }
   }
}
