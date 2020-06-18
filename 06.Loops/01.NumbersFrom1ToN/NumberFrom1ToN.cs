using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

//Input
//•The input will consist of a single line - the number N

//Output
//•The output should consist of a single line - the numbers from 1 to N, separated by a whitespace


namespace _01.NumbersFrom1ToN
{
    class NumberFrom1ToN
    {
        static void Main()
        {
            Console.Write("Please put in a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + " ");
            }
                        
        }
    }
}
