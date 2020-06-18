using System;

//http://telerikacademy.com/Courses/LectureResources/Video/5481/Exam-preparation-Math-Expressions-Sevenland-Numbers-%d0%a1%d1%8a%d0%b1%d0%be
//http://bgcoder.com/Contests/42/Telerik-Academy-Exam-1-28-Dec-2012
//http://telerikacademy.com/Courses/Courses/Details/212

//In Sevenland we use a numeral system of base 7. It consists of seven digits(instead of the traditional 10) and these 7 digits are: 0, 1, 2, 3, 4, 5, and 6. The numbers in the system of base 7 are just like the decimal numbers, but after 6 the next number is 10. More general, the numbers in the 7-base numeral system are: 0, 1, 2, 3, 4, 5, 6, 10, 11, …, 16, 20, 21, …, 26, 30, …, 65, 66, 100, 101, …, 106, 110, …, 166, 200, …, 666, 1000.
//Write a program that takes as input a 7-based integer number K and calculates and prints the next number following it(K+1).
//Input
//The input data should be read from the console and consists of a single line holding a 7-based integer K.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//The output should consist of a single line holding the number K+1 (in 7-based numeral system).
//Constraints
//•	The number K is in the range[0…666] inclusive.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _28.SevenlandNumbers
{
   class SevenlandNumbers
   {
      static void Main()
      {

         string input = Console.ReadLine();
         int n = int.Parse(input);

         byte powerCounter = 0;
         int decimalNumber = 0;

         while (n != 0)
         {
            byte lastNumber =(byte)(n % 10);
            decimalNumber += lastNumber * (int)(Math.Pow(7, powerCounter));
            powerCounter++;
            n /= 10;
         }

         decimalNumber++;
         string result = "";

         while (decimalNumber != 0)
         {
            byte lastNumber = (byte)(decimalNumber % 7);
            result = lastNumber + result;
            decimalNumber /= 7;
         }
         Console.WriteLine(result);
      }
   }
}
