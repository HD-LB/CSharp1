using System;


//Write a program that reads 3 real numbers from the console and prints their sum.

//Input
//•On the first line, you will receive the number a
//•On the second line, you will receive the number b
//•On the third line, you will receive the number c

//Output

//Your output should consist only of a single line - the sum of the three numbers.


namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double result = a + b + c;

            Console.WriteLine(result);
        }
    }
}
