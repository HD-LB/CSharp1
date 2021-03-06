﻿//Write a program that safely compares two floating-point numbers(double) with precision  eps = 0.000001 .

//Note: Two floating-point numbers  a and  b cannot be compared directly by  a == b because of the nature of the floating-point arithmetic.Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps .


//Input
//•On the first line you will receive the first floating-point number
//•On the second line you will receive the second floating-point number


//Hint: Use double.Parse(Console.ReadLine()) to read input

//Output
//•Print  true  if the numbers are equal or  false  if they are not


using System;

namespace _13ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
           Console.Write("Enter number a: ");
           double a = double.Parse(Console.ReadLine());
           Console.Write("Enter number b: ");
           double b = double.Parse(Console.ReadLine());
           double eps = 0.000001;
           
            if ( a > b)
            {
                if  ( a - b > eps)
                {
                    Console.WriteLine("The two numbers are not equal with percision 0.000001.");
                }
                else
                {
                    Console.WriteLine("The two numbers are equal with percision 0.000001.");
                }
            }
            else if ( b > a)
            {
                if (b - a > eps)
                {
                    Console.WriteLine("The two numbers are not equal with percision 0.000001.");
                }
                else
                {
                    Console.WriteLine("The two numbers are equal with percision 0.000001.");
                }
            }
            
        }
    }
}
