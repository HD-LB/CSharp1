using System;

//Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point.

//Input
//•On the only line of the input you will receive the radius of the circle - r

//Output
//•You should print one line only: the perimeter and the area of the circle, separated by a whitespace, and with 2 digits precision


namespace _03Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("Perimeter: {0:0.00}", perimeter);
            Console.WriteLine("Area: {0:0.00}", area);

        }
    }
}
