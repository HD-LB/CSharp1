using System;

//Description

//A book has N pages, numbered from 1 to N(1, 2, 3, ... N - 1, N).

//The total number of digits in the page numbers is D.

//How many pages does the book have?

//In other words: Write a program to find the number N.

//Input
//•On the only input line, there will be the number - D - the number of digits used for numbering the book pages.
//•The input data will always be valid and in the format described.There is no need to check it explicitly.

//Output
//•On the only output line, write the number N (the number of the pages in the book)


namespace _03.NumberOFPages
{
   class NumberOfPages
   {
      static void Main()
      {
         int digits = int.Parse(Console.ReadLine()); 
         int pages = 0;

         for (int page = 1; digits != 0; page++)
         {
            pages++;
            digits -= page.ToString().Length;            
         }
         Console.WriteLine(pages);
      }      
   }
}
