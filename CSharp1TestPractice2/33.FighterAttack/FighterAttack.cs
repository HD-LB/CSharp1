using System;

//http://telerikacademy.com/Courses/Courses/Details/212
//http://telerikacademy.com/Courses/LectureResources/Video/5480/Exam-preparation-Coordinate-System-Tasks-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8
//http://bgcoder.com/Contests/5/Telerik-Academy-Exam-1-7-Dec-2011-Morning

//A rectangular plant P located in east-west direction is under attack by a fighter aircraft flying over it on the west.When the fighter launches a missile we have its coordinates F. It is assumed that the missile's direction is always straight on the west and the missile always hits the target after a fixed distance D in front of the fighter.
//To simplify our model we assume the land is built of square cells of size 1 x 1 located in east-west direction and each cell has integer Cartesian coordinates { x, y}. In this model the plant can be represented by a rectangular area of cell and the missile always hits some of the square cells (inside or outside of the plant).
//When the missile hits a certain cell, the damage over it is 100%, on the cells staying on the left and on the right of it the damage is 50% and in front of it the damage is 75%. The total damage is sum of the separate damages and can exceed 100%.
//You are given the location of the plant P, the location of the fighter F and the distance D. Write a program that calculates the damage over the plant after the attack. Not that the missile could hits the plant partially of fully or can hit some area outside of the plant and cause no damage.
//At the figure below a plant P, a fighter F, a distance D and the missile hit point are shown along with the damage caused over the cells by the hit. Note that some of the damaged cells are outside of the plant and thus the total damage is 225%:

//Your task is to write a program that calculates the total damage caused after the attack over the plant.
//Input
//The input data should be read from the console. There will be exactly 7 lines holding the integer numbers PX1, PY1, PX2, PY2, FX, FY, and D. The plant P is given by the coordinates of any two of its opposite corners and is non-empty (consists of at least one cell). The location of the fighter is given as cell coordinates FX, and FY and the distance D is given as an integer number.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should consist of a single line holding the total damage given as percentage.
//Constraints
//•	The numbers PX1, PY1, PX2, PY2, FX, FY, and D are all integers in the range [-100 000 … 100 000].
//•	Allowed work time for your program: 1 second.
//•	Allowed memory: 16 MB.


namespace _33.FighterAttack
{
   class FighterAttack
   {
      static void Main()
      {
         int pX1 = int.Parse(Console.ReadLine());
         int pY1 = int.Parse(Console.ReadLine());

         int pX2 = int.Parse(Console.ReadLine());
         int pY2 = int.Parse(Console.ReadLine());

         int fX = int.Parse(Console.ReadLine());
         int fY = int.Parse(Console.ReadLine());

         if (pX1 > pX2)
         {
            int temp = pX1;
            pX1 = pX2;
            pX2 = temp;
         }
         if (pY1 > pY2)
         {
            int temp = pY1;
            pY1 = pY2;
            pY2 = temp;
         }

         int dist = int.Parse(Console.ReadLine());

         int damage = 0;
         fX += dist;

         if (pX1 <= fX && fX <= pX2)
         {
            if (pY1 <= fY && fY <= pY2)
            {
               damage += 100;
            }

            if (pY1 <= fY - 1 && fY - 1 <= pY2)
            {
               damage += 50;
            }
            if (pY1 <= fY + 1 && fY + 1 <= pY2)
            {
               damage += 50;
            }
         }
         if (pX1 <= fX + 1 && fX + 1 <= pX2)
         {
            if (pY1 <= fY && fY <= pY2)
            {
               damage += 75;
            }
         }
         Console.WriteLine("{0}%", damage);


      }
   }
}
