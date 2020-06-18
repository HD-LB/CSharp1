using System;

//Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

//Input
//•On the first 5 lines you will receive the 5 numbers, each on a separate line

//Output
//•On the only output line, write the biggest of the 5 numbers


namespace _06BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            if ( a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine(b);
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine(c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }
        }

    }
}
