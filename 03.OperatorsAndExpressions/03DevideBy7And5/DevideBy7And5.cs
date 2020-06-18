using System;

//Write a program that does the following:
//•Reads an integer number from the console.
//•Stores in a variable if the number can be divided by 7 and 5 without remainder.
//•Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.


namespace _03DevideBy7And5
{
    class DevideBy7And5
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 7 == 0  && n % 5 == 0)
            {
                Console.WriteLine("true " + n);
            }
            else
            {
                Console.WriteLine("false " + n);
            }

            //bool isDevisible = n % 7 == 0 && n % 5 == 0;
            //Console.WriteLine(isDevisible);
        }
    }
}
