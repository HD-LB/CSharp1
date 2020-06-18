using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).

//Input
//•On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order

//Output
//•If two different real roots exist, print them on two separate lines ◦Print the smaller root on the first line

//•If only one real root exists, print it on the only output line
//•If no real root exists, print the string "no real roots"
//•The roots, should they exist, must be printed with precision exactly two digits after the floating point


namespace _06QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1;
            double x2;


            double dis = (b * b) - (4 * a * c);
            if (dis < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (dis == 0)
            {
                Console.WriteLine(-(b / (2 * a)));
            }

            else
            {
                x1 = ((-b) + Math.Sqrt(dis)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("{0:0.00} or {1:0.00}", x1, x2);
            }
    }   }
}
