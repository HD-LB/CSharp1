using System;

namespace _15
{
    class Joro
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int numOfHolidays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());
            double totalPlays = 0;
            totalPlays += hometownWeekends;
            totalPlays += (52 - hometownWeekends) * 2 / 3;
            totalPlays += numOfHolidays * 0.5;

            if (leap == "t")
            {
                totalPlays += 3;
            }
            int total = (int)Math.Round(totalPlays);
            Console.WriteLine(total);

        }
    }
}
