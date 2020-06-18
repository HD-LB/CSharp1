using System;

//http://telerikacademy.com/Courses/Courses/Details/385

//http://bgcoder.com/Contests/337/Telerik-Academy-Exam-Fundamentals-25-April-2016-Evening

//Your task is to find the average feathers count per bird and apply some more calculations on the result.If the birds count is an even number - multiply the result by the magic number 123123123123, if the birds count is an odd number - divide the result by the magic number 317.

//Input

//The input data should be read from the console.
// On the first console line you will receive a number B, that represents the number of birds in the forest. On the second console line you will receive a number F, that represents the total number of bird feathers in the forest. The input data will always be valid and in the format described.There is no need to check it explicitly.

//Output

//The output data should be printed on the console.
// On the only output line, print the average feathers count per bird, modified by the extra given conditions with 4 digits precision after the decimal point.

//Constraints
//•B will be a positive integer between 0 and 80000 inclusive.
//•F will be a positive integer between 0 and 2000000000 inclusive.

namespace CSharpTestPractice
{
   class BirdsAndFeathers
   {
      static void Main()
      {
         int B = int.Parse(Console.ReadLine());
         int F = int.Parse(Console.ReadLine());

         double result = 0;


         if (B == 0)
         {
            result = 0;
         }
         else
         {
            double avg = F / (double)B;
            if (B % 2 == 0)
            {
               result = avg * 123123123123;
            }
            else
            {
               result = avg / 317;
            }
         }

         Console.WriteLine("{0:F4}", result);
      }
   }
}
