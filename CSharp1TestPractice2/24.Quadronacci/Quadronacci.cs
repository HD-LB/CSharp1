using System;
//http://telerikacademy.com/Courses/LectureResources/Video/5476/Exam-preparation-Tribonacci-Quadronacci-Rectangle-%d0%af%d0%bd%d0%ba%d0%be
//http://bgcoder.com/Contests/43/Telerik-Academy-Exam-1-29-Dec-2012


//you all know the fibonacci sequence.well, the quadronacci sequence is almost the same, but it uses the last four numbers (instead of the last two) to calculate the next number in the sequence.so, we can define each element in the sequence as:
//q n = q n-1 + q n-2 + q n-3 + q n-4
//where q n is the current quadronacci number (n is the index of the current quadronacci number).
//the quadronacci sequence can begin with any four integer numbers – positive or negative – and continue as described by the formula above.
//now, a quadronacci rectangle is what you probably expect – a rectangle(matrix) of numbers from the quadronacci sequence.so we can say that the rectangle's height is actually the number of rows and the rectangle's width is the numbers of columns of numbers.
//if use r for the number of rows and c for the number of columns, then the first row in the rectangle contains the first c numbers from the sequence, the second row contains the next c numbers from the sequence and so on.
//your task is to write a program, which prints to the console a quadronacci rectangle by given the first four numbers of the quadronacci sequence, the number of rows and the number of columns in the rectangle.
//input
//the input data should be read from the console.
//the first four lines will contain the values of the first four numbers of the quadronacci sequence – each number will be on a separate line.
//on the fifth line there will be the number r – the number of rows of the quadronacci rectangle.
//on the sixth line there will be the number c – the number of columns of the quadronacci rectangle.
//the input data will always be valid and in the format described.there is no need to check it explicitly.
//output
//the output data should be printed on the console.
//the output should contain exactly r lines with exactly c numbers per line – representing each line of the quadronacci rectangle.numbers should be separated by exactly one whitespace (" "), and there shouldn't be any whitespaces after the last number on a line.
//constraints
//•	1 ≤ r ≤ 20.
//•	4 ≤ c ≤ 20.
//•	any number in the quadronacci rectangle can be stored in a 64-bit signed integer.
//•	allowed working time for your program: 0.1 seconds.allowed memory: 16 mb.


namespace _24.Quadronacci
{
   class Quadronacci
   {
      static void Main()
      {
         long firstNumber = long.Parse(Console.ReadLine());
         long secondNumber = long.Parse(Console.ReadLine());
         long thirdNumber = long.Parse(Console.ReadLine());
         long fourthNumber = long.Parse(Console.ReadLine());


         int rows = int.Parse(Console.ReadLine());

         int cols = int.Parse(Console.ReadLine());

         if (cols == 4)
         {
            Console.WriteLine("{0} {1} {2} {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
         }
         else
         {
            Console.Write("{0} {1} {2} {3} ", firstNumber, secondNumber, thirdNumber, fourthNumber);
         }

         

         long result = 0;

         for (int row = 0; row < rows; row++)
         {
            int currentCols = 0;
            if (row == 0)
            {
               currentCols = 4;
            }
            for (int col = currentCols ; col < cols; col++)
            {
               result = firstNumber + secondNumber + thirdNumber + fourthNumber;

               firstNumber = secondNumber;
               secondNumber = thirdNumber;
               thirdNumber = fourthNumber;
               fourthNumber = result;


               if (col + 1 == cols)
               {
                  Console.WriteLine(result);
               }
               else
               {
                  Console.Write(result + " ");
               }
            }          
         }  
      }
   }
}
