using System;

//Classical play cards use the following signs to designate the card face:  2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.

//Input
//•On the only line you will receive a single string.

//Output
//•Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".


namespace _03PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string card = Console.ReadLine();
            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "K":
                case "Q":
                case "J":
                case "A":
                    Console.WriteLine("yes {0}", card);
                    break;
                default: Console.WriteLine("no {0}", card);
                    break;


            }
        }
    }
}
