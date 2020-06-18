
using System;

//You are given a list of N numbers.
//Get the most right 30 bits of every number and concatenate them.
//Write a program to find the length of the longest sequence of zeroes and the length of the longest sequence of ones from the obtained concatenated sequence.
//See examples for clarification.
//Input
//The input data should be read from the console.
//On the first line there will be the number N.
//On each of the next N lines there will be a number from the list.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the first output line print the length of the longest sequence of zeroes.
//On the third output line print the length of the longest sequence of ones.
//Constraints
//•	N will be between 1 and 100, inclusive.
//•	All numbers will be integers between 0 and 1073741823, inclusive.
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.


namespace _13.BitsToBits
{
   class BitsToBits
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());

         int maxZeroCount = 0;
         int currrentZeroCount = 0;

         int maxOneCount = 0;
         int currentOneCount = 0;

         int lastBit = 5;



         for (int i = 0; i < n; i++)
         {

            int num = int.Parse(Console.ReadLine());
            for (int j = 29; j >= 0; j--) 
            {
               int bit = ((1 << j) & num) >> j;

               if (bit == 1)
               {
                  if (lastBit == 1) // bits == 1
                  {
                     currentOneCount++;
                     maxOneCount = Math.Max(maxOneCount, currentOneCount);

                  }
                  else
                  {

                     currrentZeroCount = 0; //puts the counter back to 0
                     currentOneCount = 1;
                  }

               }
               else // bits == 0
               {
                  if (lastBit == 0)
                  {
                     currrentZeroCount++;
                     maxZeroCount = Math.Max(maxZeroCount, currrentZeroCount);

                  }
                  else
                  {

                     currentOneCount = 0; //puts the counter back to 0
                     currrentZeroCount = 1;
                  }

               }
               lastBit = bit;
            }
         }

         Console.WriteLine(maxZeroCount);
         Console.WriteLine(maxOneCount);
      }
   }
}
