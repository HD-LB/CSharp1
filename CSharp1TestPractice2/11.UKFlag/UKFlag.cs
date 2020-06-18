using System;

//http://bgcoder.com/Contests/43/Telerik-Academy-Exam-1-29-Dec-2012
//http://telerikacademy.com/Courses/LectureResources/Video/5467/Exam-preparation-UK-Flag-%d0%af%d0%bd%d0%ba%d0%be


//Telerik Academy is considering opening a new office in Great Britain.Therefore the whole Trainers team is traveling to the United Kingdom for the important event. They’ve decided that everyone needs to bring the UK flag with him, as a token of respect to the local citizens. Please help them and print some flags in different sizes, so they will be well received. As a little reminder, here it is the flag itself:

//Input
//The input data should be read from the console.
//You have an integer number N (always odd number) showing the width and the height of the flag.The flag will always be a square.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Use the “*” (asterisk) character for the middle, the “\”, “/”, “|” (vertical dash), “-” (dash) characters for the lines and “.” (dot) for the rest.
//Constraints
//•	N will always be a positive odd number between 5 and 79 inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

/*
\...|.../
.\..|../.
..\.|./..
...\|/...
----*----
.../|\...
../.|.\..
./..|..\.
/...|...\

*/




namespace _11.UKFlag
{
   class UKFlag
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());

         int innerDots = n / 2 - 1;
         int outerDots = 0;

         //upper part
         for (int i = 0; i < n / 2; i++)
         {
            Console.Write(new string('.', outerDots));
            Console.Write('\\');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('/');
            Console.Write(new string('.', outerDots));

            outerDots++;
            innerDots--;
            Console.WriteLine();            
         }


         //middle part
         Console.Write(new string('-', n/2));
         Console.Write('*');
         Console.WriteLine(new string('-', n / 2));


         //lower part

         outerDots = n / 2 - 1;
         innerDots = 0;

         for (int i = 0; i < n / 2; i++)
         {
            Console.Write(new string('.', outerDots));
            Console.Write('/');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('\\');
            Console.Write(new string('.', outerDots));

            outerDots--;
            innerDots++;
            Console.WriteLine();           
         }
      }
   }
}
