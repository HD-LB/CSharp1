//Description

//Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the array will be given
//•On the last line you will receive the number X

//Output
//•Print the index where X is in the array ◦If there is more than one occurence print the first one
//◦If there are no occurences print  -1 



using System;
using System.Collections.Generic;

namespace _11.BinarySearch
{
   class BinarySearch
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         int[] array = new int[n];
         for (int i = 0; i < n; i++)
         {
            array[i] = int.Parse(Console.ReadLine());
         }
         int element = int.Parse(Console.ReadLine()); //element we want to find

         Array.Sort(array); // always sort the array!

         int leftIndex = 0;
         int rightIndex = array.Length - 1;
         int index = -1;
         int middle = 0;

         while (leftIndex <= rightIndex)
         {
            middle = (leftIndex + rightIndex) / 2;
            if (array[middle] < element)
            {

               leftIndex = middle + 1;

            }
            else if (array[middle] > element)
            {
               rightIndex = middle - 1;
            }
            else // array[middle] == element
            {
               index = middle;
               break;
            }
         }
         Console.WriteLine(index);         
      }
   }
}
