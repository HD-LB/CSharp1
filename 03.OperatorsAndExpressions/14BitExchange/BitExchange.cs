using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).

//Input
//•On the only input line you will receive the unsigned integer number whose bits you must exchange.

//Output
//•On the only output line print the value of the integer with the exchanged bits.


namespace _14BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint mask = 7; // binary 7 = 0000 0111

            uint firstBits = (n & (mask) << 3) >> 3;
            uint secondBits = (n & (mask) << 24) >> 24;

            n = n & ~(mask << 3);
            n = n & ~(mask << 24);

            n = n | (firstBits << 24);
            n = n | (secondBits << 3);

            Console.WriteLine(n);

        }
    }
}
