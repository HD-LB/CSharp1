using System;

namespace _16CheckABitAtAGvvenPosition
{
    class CheckABitAtAGvvenPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 1;
           

            bool isOne = (mask << p & n) > 0;  // >0 because we want to see if the bit is 1
            Console.WriteLine(isOne);

            Console.WriteLine((mask << p & n) > 0 ? true : false);
        }
    }
}
