//•Create a console application that prints the current date and time.Find out how in Internet.

using System;

namespace _08CurrentDateTime
{
   class CurrentDateTime
   {
      static void Main()
      {
         Console.WriteLine(DateTime.Now);

         DateTime now = DateTime.Now;
         Console.WriteLine(now);
      }
   }
}
