﻿using System;

//http://bgcoder.com/Contests/93/Telerik-Academy-Exam-1-24-June-2013-Evening
//http://telerikacademy.com/Courses/Courses/Details/212

//Bat’Goiko is a famous Bulgarian builder.He spent most of his life building highways in his country. He was so good at his job that at some point there was no more place to build new highways.Bat’Goiko was very disappointed that he had no more work to do and decided to move to France to find more land for his future projects.Just hours after he landed in Paris, he came up with the bright idea to start building Eifel Towers in order to be more efficient with the space.He took the first plane back to Bulgaria and started building towers.
//After few vain attempts he found out some dependencies in the tower’s width and height. The first one being that, the tower should be at least two times wider than it is tall.And the other one was that the tower should have some crossbeams.  He started placing crossbeams from the top and he also decided that it’s a good idea to put less crossbeams the lower he went in the tower. He put the first one at the (top – 1), the second at(top – 3), the third at(top – 6) and so on till he got a stable tower.
//Your task is to help him improve his work by drawing a realistic model of “Bat’Goiko Tower” by given height(H). 
//Input
//The input data should be read from the console.
//You have an integer number H height of the tower.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Use the “\”, “/”, “-” (dash) characters for the lines and “.” (dot) for the rest.
//Constraints
//•	H will always be a positive number between 2 and 39 inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _37.Bat_GoikoTower
{
   class Program
   {
      static void Main()       
      {

         string tower = @"..../\....
                          .../--\...
                          ../....\..
                          ./------\.
                          /........\
                          ";


         int n = int.Parse(Console.ReadLine());

         int update = 2;
         int rowToHaveDash = 2;


         for (int i = 1; i <= n; i++)
         {
            var middleCharacter = '.';

            if (i == rowToHaveDash)
            {
               middleCharacter = '-';
               rowToHaveDash += update;
               ++update;
            }

            string row = new string('.', n - i) + "/" + new string(middleCharacter, 2*i - 2) + "\\" + new string('.', n - i);
            Console.WriteLine(row);

            // 2n = n - i + 1 + 1 + n - i + X
            //2n = 2n - 2i + 2 + X   :2
            //n = n - i + 1 + X/2
            //X/2 = i - 1
            //x = 2i - 2    count of the '-'
         }
      }
   }
}
