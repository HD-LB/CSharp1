using System;

//http://bgcoder.com/Contests/1/CSharp-Fundamentals-2011-2012-Part-1-Sample-Exam
//http://telerikacademy.com/Courses/LectureResources/Video/5454/%d0%9f%d1%80%d0%b8%d0%bc%d0%b5%d1%80%d0%b5%d0%bd-%d0%b8%d0%b7%d0%bf%d0%b8%d1%82-26-%d0%bd%d0%be%d0%b5%d0%bc%d0%b2%d1%80%d0%b8-2012-%d0%9d%d0%b8%d0%ba%d0%b8

//There are two things that cats love most: 1) sleeping and 2) attending beauty contests.The most important thing for each female cat is the contest “Miss Cat”. There are always ten cats that participate in the final round of the contest, numbered 1 to 10. 
//The jury of the contest consists of N people who subjectively decide which cat to vote for. In other words each person votes for just 1 cat that he has most liked, or from whose owner he has received the biggest bribe.The winner of the contest is the cat that has gathered most votes.If two cats have equal votes, the winner of the contest is the one whose number is smaller.
//Your task is to write a computer program that finds the number of the cat that is going to win the contest “Miss cat”
//Input
//The input data is being read from the console.
//The number N is on the first input line.
//An integer between 1 and 10 is written on each of the next N lines(this is the number of the cat)
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data must be printed on the console.
//On the only output line you must print the number of the cat, which has won the contest.
//Constraints
//•	The number N is a positive integer between 1 and 100 000, inclusive.
//•	The numbers of the cats for which the jury votes are positive integer numbers between 1 and 10, inclusive.
//•	Allowed working time for your program: 0.25 second.
//•	Allowed memory: 16 MB.


namespace _02.MissCat2011
{
   class MissCat2011
   {
      static void Main()
      {
         //int n = int.Parse(Console.ReadLine()); //judges


         //int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0; //10 cats

         //for (int i = 1; i <= n; i++)
         //{
         //   byte vote = byte.Parse(Console.ReadLine());

         //   //TODO: check the vote

         //   switch (vote)
         //   {
         //      case 1: c1++; break;
         //      case 2: c2++; break;
         //      case 3: c3++; break;
         //      case 4: c4++; break;
         //      case 5: c5++; break;
         //      case 6: c6++; break;
         //      case 7: c7++; break;
         //      case 8: c8++; break;
         //      case 9: c9++; break;
         //      case 10: c10++; break;

         //   }
         //}
         ////TODO: determine the best cat
         //if (c1 >= c1 && c1 >= c2 && c1 >= c3 && c1 >= c4 && c1 >= c5 && c1 >= c6 && c1 >= c7 && c1 >= c8 && c1 >= c9 && c1 >= c10)
         //{
         //   Console.WriteLine(1);
         //}
         //else if (c2 >= c1 && c2 >= c2 && c2 >= c3 && c2 >= c4 && c2 >= c5 && c2 >= c6 && c2 >= c7 && c2 >= c8 && c2 >= c9 && c2 >= c10)
         //{
         //   Console.WriteLine(2);
         //}
         //else if (c3 >= c1 && c3 >= c2 && c3 >= c3 && c3 >= c4 && c3 >= c5 && c3 >= c6 && c3 >= c7 && c3 >= c8 && c3 >= c9 && c3 >= c10)
         //{
         //   Console.WriteLine(3);
         //}
         //else if (c4 >= c1 && c4 >= c2 && c4 >= c3 && c4 >= c4 && c4 >= c5 && c4 >= c6 && c4 >= c7 && c4 >= c8 && c4 >= c9 && c4 >= c10)
         //{
         //   Console.WriteLine(4);
         //}
         //else if (c5 >= c1 && c5 >= c2 && c5 >= c3 && c5 >= c4 && c5 >= c5 && c5 >= c6 && c5 >= c7 && c5 >= c8 && c5 >= c9 && c5 >= c10)
         //{
         //   Console.WriteLine(5);
         //}
         //else if (c6 >= c1 && c6 >= c2 && c6 >= c3 && c6 >= c4 && c6 >= c5 && c6 >= c6 && c6 >= c7 && c6 >= c8 && c6 >= c9 && c6 >= c10)
         //{
         //   Console.WriteLine(6);
         //}
         //else if (c7 >= c1 && c7 >= c2 && c7 >= c3 && c7 >= c4 && c7 >= c5 && c7 >= c6 && c7 >= c7 && c7 >= c8 && c7 >= c9 && c7 >= c10)
         //{
         //   Console.WriteLine(7);
         //}
         //else if (c8 >= c1 && c8 >= c2 && c8 >= c3 && c8 >= c4 && c8 >= c5 && c8 >= c6 && c8 >= c7 && c8 >= c8 && c8 >= c9 && c8 >= c10)
         //{
         //   Console.WriteLine(8);
         //}
         //else if (c9 >= c1 && c9 >= c2 && c9 >= c3 && c9 >= c4 && c9 >= c5 && c9 >= c6 && c9 >= c7 && c9 >= c8 && c9 >= c9 && c9 >= c10)
         //{
         //   Console.WriteLine(9);
         //}
         //else if (c10 >= c1 && c10 >= c2 && c10 >= c3 && c10 >= c4 && c10 >= c5 && c10 >= c6 && c10 >= c7 && c10 >= c8 && c10 >= c9 && c10 >= c10)
         //{
         //   Console.WriteLine(10);
         //}


         /*

         Arrays:

         int n = int.Parse(Console.ReadLine());

         int[] cats = new int[11];
         for (int i = 1; i <= n; i++) //no cat 0, starts from 1
         {
            byte vote = byte.Parse(Console.ReadLine());
            cats[vote]++;
         }

         int bestCat = 0;
         int bestCatVotes = 0;
         for (int i = 1; i <= 10; i++)
         {
            if (cats[i] > bestCatVotes)
            {
               bestCat = i;
               bestCatVotes = cats[i];
            }
         }
         Console.WriteLine(bestCat);

         */
      }
   }
}
