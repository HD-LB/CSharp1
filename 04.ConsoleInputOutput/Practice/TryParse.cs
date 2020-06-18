using System;

namespace Practice
{
    class TryParse
    {
        static void Main()
        {
            int num;
            string input;
            
            do
            {
                Console.Write("Enter a valid number: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out num));

            Console.WriteLine("Thank you! You entered the number {0}", num);
        }
    }
}
