using System;
using System.Text;

//Description

//Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//•The card faces should start from 2 to A.
//•Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

//Input
//•On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.

//Output
//•The output should follow the format bellow(assume our input is  5 ):   2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds


namespace PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {



            //StringBuilder allCards = new StringBuilder();


            //for (int i = 2; i <= 14; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        switch (i)

            //        {
            //            case 2: allCards.Append("2"); break;
            //            case 3: allCards.Append("3"); break;
            //            case 4: allCards.Append("4"); break;
            //            case 5: allCards.Append("5"); break;
            //            case 6: allCards.Append("6"); break;
            //            case 7: allCards.Append("7"); break;
            //            case 8: allCards.Append("8"); break;
            //            case 9: allCards.Append("9"); break;
            //            case 10: allCards.Append("10"); break;
            //            case 11: allCards.Append("Jack"); break;
            //            case 12: allCards.Append("Queen"); break;
            //            case 13: allCards.Append("King"); break;
            //            case 14: allCards.Append("Ace"); break;

            //            default:
            //                Console.WriteLine("Invalid!");
            //                break;
            //        }
            //        switch (j)
            //        {
            //            case 0: allCards.Append(" of Spades").Append(Environment.NewLine); break;
            //            case 1: allCards.Append(" of Hearts").Append(Environment.NewLine); break;
            //            case 2: allCards.Append(" of Diamonds").Append(Environment.NewLine); break;
            //            case 3: allCards.Append(" of Clubs").Append(Environment.NewLine); break;
            //            default:
            //                Console.WriteLine("Error");
            //                break;
            //        }
            //    }
            //}

            //Console.WriteLine(allCards);

            //string sign = Console.ReadLine();
            //int n;
            //switch (sign)
            //{
            //    case "J": n = 11; break;
            //    case "Q": n = 12; break;
            //    case "K": n = 13; break;
            //    case "A": n = 14; break;
            //    default:
            //        n = int.Parse(Console.ReadLine()); break;

            //}
            //int count = 0;
            //for (int card = 2; card <= n; card++)
            //{
            //    for (int suit = 0; suit < 5; suit++)
            //    {
            //        switch (card)
            //        {
            //            case 11: Console.Write("J");break;
            //            case 12: Console.Write("Q");break;
            //            case 13: Console.Write("K");break;
            //            case 14: Console.Write("A");break;
            //            default:
            //                Console.Write("{0}", card);
            //                break;
            //        }
            //        count++;
            //        switch (suit)
            //        {
            //            case 1: Console.Write(" of Spades");break;
            //            case 2: Console.Write(" of Clubs");break;
            //            case 3: Console.Write(" of Diamonds");break;
            //            case 4: Console.Write(" of Hearts");break;

                      
            //        }
            //        if (count % 4 !=0)
            //        {
            //            Console.Write(", ");
            //        }
            //        else
            //        {
            //            Console.WriteLine();
            //        }
                //}

            //}

        }

    }
}
