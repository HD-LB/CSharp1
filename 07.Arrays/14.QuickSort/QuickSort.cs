
//Write a program that sorts an array of integers using the Quick sort algorithm.

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the array will be given

//Output
//•Print the sorted array ◦Each number should be on a new line


using System;
using System.Collections.Generic;

namespace _14.QuickSort
{
   class QuickSort
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         List<int> intList = new List<int>();
         for (int i = 0; i < n; i++)
         {
            intList.Add(int.Parse(Console.ReadLine()));
         }
         intList.Sort();
         //foreach (var item in intList)
         //{
         //   Console.WriteLine(item);
         //}
         Console.WriteLine(string.Join(" ", intList));
      }
   }
}
