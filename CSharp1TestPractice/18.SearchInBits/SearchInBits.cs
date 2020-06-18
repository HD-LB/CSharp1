using System;

//You are given a list of N numbers and a number S.
//Count the occurrences of the most right 4 bits of S in the most right 30 bits in every given number.
//For example there are 3 occurrences of the 4 most right bits of 9 in the number 1177.
//The 4 most right bits of 9 are 1001 and the 30 most right bits in the number 1177 are 000000000000000000010010011001.
//The occurrences are:
//•	000000000000000000010010011001
//•	000000000000000000010010011001
//•	000000000000000000010010011001
//It is allowed for one occurrence to be part of another one (like the first and the second one in the above example).
//Input
//The input data should be read from the console.
//On the first line there will be the number S.
//On the second line there will be the number N.
//On each of the next N lines there will be a number from the list.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the only output line print the number of occurrences found.


namespace _18.SearchInBits
{
   class SearchInBits
   {
      static void Main()
      {
         int S = int.Parse(Console.ReadLine());
         int N = int.Parse(Console.ReadLine()); //how many numbers we have to input
         int count = 0;

         for (int i = 0; i < N; i++)
         {
            int num = int.Parse(Console.ReadLine()); //input numbers 
            for (int pos = 0; pos <= 26; pos++)
            {
               // for (int i = pos; i <= pos + 3; i++)
               bool match = true;
               for (int j = 0; j <= 3; j++)
               {
                  var posInNum = pos + j;
                  var posInS = j;
                  
                  int bitInNum = (num & (1 << posInNum)) >> posInNum; //get the bin in a certain position
                  int bitInS = (S & (1 << posInS)) >> posInS;

                  if (bitInNum != bitInS)
                  {
                     match = false;
                     break;
                  }
               }

               if (match)
               {
                  count++;
               }
               
            }
         }  
         Console.WriteLine(count);
      }          
   }
}
