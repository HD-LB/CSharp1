using System;


//Write a program that reads an integer N(which will always be less than 100 or equal) and uses an expression to check if given N is prime(i.e.it is divisible without remainder only to itself and 1).
//•Note: You should check if the number is positive

//Input
//•On the only input line you will receive the number N.

//Output
//•Output true if the number is prime and false otherwise.



namespace _08PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // Math.Abs(int.Parse(Console.ReadLine())); also positive numbers

            bool isPrime = true;
            if (n >= 1) // only positive numbers
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                    }
                    
                }
                Console.WriteLine(isPrime);
            }
            else
            {
                Console.WriteLine("false");
            }


        }
    }
}
