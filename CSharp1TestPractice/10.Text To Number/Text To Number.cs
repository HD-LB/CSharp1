using System;

//You are given a text and a number(M). This text can contain digits, Latin letters(both capital and letter case) and any other symbols, except for '@'. The number is used to the parsing of the text.
//Your task is to go through all characters of the text and, starting from RESULT = 0, to perform the following operations:
//•	If the current character is '@', stop the program and print the RESULT
//•	If the current character is a digit(0-9), then multiply the RESULT by this digit
//•	If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
//•	If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)
//Input
//The input data is given at the standard input. 
//It consists of two lines:
//•	The first one contains the number M, that is used for the module of the result
//•	The second line contains the text
//The input will be valid, in the specified format, within the constraints given below. There is no need to check the input data explicitly.
//Output
//Print the result from the parsing (RESULT)
//Constraints
//•	M will always be between 2000 and 10 000
//•	The length of the text will always be less than 100 000
//•	Allowed working time for your program: 0.5 seconds.
//•	Allowed memory: 16 MB.


namespace _10.Text_To_Number
{
   class Program
   {
      static void Main()
      {
         //read input
          
         int module = int.Parse(Console.ReadLine());
         string text = Console.ReadLine();

         long result = 0;

         //logic

         for (int i = 0; i < text.Length; i++)
         {
            char ch = text[i]; //it's taking each letter

            if (ch == '@')
            {
               break;
            }
            else if ('0' <= ch && ch <= '9') //in the ASCCI table 0 = 48 and 9 = 57
            {
               result *= (ch - '0'); //so it gets the actual symbol and not the ASCII table char
            }
            else if ('a' <= ch && ch <= 'z')
            {
               result += (ch - 'a'); //so it gets the actual symbol and not the ASCII table char
            }
            else if ('A' <= ch && ch <= 'Z') // or text = text.toLower() at the beginning
            {
               result += (ch - 'A');
            }
            else
            {
               result %= module;
            }
         }

         //print result

         Console.WriteLine(result);
      }
   }
}
