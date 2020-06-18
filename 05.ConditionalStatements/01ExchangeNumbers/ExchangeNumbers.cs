using System;

//Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values if the first one is greater than the second one.Use an if-statement.As a result print the values of the variables A and B, separated by a space.

//Input
//•On the first line, you will receive the value of A
//•On the second line, you will receive the value of B

//Output
//•On the only output line, print the values of the two variables, separated by a whitespace


namespace _01ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
