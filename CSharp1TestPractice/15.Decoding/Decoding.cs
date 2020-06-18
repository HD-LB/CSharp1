using System;

//You are given a number(SALT) and a text.The text must be encoded using the SALT.
//The encoding is done as follows:
//•	If the character is “@”, stop the program
//•	If the character in the original text is a letter, multiply its char code by the given SALT and add 1000.
//•	If the character in the original text is a digit, add to its char code SALT and add 500
//•	If the character in the original text is not a digit or letter(any other symbol), subtract from its char code SALT
//•	After performing the above operations on the character in the original text:
//o If the character is on even position in the original text - divide the encoded value by 100 and round the precision to 2 decimal digits right of the decimal point
//o Else if the character is on odd position in the original text - multiply by 100
//o The first character is at position 0. 
//Your task is to encode a text, using the rules above the original text, by given the encoded values for each character.
//Input
//The input data is given at the standard input.
//On the first line you will find an integer number – the SALT number
//On the next line, you will find the text, ending with “@”
//The input will be valid, in the specified format, within the constraints given below.There is no need to check the input data explicitly.
//Output
//Print the encoded text


namespace _15.Decoding
{
   class Decoding
   {
      static void Main()
      {
         int salt = int.Parse(Console.ReadLine());
         int position = 0; //counter

         while (true) //TODO: Stop The Loop
         {
            int charCode = Console.Read();
            char ch = (char)charCode; //cast the int to char, so it can be read as char
            int newCode = 0;

            if (ch == '@')
            {
               break;
            }


            if (char.IsLetter(ch)) //(ch >= 'a' && ch <= 'z')
            {
               newCode = (charCode * salt) + 1000;
            }
            else if (ch >= '0' && ch <= '9' ) //char.IsDigit(ch)
            {
               newCode = (charCode + salt + 500);
            }
            else
            {
               newCode = charCode - salt;
            }


            if (position % 2 == 0)
            {
               Console.WriteLine("{0:F2}", newCode / 100.0);
            }
            else
            {
               Console.WriteLine(newCode * 100);
            }
            position++;
         }
      }
   }
}
