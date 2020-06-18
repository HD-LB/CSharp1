using System;

//Write a program that read a digit[0 - 9] from the console, and depending on the input, shows the digit as a word(in English).
//•Print "not a digit" in case of invalid input.
//•Use a switch statement.

//Input
//•The input consists of one line only, which contains the digit.

//Output
//•Output a single line - should the input be a valid digits, print the english word for the digits. Otherwise, print "not a digit".


namespace _08DigitAsNumber
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.WriteLine("Enter a digit in the range [0....9].");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Not a digit");
                     break;
            }
        }
    }
}
