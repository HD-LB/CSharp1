using System;

//Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence(at a single line, separated by comma and space - ", ") :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .

//Input
//•On the only line you will receive the number N

//Output
//•On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)


namespace _10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));// only positive numbers
            int a = 0; //first Fibonacci number
            int b = 1; //second Fibonacci number
            int c; //using it to keep the volue of a

            if (n >= 3)
            {
                Console.Write(a + " " + b + " ");
                for (int i = 0; i < n - 2; i++) //n-2 because we already have the first 2 numbers 0 and 1
                {
                    c = a;
                    a = b;
                    b = c + a; //this is already the 3.number
                    Console.Write(b + " ");
                }
            }
            else if (n == 2)
            {
                Console.WriteLine(a + " " + b);
            }
             else if (n == 1)
            {
                Console.WriteLine(a);
            }
           
        }
    }
}
