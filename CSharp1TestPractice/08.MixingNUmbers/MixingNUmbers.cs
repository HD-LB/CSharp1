using System;


//We have the following operations defined for two-digit numbers:
//•Mixing: mixing ab  and cd  produces b * c  ◦ 42  mixed with  17  produces  2 * 1 = 2 
//◦ 17  mixed with  42  produces  7 * 4 = 28 

//•Subtracting: I believe you know how to subtract numbers :) ◦ 42  -  17  =  25 
//◦ 39  -  57  =  18  (lets ignore the sign)


//You have a sequence of N  two-digit numbers.Your task is to mix and subtract each pair of adjacent numbers.

//Input

//All input data is read from the standard input (the console)
//•On the first line you will receive an integer N
//•On the next N  lines you will receive  N two-digit numbers ◦One on each line


//Output

//The output data is printed on the standard output(the console)

//•On the first output line print the mixed numbers
//◦There should be N - 1  of them
//◦Separate them by spaces


//•On the second output line print the subtracted numbers
//◦There should be N - 1  of them
//◦Separate them by spaces


//•Hint: You can use Console.WriteLine(String.Join(" ", array)); 




namespace _08.MixingNUmbers
{
   class MixingNUmbers
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         int[] array = new int[n];
         for (int i = 0; i < n; i++)
         {
            array[i] = int.Parse(Console.ReadLine());
         }
         int[] mixArr = new int[n - 1]; //as per instructions
         int[] subArr = new int[n - 1]; //as per instructions

         for (int i = 0; i < n - 1; i++)
         {
            int firstDig = array[i] % 10;
            int secondDig = (array[i + 1] / 10) % 10;

            mixArr[i] = firstDig * secondDig ;
            subArr[i] = Math.Abs(array[i] - array[i + 1]);
         }
         Console.WriteLine(String.Join(" ", mixArr));
         Console.WriteLine(String.Join(" ", subArr));



         //int n = int.Parse(Console.ReadLine());
         //string mixLine = "";
         //string subLine = "";

         //int prevNum = int.Parse(Console.ReadLine());

         //for (int i = 0; i < n - 1; i++)
         //{
         //   int nextNum  = int.Parse(Console.ReadLine());

         //   mixLine += string.Format("{0} ", (prevNum % 10) * ((nextNum / 10) % 10));
         //   subLine += string.Format("{0} ", Math.Abs(prevNum - nextNum));


         //   prevNum = nextNum;
         //}
         //Console.WriteLine(mixLine);
         //Console.WriteLine(subLine);
      }
   }
}
