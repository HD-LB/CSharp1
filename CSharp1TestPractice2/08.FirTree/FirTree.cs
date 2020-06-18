using System;

//http://bgcoder.com/Contests/2/Telerik-Academy-Exam-1-6-Dec-2011-Morning
//http://telerikacademy.com/Courses/LectureResources/Video/5465/Exam-preparation-Fir-tree-%d0%af%d0%bd%d0%ba%d0%be


//Input
//The input data should be read from the console.
//On the only input line you have an integer number N, showing the height of the tree.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You must print the fir tree on the console.Each row contains only characters "." (point)  or "*" (asterisk).
//The first row should have exactly one "*" in the middle(that is the top of the tree) and each of the next lines two more.
//The last line should have exactly one asterisk in the middle, showing the stem of the tree.
//Constraints
//•	The number N is a positive integer between 4 and 100, inclusive.
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.

/*
.......*.......
......***......
.....*****.....
....*******....
...*********...
..***********..
.*************.
***************
.......*.......

*/



namespace _08.FirTree
{
   class FirTree
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());


         int starCount = 3;
         int dotCount = n - 2;

         string firstLine = new string('.', dotCount) + '*' + new string('.', dotCount);
         Console.WriteLine(firstLine);
         dotCount--;

         for (int i = 1; i < n - 1; i++)
         {
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', starCount));
            Console.Write(new string('.', dotCount));
            Console.WriteLine();
            dotCount--;
            starCount += 2;
         }
         Console.WriteLine(firstLine);
      }
   }
}
