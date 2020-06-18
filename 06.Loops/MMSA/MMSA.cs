using System;
using System.Globalization;
using System.Threading;

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).
//•The input starts by the number N(alone in a line) followed by N lines, each holding an integer number.
//•The output is like in the examples below.

//Input
//•On the first line, you will receive the number N.
//•On each of the next N lines, you will receive a single floating-point number.


//Output
//•You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, the sum on the third and the average on the fourth, in the following format:
//min= 3.00
//max= 6.00
//sum= 9.00
//avg= 4.50



namespace MMSA
{
    class MMSA
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;



            int n = int.Parse(Console.ReadLine());

            double min = double.MaxValue;
            double max = double.MinValue;



            double number;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());



                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
            }
            Console.WriteLine("min = {0:F2}", min);
            Console.WriteLine("max = {0:F2}", max);
            Console.WriteLine("sum = {0:F2}", sum);

            double avarage = sum / n;
            Console.WriteLine("avg = {0:F2}", avarage);
        }

        
    }
}
