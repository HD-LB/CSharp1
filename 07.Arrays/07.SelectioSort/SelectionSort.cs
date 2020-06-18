//Sorting an array means to arrange its elements in increasing order.Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the array will be given

//Output
//•Print the sorted array ◦Each number should be on a new line


//Constraints
//•1 <= N <= 1024


using System;
using System.Collections.Generic;

namespace _07.SelectioSort
{
   class SelectionSort
   {
      static void Main()
      {
         //int n = int.Parse(Console.ReadLine());
         //int[] array = new int[n];
         //for (int i = 0; i < n; i++)
         //{
         //    array[i] = int.Parse(Console.ReadLine());
         //}


         //for (int i = 0; i < array.Length - 1; i++)
         //{
         //    for (int j = i + 1; j < array.Length; j++) //starting with the next index afrer i --> (i + 1)
         //    {
         //        if (array[i] > array[j]) // swap items
         //        {
         //            int tmp = array[i];
         //            array[i] = array[j];
         //            array[j] = tmp;
         //        }
         //    }
         //}
         //for (int i = 0; i < array.Length; i++) // print sorted array
         //{
         //    Console.Write(array[i] + " ");
         //}


         int[] arr = { 5, 1, 2, 7, 6, 8, 3, 4 };

         int minValue = int.MaxValue;
         int minIndex = -1;
         for (int i = 0; i < arr.Length; i++)
         {
            minValue = int.MaxValue; //reset it on 0 again
            for (int j = i + 1; j < arr.Length; j++) //starting from the next index (i + 1)
            {
               
               if (minValue > arr[j])
               {
                  minValue = arr[j];
                  minIndex = j;
               }
            }
            int temp = arr[i]; //so the first element doesn't get lost
            arr[i] = minValue; //swaping the elements (the smallest goes to the first position)
            arr[minIndex] = temp;

         }
         Console.WriteLine(string.Join(", ", arr));

             



         //int n = int.Parse(Console.ReadLine());
         //List<int> intList = new List<int>();

         //for (int i = 0; i < n; i++)
         //{
         //   intList.Add(int.Parse(Console.ReadLine()));
         //}

         //intList.Sort();
         //foreach (var item in intList)
         //{
         //   Console.WriteLine(item);
         //}


      }
   }
}
