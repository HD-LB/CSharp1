//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
//•Can you do it with only one loop (with single scan through the elements of the array)?

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the array will be given

//Output
//•Print the maximal sum of consecutive numbers

//Constraints
//•1 <= N <= 1024


using System;

namespace _08.MaximalSum
{
   class MaximalSum
   {
      static void Main()
      {
         //int n = int.Parse(Console.ReadLine());//??????
         //int[] array = new int[n];
         //array[0] = int.Parse(Console.ReadLine());


        
         //int[] nums = { 2, 3, -6, -1, 2, -3, 6, 4, -8, 8 };

         string input = Console.ReadLine();
         string[] inputNums = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
         int[] array = new int[inputNums.Length];
         for (int i = 0; i < array.Length; i++)
         {
            array[i] = int.Parse(inputNums[i]);
         }



         int sum = 0;
         int maxSum = 0;

         for (int index = 0; index < array.Length - 1; index++)
         {
            sum += array[index];
            for (int i = index + 1; i < array.Length - 1; i++)
            {
               sum += array[i];
               if (maxSum < sum)
               {
                  maxSum = sum;
               }
            }
            sum = 0;

         }
         Console.WriteLine(maxSum);
      }
   }
}
