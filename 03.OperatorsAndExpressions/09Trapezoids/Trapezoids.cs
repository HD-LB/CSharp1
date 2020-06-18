using System;

//•The input will consist of exactly 3 lines: i.The side a on the first line.
//ii.The side b on the second line.
//iii.The height h on the third line.


//Output
//•Output a single line containing a single value - the area of the trapezoid.Output the area with exactly 7-digit precision after the floating point.


namespace _09Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine(area);

        }
    }
}
