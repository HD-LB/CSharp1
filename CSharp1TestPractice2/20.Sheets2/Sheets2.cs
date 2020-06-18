using System;
namespace _20.Sheets2
{
   class Sheets2
   {
      static void Main()
      {
         int input = int.Parse(Console.ReadLine());

         int[] sheetsValue = new int[11] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };


         for (int i = 0; i < sheetsValue.Length; i++)
         {
            if (input < sheetsValue[i])
            {
               Console.WriteLine("A" + i);
            }
            else
            {
               input -= sheetsValue[i];
            }
         }

      }
   }
}
