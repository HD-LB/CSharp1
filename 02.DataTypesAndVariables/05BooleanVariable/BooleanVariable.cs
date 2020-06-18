//Declare a Boolean variable called  isFemale  and assign an appropriate value corresponding to your gender. Print it on the console.

using System;

namespace _05BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            bool isFemale = true;
            Console.Write(isFemale);

            Console.Write("Are you a Female? (Yes/No):  ");
            string answer = Console.ReadLine();

            if (answer == "Yes")
            {
                isFemale = true;
                Console.WriteLine(isFemale);
            }
            else if (answer == "No")
            {
                isFemale = false;
                Console.WriteLine(isFemale);
            }
            else
            {
                Console.WriteLine("Invalid answer!");
            }
        }
    }
}
