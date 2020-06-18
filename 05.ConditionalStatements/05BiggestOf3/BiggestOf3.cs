using System;

//Write a program that finds the biggest of three numbers that are read from the console.

//Input
//•On the first three lines you will receive the three numbers, each on a separate line.

//Output
//•On the only output line, write the biggest of the three numbers.


namespace _05BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //Console.WriteLine(double.MaxValue);

            if ( a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if ( b >=a && b >= c)
            {
                Console.WriteLine(b);

            }
            else
            {
                Console.WriteLine(c);

            }
                
        }
    }
}
