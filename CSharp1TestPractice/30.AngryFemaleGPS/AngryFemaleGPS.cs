using System;

//http://bgcoder.com/Contests/105/Telerik-Academy-Exam-1-5-December-2013-Evening
//http://telerikacademy.com/Courses/Courses/Details/212

//One day while Toshko was driving and cursing, and driving and cursing, and driving and cursing, and driving and cursing, and driving and cursing, G Pisi’ s had enough of all the driving and cursing.So she decided(being bad and evil technology) to give Toshko wrong and random path directions.This is the algorithm: G Pisi calculates a random integer number then finds the sum of the even digits and the sum of the odd digits in it.Afterwards she compares these sums and according to the result she gives Toshko a direction.
//•	If the sum of the even digits is bigger than the sum of the odd ones she gives him right direction.
//•	If the sum of the odd digits is bigger than the sum of the even ones she gives him left direction.
//•	If the two sums are equal she gives him straight direction.
//For example G PiSi generates the integer 4729 so the sum of the even digits is 4 + 2 = 6 and the sum of the odd digits is 7 + 9 = 16. As a result the sum of the odd digits is bigger and the direction is left.
//Write a program that determines what kind of direction G Pisi would give Toshko by given integer number N and display the sum of the digits that leads to G Pisi’s choice.
//Input
//The input data should be read from the console. 
//The only input line contains the integer number N which G Pisi generate at random.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console. 
//The output consists of one line. On the only output line you must print the kind of direction (“right”, “left” or “straight”) and the sum of the digits that leads to the choice separated by a single white space(e.g. “left 12”).
//Constraints
//•	N will be valid long number.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _30.AngryFemaleGPS
{
   class AngryFemaleGPS
   {
      static void Main()
      {
         long n = long.Parse(Console.ReadLine());

         if (n < 0)
         {
            n *= -1; //making n a positiv number
         }

         int sumEven = 0;
         int sumOdd = 0;

         while (n != 0)
         {
            int digit = (int)n % 10; //to get tha last digit
            n /= 10;
            if (digit % 2 == 0)
            {
               sumEven += digit;
            }
            else
            {
               sumOdd += digit;
            }
         }
         if (sumEven == sumOdd)
         {
            Console.WriteLine("straight {0}", sumEven);
         }
         else if (sumOdd > sumEven)
         {
            Console.WriteLine("left {0}", sumOdd);
         }
         else
         {
            Console.WriteLine("right {0}", sumEven);
         }


         //string num = Console.ReadLine();

         //int sumOdd = 0;
         //int sumEven = 0;
         //for (int i = 0; i < num.Length; i++)
         //{
         //   if (num[i] == '-') //if the digit is negative
         //   {
         //      continue;
         //   }
         //   int digit = num[i] - '0'; //convert from char to int

         //   if (digit % 2 == 0)
         //   {
         //      sumEven += digit;
         //   }
         //   else
         //   {
         //      sumOdd += digit;
         //   }
         //}
         //if (sumEven == sumOdd)
         //{
         //   Console.WriteLine("straight {0}", sumEven);
         //}
         //else if (sumOdd > sumEven)
         //{
         //   Console.WriteLine("left {0}", sumOdd);
         //}
         //else
         //{
         //   Console.WriteLine("right {0}", sumEven);
         //}

      }
   }
}
