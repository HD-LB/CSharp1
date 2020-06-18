using System;

//http://telerikacademy.com/Courses/Courses/Details/212
//http://bgcoder.com/Contests/106/Telerik-Academy-Exam-1-6-December-2013-Morning


//This problem is simple.You are given a text with some digits. Your task is to find all digits in every even position (starting from zero) throughout the text and calculate their sum.
//Input
//The input data should be read from the console.
//On the only input line you will receive the text.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//On the only input line you should print the total amount of digits in even positions and their sum separated by space.
//Constraints
//•	The text’s length will be a valid integer number.
//•	Allowed working time for your program: 0.10 seconds.Allowed memory: 16 MB.

namespace _25.TheHorror
{
   class TheHorror
   {
      static void Main()
      {
         string text = Console.ReadLine();
         int counter = 0;
         int evenCounter = 0;
         int sum = 0;

         foreach (char symbol in text)
         {
            if (counter % 2 == 0)
            {
               if (char.IsDigit(symbol))  // ('a' <= symbol && symbol <= 'z' || 'A' <= symbol && symbol <= 'Z')
               {
                  evenCounter++;
                  sum += symbol - '0'; // int someNum = int.Parse(Console.ReadLine(someNum.ToString());            //continue;
               }               
            }
            counter++;
         }
         Console.WriteLine("{0} {1}", evenCounter, sum);
      }
   }
}
