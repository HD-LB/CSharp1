//Description

//Write a program that outputs The "use" of quotations causes difficulties.

//Input
//•None

//Output
//•Print on a single line The "use" of quotations causes difficulties. 


using System;

namespace _07QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string a = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(a);

            string b = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(b);
        }
    }
}
