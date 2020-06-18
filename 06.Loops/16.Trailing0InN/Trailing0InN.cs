using System;
using System.Numerics;

//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//•Your program should work well for very big numbers, e.g.N = 100000.

//Input
//•On the only input line, you will receive a single integer - the number N

//Output
//•Output a single number - the count of trailing zeroes for the N!
//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!


namespace _16.Trailing0InN
{
    class Trailing0InN
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

            }
            Console.WriteLine("{0}! = {1}", n, factorial);

            int zeroCounter = 0;
            while (true)
            {
                int result = n / 5;
                if (result != 0)
                {
                    zeroCounter = zeroCounter + result;
                    n = result;
                }
                else
                {
                    Console.WriteLine("Trailing Zeros Count: {0}", zeroCounter);
                    break;
                }
            }
        }   
        
    }
}
