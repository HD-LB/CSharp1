using System;

//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
//•Use only one loop.Print the result with 5 digits after the decimal point.

//Input
//•On the first line you will receive one number - N.
//•On the second line you will receive another number - x.

//Output
//•Output only one number - the sum of the sequence for the given N and x.


namespace _05.Calculate
{
    class Calculate
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            int factorial = 1;
            double sum = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
                sum += factorial / Math.Pow(x, i);

            }
            Console.WriteLine("{0:F5}", sum);

        }
        
    }
}
