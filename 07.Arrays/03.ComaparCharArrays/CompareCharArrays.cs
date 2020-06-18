//Write a program that compares two  char arrays lexicographically(letter by letter).

//Input
//•On the first line you will receive the first char array as a string
//•On the second line you will receive the second char array as a string

//Output
//•Print < if the first array is lexicographically smaller
//•Print > if the second array is lexicographically smaller
//•Print = if the arrays are equal

//Constraints
//•1 <= size of arrays <= 128


using System;

namespace _03.ComaparCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().ToCharArray(); //read first array
            char[] secondArray = Console.ReadLine().ToCharArray(); // read second arrey
            bool areEqaul = true;

           
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray.Length == secondArray.Length)
                {
                    areEqaul = true;
                    Console.WriteLine("=");
                }
                else if (firstArray.Length > secondArray.Length)
                {
                   // areEqaul = false;
                    Console.WriteLine(">");
                }
                else
                {
                    //areEqaul = false;
                    Console.WriteLine("<");
                }
            }  
                     
        }        
    }
}

