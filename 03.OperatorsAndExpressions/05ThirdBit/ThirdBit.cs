using System;

//Write a program that reads an integer N from the console and prints true if the third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
//•The counting is done from right to left, meaning 123456's third digit is 4.

//Input
//•The input will always consist of exactly one line, containing the number N.

//Output
//•The output should be a single line - print whether the third digit is 7, following the format described above.

namespace _05ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine())); //Math.Abs returns positive numbers
            //int p = n / 100;
            //int thirdDigit = (p % 10);
            //Console.WriteLine(thirdDigit);
            bool isSeven = (n / 100) % 10 == 7;
            
            Console.WriteLine(isSeven );
            
        }
    }
}
