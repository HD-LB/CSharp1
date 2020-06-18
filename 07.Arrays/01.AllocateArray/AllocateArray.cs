//Write a program that allocates array of N integers, initializes each element by its index multiplied by  5  and the prints the obtained array on the console.

//Input
//•On the only line you will receive the number N

//Output
//•Print the obtained array on the console. ◦Each number should be on a new line


//Constraints
//•1 <= N <= 20
//•N will always be a valid integer number

//https://www.youtube.com/watch?v=rY43orFX-Dg



using System;


namespace _01.AllocateArray
{
   class AllocateArray
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         int[] array = new int[n];
         for (int i = 0; i < n; i++)
         {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
            //Console.WriteLine(string.Join(", ", array));
         }
      }
   }
}
