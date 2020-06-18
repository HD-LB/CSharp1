//Write a program that finds all prime numbers in the range[1...N]. Use the Sieve of Eratosthenes algorithm.The program should print the biggest prime number which is  <= N.

//Input
//•On the first line you will receive the number N


//Output
//•Print the biggest prime number which is  <= N

//Constraints
//•2 <= N <= 10 000 000


using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.PrimeNumbers
{
   class PrimeNumbers
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         List<int> intList = new List<int>();
         List<int> primeNumbersList = new List<int>();

         for (int i = 0; i < n; i++)
         {
            intList.Add(i);
         }

         for (int i = 0; i < intList.Count; i++)
         {
            if (intList[i] != 0 && intList[i] != 1)
            {
               if (intList[i] == 2)
               {
                  primeNumbersList.Add(intList[i]);
                  continue;
               }
               else
               {
                  bool isPrime = true;
                  for (int j = 2; j <= Math.Sqrt(intList[i]); j++)
                  {
                     if (intList[i] % j == 0)
                     {
                        isPrime = false; break;
                     }
                  }
                  if (isPrime)
                  {
                     primeNumbersList.Add(intList[i]);
                  }
               }
            }
         }
         Console.WriteLine(primeNumbersList.Max());
      }
   }
}
