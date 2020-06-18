//Write a program that reads two  integer arrays of size N from the console and compares them element by element.

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the first array will be given
//•On the next N lines the numbers of the second array will be given


//Output
//•Print Equal  if the two arrays are the same and Not equal  if they are not

//Constraints
//•1 <= N <= 20


using System;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

         
            bool equal = true;
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    Console.WriteLine("Not equal");
                    break;
                }
            }
            if (equal)
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
