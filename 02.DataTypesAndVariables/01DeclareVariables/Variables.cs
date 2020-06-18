//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:  52130, -115, 4825932, 97, -10000 . Choose a large enough type for each number to ensure it will fit in it.Try to compile the code.

using System;

namespace _01DeclareVariables
{
    class Variables
    {
        static void Main()
        {
            ushort a = 52130;
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(a);

            sbyte b = -115;
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(b);

            int c = 4825932;
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(c);

            byte d = 97;
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(d);

            short e = -10000;
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(e);
        }
    }
}
