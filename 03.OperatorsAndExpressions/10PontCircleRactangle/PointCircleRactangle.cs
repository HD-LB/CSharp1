using System;

//Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point(x, y) if it is within the circle K({ 1, 1}, 1.5)  and out of the rectangle R(top= 1, left= -1, width= 6, height= 2) .

//Input
//•You will receive the pair of coordinates on the two lines of the input - on the first line you will find x, and on the second - y.

//Output
//•Print inside circle if the point is inside the circle and outside circle if it's outside. Then print a single whitespace followed by inside rectangle if the point is inside the rectangle and outside rectangle otherwise. See the sample tests for a visual description.


namespace _10PontCircleRactangle
{
    class PointCircleRactangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isInCircle = (Math.Pow(x - 1, 2) + (Math.Pow(y - 1, 2)) <= 1.5 * 1.5);
            bool isInRactangle = (x <= 5 && x >= -1) && (y <= 1 && y >= -1);

            if (isInCircle && !isInRactangle)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
           
        }
    }
}
