//We are given an array of integers and a number  S.Write a program to find if there exists a subset of the elements of the array that has a sum  S.




using System;
using System.Collections.Generic;

namespace _16.SubsetWithSumS
{
   class SubsetWithSumS
   {
      static void Main()
      {
         string input = Console.ReadLine();
         string[] inputNums = input.Split(new char[] {',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

         int[] array = new int[inputNums.Length];
         for (int i = 0; i < inputNums.Length; i++)
         {
            array[i] = int.Parse(inputNums[i]);
         }


         int s = int.Parse(Console.ReadLine());


         long currentSum = 0;
         int counter = 0;

         for (int i = 1; i <= (int)Math.Pow(2, array.Length) - 1; i++) // all possible combinations of the numbers in the array are = 2^lenght
         {
            currentSum = 0;
            string binary = Convert.ToString(i, 2).PadLeft(array.Length, '0');

            for (int j = 0; j < binary.Length; j++)
            {
               if (binary[j].ToString() == "1")
               {
                  currentSum += array[j];
               }
            }
            if (currentSum == s)
            {
               counter++;
            }
         }

         if (counter > 0)
         {
            Console.WriteLine("yes");
         }
         else
         {
            Console.WriteLine("no");
         }










         //long s = long.Parse(Console.ReadLine());
         //byte n = byte.Parse(Console.ReadLine());

         //long[] numbers = new long[n];

         //for (int i = 0; i < n; i++)
         //{
         //   numbers[i] = long.Parse(Console.ReadLine());
         //}

         //List<long> sums = new List<long>();

         //for (int i = 0; i < n; i++)
         //{
         //   for (int j = 0; j < sums.Count; j++)
         //   {
         //      sums.Add(sums[j] + numbers[i]);
         //   }
         //   sums.Add(numbers[i]);
         //}
         //Console.WriteLine(string.Join(", ", sums));
      }
   }
}
