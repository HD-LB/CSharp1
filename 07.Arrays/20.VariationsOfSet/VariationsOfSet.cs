//Write a program that reads two numbers  N  and  K  and generates all the variations of  K  elements from the set [ 1..N ].

using System;

namespace _20.VariationsOfSet
{
   class VariationsOfSet
   {
      static void Main()
      {
         int n = 3;
         int k = 2;

         int[] arr = new int[n];
         for (int i = 0; i < n; i++)
         {
            arr[i] = i + 1;
         }
         Variations(arr, new int[k], 0);//call the method "Variations" --> Ctral + . , starting from index 0

      }



      //method that calculates all the variations of K elements from the set[1....N]
      private static void Variations(int[] nums, int[] arr, int index) 
      {
         if (index == arr.Length)    //the last index
         {
            Console.WriteLine(string.Join(", ", arr)); //bottom of the recursion
            return; //puts it on the Console and stops the program
         }
         //else
         for (int i = 0; i < nums.Length; i++)
         {
            arr[index] = nums[i];
            Variations(nums, arr, index + 1);
         }
      }
   }
}
