using System;

//Write a program that reads an integer number N from the console and prints all the numbers in the interval[1, n], each on a single line.

//Input
//•On the only line you will receive the number N


//Output
//•You should print the numbers from 1 to N, each on a separate line


namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
            
        }
        
    }
}
