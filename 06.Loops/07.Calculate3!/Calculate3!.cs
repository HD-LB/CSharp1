using System;

//In combinatorics, the number of ways to choose N different members out of a group of N different elements(also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.Your task is to write a program that calculates  N! / (K! * (N - K)!)  for given N and K.
//•Try to use only two loops.


//Input
//•On the first line, there will be only one number - N
//•On the second line, there will also be only one number - K

//Output
//•On the only output line, write the result of the calculation for the provided N and K


namespace _07.Calculate3_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please choose N and K, so that 1 < K < N: " );

            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int factorialN = 1;
            int factorialK = 1;
            int factorialNK = 1;

            if (K > 1 && K < N)
            {

                for (int i = 1; i <= N; i++)
                {
                    factorialN *= i;
                }
                for (int j = 1; j <= K; j++)
                {
                    factorialK *= j;
                }
                for (int g = 1; g <= (N - K); g++)
                {
                    factorialNK *= g;
                }
                Console.WriteLine(factorialN / (factorialK * (factorialNK)));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

           
        }
    }
}
