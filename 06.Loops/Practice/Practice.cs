using System;
using System.Numerics;

namespace Practice
{
    class Practice
    {
        static void Main()
        {
            //int num = int.Parse(Console.ReadLine());
            //ulong sum = 0;
            //uint counter = 1;

            //while (counter <= num)
            //{
                
            //    sum += counter;
            //    counter++;
            //}
            
            //Console.WriteLine(sum);

            //int min = int.Parse(Console.ReadLine());
            //int max = int.Parse(Console.ReadLine());

            //int suma = 0;
            //int counter1 = min;

            //while (counter1 <= max)
            //{
            //    suma += counter1;
            //    counter1++;
            //}
            //Console.WriteLine(suma);


           
            //BigInteger a = int.Parse(Console.ReadLine()); //add System.Numerics;

            //BigInteger product = 1;
            //while (a > 0 )
            //{
            //    product *= a;
            //    a--;
            //}
            //Console.WriteLine(product);



            //int n = int.Parse(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    if ((i % a == 0) && (i % b == 0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //for (int i = 5; i < 50; i+=10)
            //{
            //    Console.Write(i + " ");// print the numbers on one line
            //}




            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            Console.WriteLine(result);


            

            //int m = int.Parse(Console.ReadLine());

            //for (int row = 0; row <= m; row++)
            //{
            //    for (int col = 0; col < row; col++)
            //    {
            //        Console.Write(col + " ");// vmesto col, printirame '*'
            //    }
            //    Console.WriteLine();
            //}




            //int min = int.Parse(Console.ReadLine());
            //int max = int.Parse(Console.ReadLine());

            //for (int i = min; i < max; i++)
            //{
            //    int devider = 2;
            //    bool isPrime = true;
            //    while (devider < i)
            //    {
            //        if (i % devider == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //        devider++;

            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

        }
    }
}
