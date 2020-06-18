using System;

//Write a program that gets two numbers from the console and prints the greater of them.

//Input
//•On the first two lines you will receive the two numbers, A and B

//Output
//•On the only line print the larger of the two numbers ◦*Try implementing it without using if-statements


namespace _05NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a,b));
        }
    }
}
