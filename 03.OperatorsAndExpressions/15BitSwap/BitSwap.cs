using System;

//Write a program first reads 4 numbers n, p, q and k and than swaps bits { p, p+1, …, p+k-1}
//with bits { q, q+1, …, q+k-1}
//of n. Print the resulting integer on the console.


//Input
//•On the only four lines of the input you will receive the integers n, p, q and k in this order.

//Output
//•Output a single value - the value of n after the bit swaps.


namespace _15BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (Math.Max(p, q) + k - 1 > 31)
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Max(p, q) + k - 1 >= Math.Min(p, q))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = p; i <= p + k - 1; i++)
                {
                    uint mask = 1;

                    uint bitQ = (n & (mask << q)) >> q;
                    uint bitP = (n & (mask << i)) >> i;

                    n = n & ~(mask << i);
                    n = n & ~(mask << q);

                    n = n | (bitP << q);
                    n = n | (bitQ << i);
                    q++;
                }
                Console.WriteLine(n);
            }
           

        }
    }
}
