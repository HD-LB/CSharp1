using System;

//Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit. 

//Input
//•On the first line you will receive the number P.On the second line you will receive the number N.

//Output
//•Output a single value - the value of the N-th bit in P.


namespace _12N_thBit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 1;

            if ((mask << p & n) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
            //bool isZero = (mask << p & n) == 0 ? "true" : "false";
            //Console.WriteLine(isZero);

            //Console.WriteLine((mask << p & n) == 0 ? "0" : "1");
        }
    }
}
