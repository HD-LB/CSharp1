//Declare two integer variables  a and  b and assign them with  5  and  10  and after that exchange their values by using some programming logic.Print the variable values before and after the exchange.

using System;

namespace _09ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = a ^ b;
            b = a ^ b; //b = (a ^ b) ^ b
            a = a ^ b;

            Console.WriteLine(a + " " + b);

            Console.WriteLine(7 ^ 3);// 111 ^ 11 -> 100 (4)
            Console.WriteLine((7 ^ 3) ^ 3);// 100 ^ 11 -> 111(7)
        }
    }
}
