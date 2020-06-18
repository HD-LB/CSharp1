using System;

namespace Practice
{
   class Practice
   {
      static void Main()
      {
         //int[] numbers = { 1, 2, 3, 4, 5 };
         //int n = numbers.Length;
         //int[] reversedNumbers = new int[n];

         //for (int i = 0; i < n; i++)
         //{
         //   reversedNumbers[i] = numbers[n - 1 - i];  // n-1 is the last number, because it starts from 0
         //}

         //Console.WriteLine("Numbers: ");
         //for (int i = 0; i < n; i++)
         //{
         //   Console.WriteLine(numbers[i]);
         //}

         //Console.WriteLine("Reversed Numbers: ");
         //for (int i = n - 1; i >= 0; i--)
         //{
         //   Console.WriteLine(numbers[i]);
         //}




         //int n = int.Parse(Console.ReadLine()); //reads a number from the Console
         //int[] numbers = new int[n]; // we don't know how many numbers the user will enter
         //for (int i = 0; i < n; i++)
         //{
         //   numbers[i] = int.Parse(Console.ReadLine());
         //}

         //int sum = 0;
         //for (int i = 0; i < n; i++)
         //{
         //   sum += numbers[i];
         //}
         //Console.WriteLine(sum);

         //for (int i = 0; i < n; i++)
         //{
         //   Console.Write("{0}{1}", numbers[i], i == 1 ? '\n' : ' '); // when we don't want space afront and after the numbers
         //   Console.WriteLine(String.Join(" ", numbers)); // also puts space between the numbers
         //   Console.WriteLine(String.Join(" + ", numbers) + " = " + sum);
         //}




         //Is an Array symmetric?

         //int[] numbers = { 1, 2, 3, 4, 7, 2, 1 };

         //int leftIndex = 0;
         //int rightIndex = numbers.Length - 1;
         //bool symmetric = true;

         //while (leftIndex < rightIndex)
         //{
         //   if (numbers[leftIndex] != numbers[rightIndex])
         //   {
         //      symmetric = false;
         //      break;
         //   }
         //   ++leftIndex; // so the indexes move towards the middle
         //   --rightIndex;

         //}
         //if (symmetric)
         //{
         //   Console.WriteLine("Array is symmetric.");
         //}
         //else
         //{
         //   Console.WriteLine("Array is NOT symmetric.");
         //}



         //char[] symbols = "I am already here.".ToCharArray();
         //Console.WriteLine(String.Join("-", symbols));
         //Console.WriteLine(symbols.Length);

         //char[] reversedSymbols = new char[symbols.Length];
         //for (int i = symbols.Length - 1; i >= 0; i--)
         //{
         //   reversedSymbols[reversedSymbols.Length - 1 - i] = symbols[i];           
         //}
         //Console.WriteLine(String.Join(string.Empty,reversedSymbols));




         //var array = new int[0];
         //int count = 0;

         //for (int i = 0; i < 100; i++)
         //{

         //    if (array.Length == 0)
         //    {
         //        array = new int[4]; //new array with 4 elements
         //    }
         //    else if (count == array.Length)
         //    {
         //        int newSize = array.Length * 2; //making an array that is twice bigger
         //        var newArray = new int[newSize];
         //        for (int j = 0; j < array.Length; j++) // copping the old array into the new one
         //        {
         //            newArray[j] = array[j];
         //        }
         //        array = newArray;
         //    }
         //    array[count] = i; //i is the value we Add()
         //    ++count;
         //}
         //Console.WriteLine(string.Join(" ", array));



         //int[] arr = { 1, 2, 3, 4, 5 };
         //int[] arr2 = (int[])arr.Clone(); //copping an array

         //arr[2] = 100;
         //Console.WriteLine(string.Join(" ", arr));
         //Console.WriteLine(string.Join(" ", arr2));


         //char[] symbols = { 'a', 'b', 'c', 'd', 'e' };
         //char[] copiedSymbols = new char[symbols.Length];
         //Array.Copy(symbols, copiedSymbols, symbols.Length);//what has to be copied, where and how long is it

         //Console.WriteLine(string.Join(", ", copiedSymbols));



         //string numbers = " 1 2 54 89"; //takes the space between the numbers
         //string[] numStr = numbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);





         //   //MergeSort
         //   //https://www.youtube.com/watch?v=rY43orFX-Dg

         int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };

         arr = MergeSort(arr); //name of the Method is "MergeSort" (PascalCase)--> CTRL + .
         Console.WriteLine(string.Join(", ", arr));

      }

      private static int[] MergeSort(int[] arr)
      {
         if (arr.Length <= 1)
         {
            return arr; //this is the bottom of the recursion
         }

         int middle = arr.Length / 2; //splitting the Array in two parts
         int[] left = new int[middle];
         int[] right = new int[arr.Length - middle];

         for (int i = 0; i < arr.Length; i++)
         {
            if (i < middle)
            {
               left[i] = arr[i]; //if the element is < middle point, put the element on the left side
            }
            else
            {
               right[i - middle] = arr[i];
            }
         }
         left = MergeSort(left);
         right = MergeSort(right);


         return Merge(left, right); //Ctrl + .
      }

      private static int[] Merge(int[] left, int[] right)
      {
         int[] result = new int[left.Length + right.Length];
         int i, j;
         for (i = 0, j = 0; i < left.Length && j < right.Length;)
         {
            if (left[i] < right[j])
            {
               result[i + j] = left[i];
               i++;
            }
            else
            {
               result[i + j] = right[j];
               j++;
            }
         }


         for (; i < left.Length; i++)
         {
            result[i + j] = left[i];
         }
         for (; j < right.Length; j++)
         {
            result[i + j] = right[j];
         }
         return result;

      }



      
   }
}
