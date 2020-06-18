using System;

//Write a program that reads 5 integer numbers from the console and prints their sum.

//Input

//You will receive 5 numbers on five separate lines.

//Output

//Your output should consist only of a single line - the sum of the 5 numbers.


namespace _07SumOF5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            double a = double.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);
            double d = double.Parse(numbers[3]);
            double e = double.Parse(numbers[4]);
                                       
            
            Console.WriteLine(a + b + c + d + e);


        }
    }
}
