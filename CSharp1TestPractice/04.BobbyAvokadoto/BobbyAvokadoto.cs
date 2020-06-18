using System;

//Description

//Bobi Avokadoto loves to comb his hair(and to buy new combs). Bobi's head is represented by an integer N. All C combs that he can buy are also represented as integers. Bobi can use a comb only if his head and the comb don't have any overlapping set(1) bits(the 1s in N represent hairs and 0s represent bald spots and the 1s in a comb represent the comb's teeth). The best comb for Bobi is the comb with most teeth(bits set to 1) that he can use. Write a program that finds the best comb for Bobi by given N and combs, and prints it on the console.

//Example: let N be 17 and the combs be 14, 2, 19 and 10
//17 is 10001 - Bobi's head
//14 is  1110 - comb - Bobi can use 14, because no bits overlap.
//2  is    10 - comb - Bobi can use 2, because no bits overlap.
//19 is 10011 - comb - Bobi can't use 19, because there are overlapping bits.


//Input
//•On the first line, you will receive the number N.
//•On the second line, you will receive the number of combs C.
//•On each of the next C lines, you will receive a single integer representing a comb.

//Output
//•On the only output line, print the integer representing the best comb for Bobi.


namespace _04.BobbyAvokadoto
{
   class BobbyAvokadoto
   {
      static void Main()
      {
         uint head = uint.Parse(Console.ReadLine());
         uint combCount = uint.Parse(Console.ReadLine());

         uint bestComb = 0;
         int bestCount = 0;


         for (int i = 0; i < combCount; i++)
         {
            uint comb = uint.Parse(Console.ReadLine());

            //checking if the comb is valid
            if ((head & comb) == 0) 
            {//comb is valid 
               //count the teeth
               int currentCount = 0;
               for (int j = 0; j < 32; j++) // 32 bits
               {
                  currentCount += (int)((comb >> j) & 1);
               }
                           

               //check it is the best
               if (currentCount > bestCount)
               {
                  bestCount = currentCount;
                  bestComb = comb;
               }
            }
         }
         Console.WriteLine(bestComb);
      }
   }
}
