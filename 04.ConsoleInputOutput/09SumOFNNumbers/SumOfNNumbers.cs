using System;

//Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
//• Note: You may need to use a for-loop.

//Input
//•On the first line, you will receive the number N
//•On each of the next N lines, you will receive a floating-point number

//Output
//•On must output only one number - the sum of the N numbers


namespace _09SumOFNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
