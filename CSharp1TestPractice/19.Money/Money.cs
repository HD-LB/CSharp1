﻿using System;

//http://bgcoder.com/Contests/203/Telerik-Academy-Exam-1-2-February-2015-Evening
//http://telerikacademy.com/Courses/Courses/Details/323

//The first C# exam is coming! Help the trainers to calculate the amount of money they save for not printing on paper the exam descriptions. There are N students in the academy. The number of paper sheets that should be printed for each student is S. One realm (box with paper sheets) contains exactly 400 sheets of paper. The price of one realm is P.
//You can buy part of a realm.For example if the price of a realm is 2.200 you can buy 0.456 parts of one realm which means that you will pay 0.456 * 2.200 = 1.0032.
//N, S, P should be read from the console.Output the exact total amount of money the trainers save for not printing the exams on paper. The output should be rounded with 3 digits after the decimal point.
//See the examples below for clarification.
//Input
//The input data should be read from the console.
//The number N will be given on the first console line.
//The number S will be given on the second console line.
//The number P will be given on the third console line.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//Output the amount of money with precision 3 digits after the decimal point (Hint: use the formatting string { 0:F3} for outputting the answer)
//Constraints
//•	N will be a positive integer between 1 and 10 000.
//•	S will be a positive integer between 1 and 500.
//•	P will be a number between 0.001 and 100 with precision 3 digits after the decimal point.
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.



namespace _19.Money
{
   class Money
   {
      static void Main()
      {
         int N = int.Parse(Console.ReadLine());
         int S = int.Parse(Console.ReadLine());
         double P = double.Parse(Console.ReadLine());

         double result = ((N * S) / 400.0) * P;

         Console.WriteLine("{0:F3}", result);
      }
   }
}
