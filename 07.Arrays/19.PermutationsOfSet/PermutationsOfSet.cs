﻿//Write a program that reads a number N  and generates and prints all the permutations of the numbers[1 … N].

//https://www.youtube.com/watch?v=rY43orFX-Dg

using System;

namespace _19.PermutationsOfSet
{
   class PermutationsOfSet
   {
      static void Main()
      {
         int n = 3;
         int[] arr = new int[n];
         for (int i = 0; i < arr.Length; i++)
         {
            arr[i] = i + 1; //1  2  3
         }
         //calling a method:
         Permutation(arr, 0, arr.Length - 1); // starts from 0 until the last index (arr.Lenght - 1)
      }

      private static void Permutation(int[] arr, int index, int lenght)
      {
         //bottom:
         if (index == arr.Length)
         {
            Console.WriteLine(string.Join(", ", arr));
            return;
         }

         for (int i = index; i < arr.Length; i++)
         {
                        
               Swap(arr, i, index);
               Permutation(arr, index + 1, lenght);
               Swap(arr, i, index);           
            
         }
      }

      private static void Swap(int[] arr, int i, int j)
      {
         int temp = arr[i];
         arr[i] = arr[j];
         arr[j] = temp; 
      }
   }
}
