using System;

//We are given an integer number N(read from the console), a bit value v(read from the console as well) (v = 0 or 1) and a position P(read from the console). Write a sequence of operators(a few lines of C# code) that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. Print the resulting number on the console.

//Input
//•The input will consist of exactly 3 lines containing the following: i.First line - the integer number N.
//ii.Second line - the position P.
//iii.Third line - the bit value v.



//Output
//•Output a single line containing the value of the number N with the modified bit.


namespace _13ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int mask = 1;

            if (v == 0)
            {
                n = n & ~(mask << p);
            }
            else
            {
                n = n | (mask << p);
            }
            Console.WriteLine(n);
           
        }
    }
}
