
//Write a program that finds the most frequent number in an array of N elements.

//Input
//•On the first line you will receive the number N
//•On the next N lines the numbers of the array will be given

//Output
//•Print the most frequent number and how many time it is repeated ◦Output should be REPEATING_NUMBER(REPEATED_TIMES times)


//Constraints
//•1 <= N <= 1024

using System;

namespace _09.FrequentNumber
{
   class FrequentNumber
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         int[] array = new int[n];
         for (int i = 0; i < n; i++)
         {
            array[i] = int.Parse(Console.ReadLine());
         }

         //int frequentNumber = 0;
         //int frequentNumberCount = 0;
         //int mostFrequentNumber = 0;
         //int mostFrequentNumberCount = 0;
         //for (int index = 0; index < array.Length; index++)
         //{
         //   for (int i = 0; i < array.Length; i++)
         //   {
         //      frequentNumber = array[index];
         //      if (frequentNumber == array[i])
         //      {
         //         frequentNumberCount++;
         //      }
         //   }
         //   if (mostFrequentNumberCount < frequentNumberCount)
         //   {
         //      mostFrequentNumberCount = frequentNumberCount;
         //      mostFrequentNumber = frequentNumber;
         //   }
         //   frequentNumberCount = 0;
         //}
         //Console.WriteLine(mostFrequentNumber + "(" + mostFrequentNumberCount + " times)");

         int counterMax = 1;
         int finalMax = 1;
         int elementMax = 0;


         for (int i = 0; i < array.Length; i++)
         {

            counterMax = 0;
            for (int j = 0; j < array.Length; j++)
            {
               if (array[i] == array[j])
               {
                  counterMax++;

               }

            }
            if (finalMax < counterMax)
            {
               finalMax = counterMax;
               elementMax = array[i];
            }

         }
         Console.WriteLine("{0} ({1} times)", elementMax, finalMax);
      }
   }
}
