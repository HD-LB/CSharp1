using System;

//Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console.
//•The bits are counted from right to left, starting from bit 0.
//•The result of the expression should be either 1 or 0. Print it on the console.

//Input
//•On the only input line, you will receive a single positive integer - the number whose 3rd bit you must print.

//Output
//•Output a single number - 1 or 0 - the value of the 3rd bit, counted from 0 and from right to left.


namespace _113rdBit
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            //string a = Convert.ToString(n, 2).PadLeft(8,'0');
            uint mask = 1;
            if ((mask << 3 & number) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
            //Console.WriteLine((mask << 3 & number) == 0 ? "0" : "1");
        }
    }
}
