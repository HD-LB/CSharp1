using System;


//Description

//Tzacky has a great idea to hide messages in subtitles of movies.But his friend, just started to code and has difficulty decoding the messages.He knows that to do so, he needs to take the numbers that come before each subtitle and use them to decode the message. The first number I is the index of the symbol he should start decoding (starting from 0) and the second number S is the number of symbols he needs to skip to get every other symbol.If the starting index is larger than the length of the line, this means that the line should be skipped.

//•example:
//input                 result                    explanation

//4                     codi                      add carbon additive
//4
//add carbon additive                             start from c (4th symbol counting from 0), then take every 4th -> o, d and i

//end


//To make things easy, when the subtitles finish Tzacky always adds end instead of the starting index I (see sample tests).

//Sometimes Tzacky wants to be extra sure his message will be hidden, so he decided to add additional complexity.
//•If S is negative your program should look for the next symbol to the left of the starting index (go backwards).
//•If I is negative your program should take the symbol counting from the end of the line as starting index ◦example 1: for I = -1 ◾line of code: "some random text that makes no sence"

//◦example 2: for I = -6 ◾line of code: "some random text that makes no**_**sence" (the space)



//Input
//•On the first line you can read the index of the first symbol i , if instead of a number you read end your program should print the hidden message so far and stop.
//•On the second line you will get a number, that is the number of symbols to skip to reach the next symbol for the hidden message.
//•On the third line you will get a line of text on witch you have to use the previously read numbers.

//Output
//•The output should consist of a single line containing the full hidden message.


namespace _07.HiddenMessage
{
   class HiddenMessage
   {
      static void Main()
      {
         
         string hiddenMessage = "";

         while (true)
         {
            string indStr = Console.ReadLine(); // The index I we have to read 
            if (indStr == "end")
            {
               break;
            }

            int ind = int.Parse(indStr);
            int step = int.Parse(Console.ReadLine()); // steps to jump, it starts at 0 and don't forget to count the space bar
            string line = Console.ReadLine();

            if (ind < 0) //for negative steps, counting from right to left
            {
                ind += line.Length; 
            }

            for (; ind < line.Length && ind >= 0; ind += step)
            {
               hiddenMessage += line[ind];
            }

         }
         Console.WriteLine(hiddenMessage);
      }
   }
}
