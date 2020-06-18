
using System;

namespace Practice
{
    class Practice
    {
        static void Main()
        {
            //int a = 5;

            //Console.WriteLine(Convert.ToString(16, 2));
            //Console.WriteLine(Convert.ToString(3, 2));
            //Console.WriteLine(16 | 3);
            //Console.WriteLine(Convert.ToInt32("10000010", 2));
            ////7 is 111
            //Console.WriteLine(7 << 1);

            //for (int i = 0; i <20; i++)
            //{
            //    Console.WriteLine(i + " is " + (( i & 1) == 1 ? "odd" : "even" ));

            //}

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 1;
            Console.WriteLine((mask << p & n) == 0 ? "0" : "1");

        }
            
        }
    }
}
