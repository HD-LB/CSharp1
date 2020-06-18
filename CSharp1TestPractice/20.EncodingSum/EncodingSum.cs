using System;
//http://bgcoder.com/Contests/203/Telerik-Academy-Exam-1-2-February-2015-Evening
//http://telerikacademy.com/Courses/Courses/Details/323


//You are given a text and a number(M). The text can contain any characters: (digits, Latin letters(both capital and letter case) or any other symbols). The character '@' is special – it marks the end of the text.
//Your task is to iterate the text and to perform an operation for every character.Having a RESULT = 0, the operations are as follows:
//•	If the current character is '@', stop the program and print the value of RESULT
//•	If the current character is a digit (‘0’ – ‘9’), then multiply the RESULT by this digit
//•	If the current character is a letter, add its index from the Latin alphabet to RESULT.
//o  'A' has an index 0, ‘B’ has an index 1, etc…
//•	If the current character is a symbol, that is different from the ones described above, create module of the RESULT by the provided number (M)
//•	See the sample input/output for more detailed explanation
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



namespace _20.EncodingSum
{
   class EncodingSum
   {
      static void Main()
      {
         int M = int.Parse(Console.ReadLine());
         string text = Console.ReadLine();
         int result = 0;

         for (int i = 0; i < text.Length - 1; i++)
         {
            char symbol = text[i]; //getting each symbol

            if (symbol == '@')
            {
               break;
            }

            if (char.IsDigit(symbol))
            {
               result *= symbol - '0'; //char.GetNumericValue(symbol);
            }
            else if (char.IsLetter(symbol))  //(('A' <= symbol && symbol <= 'Z') || ('a' <= symbol && symbol <= 'z'))
            {            
               char symbolToLower = char.ToLower(symbol);
               result += symbolToLower - 'a';
            }
            else
            {
               result %= M;
            }
            
         }
         Console.WriteLine(result);
      }
   }
}
