using System;

//Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
//1.Calculates the sum of the digits(in our example  2 + 0 + 1 + 1 = 4 ) and prints it on the console.
//2.Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
//3.Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
//4.Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.

//Input
//•The input will consist of a single four-digit integer number on a single line.

//Output
//•Output the result of each action on a separate line, in the same order as they are explained above: ◦meaning the sum comes on the first line, the reversed number on the second, and so on.



namespace _06FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int d = n % 10;
            int c = (n / 10) % 10;
            int b = (n / 100) % 10;
            int a = (n / 1000) % 10;

            int sum = a + b + c + d;
            Console.WriteLine(sum);

            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
           
        }
    }
}
