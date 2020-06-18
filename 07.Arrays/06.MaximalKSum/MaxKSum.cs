//Write a program that reads two integer numbers N and K and an array of N elements from the console.Find the maximal sum of K elements in the array.

//Input
//•On the first line you will receive the number N
//•On the second line you will receive the number K
//•On the next N lines the numbers of the array will be given

//Output
//•Print the maximal sum of K elements in the array

//Constraints
//•1 <= N <= 1024
//•1 <= K <= N


using System;

namespace _06.MaximalKSum
{
    class MaxKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
           
            int k = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
               array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;

            Array.Sort(array);
            Array.Reverse(array);

            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                maxSum += array[i];
            }
            Console.WriteLine(maxSum);
        }
    }
}
