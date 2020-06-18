using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
   class List
   {
      static void Main()
      {
         //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

         //list[2] = 100;
         //for (int i = 0; i < list.Count; i++)
         //{
         //   list[i] *= 2;
         //}

         //foreach (int x in list)
         //{
         //   Console.WriteLine(x);
         //}


         //List<int> list = new List<int>(); // Adding elements  var list = new List<int>();

         //for (int i = 0; i <= 10; i++)
         //{
         //   list.Add(i * i);
         //}
         //Console.WriteLine(String.Join(" ", list));



         //var list = new List<int>();
         //for (int i = 0; i <= 10; i++)
         //{
         //   list.Add(i);
         //}
         //Console.WriteLine(String.Join(" ", list));
         //list.Remove(3); //removes all the 3's
         //list.RemoveAt(list.Count - 1); //deletes the last index

         //Console.WriteLine(String.Join(" ", list));



         string command = Console.ReadLine();
         List<string> commands = new List<string>();

         while (command != "END")
         {
            commands.Add(command);
            command = Console.ReadLine();

            commands.Insert(2, "GO"); //inserts a new command "GO" on the 2nd index --> works slowly
         }


         //int N = int.Parse(Console.ReadLine());
         //List<int> integersList = new List<int>();
         //List<int> primeNumbersList = new List<int>();

         //for (int i = 0; i < N; i++)
         //{
         //   integersList.Add(i);
         //}
         //for (int i = 0; i < integersList.Count; i++)
         //{
         //   if (integersList[i] != 0 && integersList[i] != 1)
         //   {
         //      if (integersList[i] == 2)
         //      {
         //         primeNumbersList.Add(integersList[i]);
         //         continue;
         //      }
         //      else
         //      {
         //         bool isPrime = true;
         //         for (int j = 2; j <= Math.Sqrt(integersList[i]); j++)
         //         {
         //            if (integersList[i] % j == 0)
         //            {
         //               isPrime = false; break;
         //            }
         //         }
         //         if (isPrime)
         //         {
         //            primeNumbersList.Add(integersList[i]);
         //         }
         //      }
         //   }
         //}
         //Console.WriteLine(primeNumbersList.Max());

      }
   }
}
