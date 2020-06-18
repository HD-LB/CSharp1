using System;
using System.Text;

namespace Demo
{
    class Demo
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Това е кирилица: :)");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
