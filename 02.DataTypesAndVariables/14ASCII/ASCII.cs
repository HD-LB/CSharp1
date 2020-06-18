//Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints the visible characters of the ASCII table on the console(characters from  33  to  126  including).

//Note: You may need to use for-loops(learn in Internet how).

//Input
//•None

//Output
//•The  94  characters on single line


using System;
using System.Text;

namespace _14ASCII
{
    class ASCII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            for (int i = 0; i <= 255; i++)
            {
                Console.Write((char)i + " ");
                
            }
        }
    }
}
