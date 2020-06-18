using System;
using System.Numerics;

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//•Write a program to calculate the Nth Catalan number by given N

//Input
//•On the only line, you will receive the number N

//Output
//•Output a single number - the Nth Catalan number


namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //int factorialN = 1;
            //int numerator;
            //int factorialK = 1;
            //int sum;

           

            if (n >= 1 && n <= 100)
            {
                BigInteger numerator = 1;
                for (int i = 1; i <= (2 * n); i++)
                {
                    numerator *= i; // (2*n)!
                }


                BigInteger denominator = 1;
                for (int i = 1; i <= (n + 1); i++)
                {
                    denominator *= i; //(n+1)!
                }

                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i; //n!

                }

                Console.WriteLine(numerator / (denominator * factorial));

            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
