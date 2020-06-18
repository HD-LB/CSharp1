//Write a program that reads your birthday(in the format  MM.DD.YYYY ) from the console and prints on the console how old you are you now and how old will you be after 10 years.

using System;

namespace _09Age
{
   class Age
   {
      static void Main()
      {
         DateTime currentDate = DateTime.Now;
         Console.Write("Enter your birthday: ");
         DateTime birthday = DateTime.Parse(Console.ReadLine());
         System.TimeSpan ageNow = currentDate - birthday;
         double yourAge = ageNow.TotalDays / 365.25; //365.25 because every 4 years there is a leap year
         Console.WriteLine("Your age is: " + ((int)yourAge));
         Console.WriteLine("Your age in 10 years will be: " + ((int)yourAge));

      }
   }
}
