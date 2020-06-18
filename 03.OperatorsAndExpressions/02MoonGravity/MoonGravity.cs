using System;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//•Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
//•The weight W should be read from the console.

//Input
//•The input will consist of a single line containing a single floating-point number - the weight W.

//Output
//•Output a single floating-point value - how much a man with the weight W on Earth will weigh on the Moon.Output all values with exactly 3-digit precision after the floating point.


namespace _02MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double moonWeight = w * 0.17;
            Console.WriteLine(moonWeight);

        }
    }
}
