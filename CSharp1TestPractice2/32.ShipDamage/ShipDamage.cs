using System;

//http://telerikacademy.com/Courses/Courses/Details/212
//http://telerikacademy.com/Courses/LectureResources/Video/5480/Exam-preparation-Coordinate-System-Tasks-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8
//http://bgcoder.com/Contests/2/Telerik-Academy-Exam-1-6-Dec-2011-Morning



//Inside the sea(a standard Cartesian /rectangular/ coordinate system) we are given a ship S(a rectangle whose sides are parallel to the coordinate axes), a horizontal line H(the horizon) and three catapults, given as coordinates C1, C2 and C3 that will be used to fire the ship.When the attack starts, each catapult hits a projectile exactly into the positions that are symmetrical to C1, C2 and C3 with respect to the horizon H.When a projectile hits some of the corners of the ship, it causes a damage of 25%, when it hits some of the sides of the ship, the damage caused is 50% and when it hits the internal body of the ship, the damage is 100%. When the projectile hit outside of the ship, there is no damage.The total damage is sum of the separate damages and can exceed 100%.
//At the figure below a sea, a ship S, a line H, three points C1, C2 and C3 and their hit positions are shown:


//Your task is to write a program that calculates the total damage caused after the attack over the ship.
//Input
//The input data should be read from the console.
//There will be exactly 11 lines holding the integer numbers SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, and CY3. The ship S is given by any two of its opposite corners and is non-empty (has positive width and height). The line H is given by its vertical offset.The points C1, C2 and C3 are given as couples of coordinates and cannot overap each other.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//The output should consist of a single line holding the total damage given as percentage.
//Constraints
//•	The numbers SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, and CY3 are all integers between -100 000 and 100 000, inclusive.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _32.ShipDamage
{
   class ShipDamage
   {
      static void Main()
      {
         int sX1 = int.Parse(Console.ReadLine());
         int sY1 = int.Parse(Console.ReadLine());

         int sX2 = int.Parse(Console.ReadLine());
         int sY2 = int.Parse(Console.ReadLine());

         int h = int.Parse(Console.ReadLine());

         int cX1 = int.Parse(Console.ReadLine());
         int cY1 = int.Parse(Console.ReadLine());
         int cX2 = int.Parse(Console.ReadLine());
         int cY2 = int.Parse(Console.ReadLine());
         int cX3 = int.Parse(Console.ReadLine());
         int cY3 = int.Parse(Console.ReadLine());

         cY1 = 2 * h - cY1;
         cY2 = 2 * h - cY2;
         cY3 = 2 * h - cY3;

         if (sX1 > sX2)
         {
            int temp = sX1;
            sX1 = sX2;
            sX2 = temp;
         }

         if (sY1 > sY2)
         {
            int temp = sY1;
            sY1 = sY2;
            sY2 = temp;
         }


         int damage = 0;

         if (sX1 < cX1 && cX1 < sX2 && sY1 < cY1 && cY1 < sY2)
         {
            damage += 100;
         }
         else if (cX1 == sX2 && sY1 < cY1 && cY1 < sY2 ||
                  cX1 == sX1 && sY1 < cY1 && cY1 < sY2 ||
                  cY1 == sY1 && sX1 < cX1 && cX1 < sX2 ||
                  cY1 == sY2 && sX1 < cX1 && cX1 < sX2)
         {
            damage += 50;
         }

         else if (cX1 == sX1 && cY1 == sY1 ||
                  cX1 == sX1 && cY1 == sY2 ||
                  cX1 == sX2 && cY1 == sY1 ||
                  cX1 == sX2 && cY1 == sY2)
         {
            damage += 25;
         }


         if (sX1 < cX2 && cX2 < sX2 && sY1 < cY2 && cY2 < sY2)
         {
            damage += 100;
         }
         else if (cX2 == sX2 && sY1 < cY2 && cY2 < sY2 ||
                  cX2 == sX1 && sY1 < cY2 && cY2 < sY2 ||
                  cY2 == sY1 && sX1 < cX2 && cX2 < sX2 ||
                  cY2 == sY2 && sX1 < cX2 && cX2 < sX2)
         {
            damage += 50;
         }

         else if (cX2 == sX1 && cY2 == sY1 ||
                  cX2 == sX1 && cY2 == sY2 ||
                  cX2 == sX2 && cY2 == sY1 ||
                  cX2 == sX2 && cY2 == sY2)
         {          
            damage += 25;
         }


         if (sX1 < cX3 && cX3 < sX2 && sY1 < cY3 && cY3 < sY2)
         {
            damage += 100;
         }
         else if (cX3 == sX2 && sY1 < cY3 && cY3 < sY2 ||
                  cX3 == sX1 && sY1 < cY3 && cY3 < sY2 ||
                  cY3 == sY1 && sX1 < cX3 && cX3 < sX2 ||
                  cY3 == sY2 && sX1 < cX3 && cX3 < sX2)
         {
            damage += 50;
         }

         else if (cX3 == sX1 && cY3 == sY1 ||
                  cX3 == sX1 && cY3 == sY2 ||
                  cX3 == sX2 && cY3 == sY1 ||
                  cX3 == sX2 && cY3 == sY2)
         {
            damage += 25;
         }

         Console.WriteLine("{0}%", damage);

      }
   }
}
