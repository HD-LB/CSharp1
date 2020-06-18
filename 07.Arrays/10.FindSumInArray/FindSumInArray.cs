//Write a program that finds in given array of integers a sequence of given sum S(if present).

using System;

namespace _10.FindSumInArray
{
   class FindSumInArray
   {
      static void Main()
      {
         //Input Array
         string input = Console.ReadLine();
         string[] inputNums = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); //splitting the input into an arry

         int[] arrayNums = new int[inputNums.Length]; //fill in Integer array from a string array
         for (int i = 0; i < inputNums.Length; i++)
         {
            arrayNums[i] = int.Parse(inputNums[i]);
         }

         //Input Sum
         int s = int.Parse(Console.ReadLine());

         for (int i = 0; i < arrayNums.Length; i++)
         {
            int sum = 0;
            for (int j = i; j < arrayNums.Length; j++)
            {
               sum = sum + arrayNums[j];
               if (sum > s)
               {
                  sum = 0;
                  break;
               }
               if (sum == s)
               {
                  for (int index = i; index <= j; index++)
                  {
                     Console.Write(index != j ? arrayNums[index] + ", " : arrayNums[index] + "\n");
                   
                  }
               }
            }
         }
      }
   }
}
