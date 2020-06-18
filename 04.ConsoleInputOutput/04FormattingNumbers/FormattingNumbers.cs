using System;

//•Write a program that reads 3 numbers: ◦integer a(0 <= a <= 500)
//◦floating-point b
//◦floating-point c

//•The program then prints them in 4 virtual columns on the console.Each column should have a width of 10 characters.
//◦The number a should be printed in hexadecimal, left aligned
//◦Then the number a should be printed in binary form, padded with zeroes
//◦The number b should be printed with 2 digits after the decimal point, right aligned
//◦The number c should be printed with 3 digits after the decimal point, left aligned. 


//Examples:


//a

//b

//c

//result


//254 11.6 0.5  FE |0011111110| 11.60|0.500 |  
//499 -0.5559 10000  1F3 |0111110011| -0.56|10000.000 |  
//0 3 -0.1234  0 |0000000000| 3.00|-0.123 |  


namespace _04FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0}|{1}|{2,10:#.##}|{3,-10:#.###}|", (a.ToString("X").PadRight(10,' ')), (Convert.ToString(a, 2).PadLeft(10,'0')), b, c);
                        
        }
    }
}
