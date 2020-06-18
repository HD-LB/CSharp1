using System;

//Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them such that the reminder of the division by 5 is 0.

//Input
//•On the first two lines you will receive two integers - N on the first and M on the second.

//Output
//•Output a single value - the amount of numbers divisible by 5 without remainder.

namespace _11Interval
{
    class Interval
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0; //how many numbers are % 5

            for (int i = a; i <= b; i++)
            {
                if ( i % 5 == 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(count);
            }
               
            else
            {
                Console.WriteLine("-");
            }
        
        }
    }
}
