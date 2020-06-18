//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the array will be given

//Output
//•Print the length of the maximal sequence

//Constraints
//•1 <= N <= 1024


using System;

namespace _04.MaximalSequence
{
   class MaximalSequence
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         //int[] array = new int[n];

         //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1"; //Console.ReadLine();
         //string[] inputNums = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
         //int[] array = new int[inputNums.Lenght];
         //for (int i = 0; i < array.Length; i++)
         //{
         //   array[i] = int.Parse(inputNums[i]);
         //}

         int[] array = new int[n];
         //array[0] = int.Parse(Console.ReadLine());
       
         int currentSeq = 1;
         int maxSeq = 0;

         for (int i = 1; i < n; i++)
         {
            array[i] = int.Parse(Console.ReadLine());

            if (array[i] == array[i - 1])
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
