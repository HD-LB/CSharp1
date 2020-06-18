using System;

namespace Practice
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('*', n*2),new string(' ', n));

            for (int i = 0; i < n-2; i++)
            {
                if (i != n/2 -1)
                {
                    Console.WriteLine("{0}{1}{2}{0}{1}{0}", "*", new string('/', n * 2 - 2), new string(' ', n));
                }
                else if (i == n/2 - 1)
                {
                    Console.WriteLine("{0}{1}{2}{0}{1}{0}", "*", new string('/', n * 2 - 2), new string('|', n));
                }
            }
            
            Console.WriteLine("{0}{1}{0}", new string('*', n*2),new string(' ', n));

        }
    }
}
