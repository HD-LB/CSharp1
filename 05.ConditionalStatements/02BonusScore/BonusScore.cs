using System;


//Write a program that applies bonus score to given score in the range[1…9] by the following rules:
//• If the score is between 1 and 3, the program multiplies it by 10.
//• If the score is between 4 and 6, the program multiplies it by 100.
//• If the score is between 7 and 9, the program multiplies it by 1000.
//• If the score is less than 0 or more than 9, the program prints "invalid score".

//Input
//•The only input line will contain one integer number - the score

//Output
//•Output the score with the applied bonus


namespace _02BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("Enter a number in the range [1....9]");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(number * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(number * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(number * 1000);
                    break;

                default: Console.WriteLine("Invalid score!");
                    break;
                    




            }
        }
    }
}
