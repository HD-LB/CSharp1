using System;

//http://bgcoder.com/Contests/5/Telerik-Academy-Exam-1-7-Dec-2011-Morning
//http://telerikacademy.com/Courses/LectureResources/Video/5477/Exam-preparation-Miss-Cat-2011-Astrological-Digits-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be

//The astrological digit of a given number N is a digit calculated by the number's digits by a special algorithm. The algorithm performs the following steps:
//(1)	Sums the digits of the number N and stores the result back in N.
//(2)	If the obtained result is bigger than 9, step(1) is repeated, otherwise the algorithm finishes.
//The last obtained value of N is the result, calculated by the algorithm.
//Input
//The input data should be read from the console.
//The only line in the input contains a number N, which can be integer or real number (decimal fraction).
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You must print the calculated astrological digit of the number N on the first and only line of the output.
//Constraints
//•	The number N will be in range[-1.7 × 10−308… 1.7 × 10308]. It will have no more than 300 digits before and after the decimal point.
//•	The decimal separator will always be the "." symbol.
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.



namespace _25.AstrologicalDigits //TODO:
{
   class AstrologicalDigits
   {
      static void Main()
      {
         string inputNumber = Console.ReadLine();

         int sum = 0;         

         while (true)
         {
            for (int i = 0; i < inputNumber.Length; i++)
            {
               if (!(inputNumber[i] == '.' || inputNumber[i] == '-'))
               {
                  sum += int.Parse(inputNumber[i].ToString());
               }
            }

            if (sum < 10)
            {
               break;
            }


            inputNumber = sum.ToString();
            sum = 0;
         }
         Console.WriteLine(sum);
      }
   }
}
