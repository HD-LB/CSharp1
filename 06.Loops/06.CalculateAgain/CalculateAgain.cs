using System;

//Write a program that calculates N! / K! for given N and K.
//•Use only one loop.

//Input
//•On the first line, there will be only one number - N
//•On the second line, there will be only one number - K

//Output
//•Output a single line, consisting of the result from the calculation described above.


namespace _06.CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int factorialN = 1;
            int factorialK = 1;

            for (int i = 1; i <= N; i++)
            {
                factorialN *= i;

            }
            for (int i = 1; i <= K; i++)
            {
                factorialK *= i;
            }

            Console.WriteLine(factorialN/factorialK);

        }
    }
}
