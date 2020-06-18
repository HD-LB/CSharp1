using System;


namespace Test
{
    class Test
    {
        private static int length;

        static void Main()
        {

            //int n = int.Parse(Console.ReadLine());

            //int factorial = 1;
            ////int timesTwo = 2 * n;

            //for (int i = 1; i <=(2 * n); i++)
            //{
            //   factorial*= i;
            //}
            //Console.WriteLine(factorial);

            //int n = int.Parse(Console.ReadLine());
            //double min = double.MinValue;
            //double max = double.MaxValue;
            //double sum = 0;


            //int[] numbers = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());

            //    min = Math.Min(min, n); 
            //    max = Math.Min(max, n);
            //    sum += numbers[i];
            //}

            //Console.WriteLine("min = {0:F2}", min);
            //Console.WriteLine("max = {0:F2}", max);
            //Console.WriteLine("sum = {0:F2}", sum);


            //double average = sum / n;
            //Console.WriteLine("avg = {0:F2}", average);

            int a = 1;
            int b = 2;
            Console.WriteLine(a == --b && a == b++);
            Console.WriteLine(a == --b || a == b++);
            Console.WriteLine(a == --b && b == a++);


            int[] intArray = { 1, 2, 3, 4, 5 };

            //for (int i = 1; i < intArray.Length; i++) ////Yes
            //{
            //    intArray[i] += intArray[i - 1];
            //}

            //int sum = 0; ////No
            //foreach (var item in intArray)
            //{
            //    sum += item;
            //}


            //int sum = 0; //Yes
            //for (int i = 0; i < intArray.Length;)
            //{
            //    sum += intArray[i];
            //    intArray[i++] = sum;
            //}


            for (int i = 0; i < intArray.Length; i++) ////No
            {
                intArray[i] += intArray[i];
            }

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}