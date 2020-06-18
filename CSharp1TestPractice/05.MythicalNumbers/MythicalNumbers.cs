using System;

//http://bgcoder.com/Contests/389/Telerik-Academy-Exam-CSharp-Fundamentals-10-November-2016-Evening

//Description

//The magical number

//You are given a number that is 3 digits long. Depending on the 3rd digit, you need to perform some calculations.
//•If the 3rd digit is zero, find the product of the first two digits .
//•If the 3rd digit is between 0 and 5 inclusive, find the product of the first two digits  and divide the result by the  3rd digit .
//•If the 3rd digit is larger than 5, find the sum of the first two digits  and multiply the result by the  3rd digit .

//Input
//•On the only input line, you will receive a number that contains 3 digits.

//Output
//•Your output should always be a single line. The content of the line should be the result of the calculations with a precision specifier of 2. (Fixed-point 2).


namespace _05.MythicalNumbers
{
   class MythicalNumbers
   {
      static void Main()
      {
         int num = int.Parse(Console.ReadLine());

         int firstDigit = (num / 100) % 10;
         int secondDigit = (num / 10) % 10;
         int thitrdDigit = (num / 1) % 10;

         //string num = Console.ReadLine();

         //int firstDigit = num[0] - '0';
         //int secondDigit = num[1] - '0';
         //int thitrdDigit = num[2] - '0';

         double result = 0;

         if (thitrdDigit == 0)
         {
            result = firstDigit * secondDigit;                
         }
         else if (0 < thitrdDigit && thitrdDigit <= 5)
         {
            result = (firstDigit * secondDigit) / (double)thitrdDigit;
         }
         else
         {
            result = (firstDigit + secondDigit) * thitrdDigit;
         }
         Console.WriteLine("{0:F2}", result);
      }      
   }
}
