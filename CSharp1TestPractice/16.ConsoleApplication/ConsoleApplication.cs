using System;
using System.Numerics;
//http://bgcoder.com/Contests/204/Telerik-Academy-Exam-1-3-February-2015-Morning
//http://telerikacademy.com/Courses/Courses/Details/323

//Your task is to create a program named “ConsoleApplication1” which solves the following task.You will receive N numbers from the input. You will have to select those who are in odd positions (starting from zero) and calculate the product of their digits.If one of the digits is zero, ignore it in the calculations.If the number itself is zero, consider the product of its digits to be 1. Afterwards find the product of all previously found products as the final result.
//Let’s make it more interesting.If the input numbers are more than 10, calculate the result from the formula above for the first 10 numbers and then calculate it again for all other numbers after the 10th.If the numbers are less or equal to 10, calculate the result for all numbers of the input.
//Example:
//1.	Input numbers are – 123, 456, 789, 1238, 856
//2.	Input numbers are less than 10 – we calculate the result for all of numbers
//3.	We select all numbers in odd positions – 456 and 1238
//4.	We find the product of all digits of 456 – 4 * 5 * 6 = 120
//5.	We find the product of all digits of 1238 – 1 * 2 * 3 * 8 = 48
//6.	We find the product of all found products – 120 * 48 = 5760
//Input
//The input data should be read from the console.
//On the first N input lines you will receive one number per line.
//On the N + 1st line you will receive “END” as string (without the quotes). You should read and parse numbers until you reach “END”.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//If there were less or equal to 10 initial input numbers – print the final product on the only output line.
//If there were more than 10 initial input numbers – print the final product of from the first 10 numbers of the input on the first output line and the final product from all other numbers of the input on the second output line.


namespace _16.ConsoleApplication
{
   class ConsoleApplication
   {
      static void Main()
      {
         int index = 0; //first number is on the 0 position, so we can ake even or odd positions
         BigInteger globalProduct = 1; //for the product multiplication   !! it has to be BigInteger!!!

         while (true)
         {
            string line = Console.ReadLine();
            if (line == "END")
            {
               break;
            }

            if (index == 10)
            {
               Console.WriteLine(globalProduct);
               globalProduct = 1; // the product starts from the begining
            }

            long num = long.Parse(line);
            if (index % 2 == 1) // the number is on an odd position
            {
               long product = 1;
               while (num > 0)
               {
                  long digit = num % 10; //to get the last digit
                  if (digit != 0)
                  {
                     product *= digit; //product = product * digit;
                  }
                  num /= 10;
               }
               globalProduct = globalProduct * product;

            }
            index = index + 1; //increasing the position of the numbers

         }
         
         Console.WriteLine(globalProduct);
      }
   }
}
