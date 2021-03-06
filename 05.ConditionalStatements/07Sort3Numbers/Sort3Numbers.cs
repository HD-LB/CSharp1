﻿using System;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//•Use nested  if  statements.
//•Don’t use arrays and the built-in sorting functionality.

//Input
//•On the first three lines, you will receive the three numbers, each on a separate line.

//Output
//•Output a single line on the console - the sorted numbers, separated by a whitespace

namespace _07Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
                if (b > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            if (b > a && b > c)
                if (a > c)
                {
                    Console.WriteLine("{0}, {1}, {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", b, c, a);
                }
            if (c > a && c > b)
                if (a > b)
                {
                    Console.WriteLine("{0}, {1}, {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", c, b, a);
                }
        }
    }
}
