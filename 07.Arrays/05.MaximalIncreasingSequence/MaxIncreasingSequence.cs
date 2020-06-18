
//Write a program that finds the length of the maximal increasing sequence in an array of N integers.

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the array will be given

//Output
//•Print the length of the maximal increasing sequence

//Constraints
//•1 <= N <= 1024

using System;

namespace _05.MaximalIncreasingSequence
{
   class MaxIncreasingSequence
   {
      static void Main()
      {
         //int n = int.Parse(Console.ReadLine());
         //int[] array = new int[n];


         string input = Console.ReadLine();
         string[] inputNums = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
         int[] array = new int[inputNums.Length];
         for (int i = 0; i < array.Length; i++)
         {
            array[i] = int.Parse(inputNums[i]);
         }

         //array[0] = int.Parse(Console.ReadLine());

         int currentSeq = 1;
         int maxSeq = 0;


         for (int i = 1; i < array.Length; i++)
         {
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] >= array[i - 1] + 1)
            {

               currentSeq += 1;
               maxSeq = Math.Max(maxSeq, currentSeq);
            }
            else
            {
               currentSeq = 1;
            }
         }
         Console.WriteLine(maxSeq);
      }
   }
}
