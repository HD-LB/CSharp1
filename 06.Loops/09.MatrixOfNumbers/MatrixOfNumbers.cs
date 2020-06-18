using System;

//Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below.Use two nested loops.
//•Challenge: achieve the same effect without nested loops

//Input
//•The input will always consist of a single line, which contains the number N

//Output
//•See the examples.


namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()

        {
            int n = int.Parse(Console.ReadLine());

            if ( n >= 1 && n <=20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
                     
        }
    }
}
