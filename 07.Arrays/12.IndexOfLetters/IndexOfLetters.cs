//Write a program that creates an array containing all letters from the alphabet(a-z ). Read a word from the console and print the index of each of its letters in the array.

//Input
//•On the first line you will receive the word

//Output
//•Print the index of each of the word's letters in the array ◦Each index should be on a new line



using System;
using System.Collections.Generic;

namespace _12.IndexOfLetters
{
   class IndexOfLetters
   {
      static void Main()
      {
       
         string word = Console.ReadLine();
         int[] alphabet = new int[26];

         for (int i = 0; i < 26; i++)
         {
            alphabet[i] = 'a' + i;
         }

         for (int i = 0; i < word.Length; i++)
         {
            for (int j = 0; j < alphabet.Length; j++)
            {
               if (word[i] == alphabet[j])
               {
                  Console.WriteLine(j);
                  break;
               }
            }
         }

      }
   }
}
