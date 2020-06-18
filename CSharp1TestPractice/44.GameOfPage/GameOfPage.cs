using System;

//http://bgcoder.com/Contests/107/Telerik-Academy-Exam-1-6-December-2013-Evening
//http://telerikacademy.com/Courses/LectureResources/Video/5825/%d0%97%d0%b0%d0%b4%d0%b0%d1%87%d0%b0-5-Game-of-Page-%d0%94%d0%be%d0%bd%d1%87%d0%be

//Here are the rules of the game:
//Page is holding a square tray of cookies.Sometimes it is full of cookies, and sometimes there are just a few.There are also cookies that are broken and even single cookie crumbs here and there.You cannot buy broken cookies or crumbs - the only thing you can buy is a whole cookie.The whole cookie looks like this:
//111
//111
//111
//All other variations will be considered as broken.If there is a single one (1) and nothing around, it will be considered a crumb.The center of the cookie will be considered the second one (1) on the second row.
//How you play the game
//Page will show you her tray and she will start asking you questions.Her tray is a square one and it can be divided into 16 rows that have 16 cells in them.She will ask you for a specific location by first giving you an integer for the row, and then an integer for the col. If she asks you “what is” and in the location is the center of a cookie, you must say “cookie”. If it is not the center of a cookie, you must say either “broken cookie” or a “cookie crumb”. If she asks you to “buy” the location, you must buy it and she will give it to you.If there is something in the location, but it is not a cookie you must say “page”. If there is nothing in the location you must say “smile”. She can also ask you if you want to buy something on a given location.If it is a cookie, you must take it from the tray and later pay for it.If the given location is not empty, but is also not the center of a cookie you must say “page”.
//After the game is done, she will ask you to pay her for the cookies.
//The cost for each cookie is $1.79.
//Input
//On the first 16 lines you will receive the current tray lines as sequences of 1 and 0.
//Afterwards Page will start asking you questions.She can ask you three things. “what is” and “buy” will both be followed by two lines that state the location she asks you about.On the first line she will tell you the row, and on the second one – the column.
//The third thing she can ask you is “paypal”. This will end the game and you must pay her for the cookies that she gave you.
//Note
//It is possible for Page to cut a cookie, if it is too big.
//Output
//You must respond and print the corresponding answer for the questions that Page is asking you. These questions are going to be given a random number of times.
//On the last line you must pay Page, by printing your current check for the cookies.
//Constraints
//•	The cookie tray of Page will always be 16x16.
//•	The locations she asks you about will always be inside the tray 0-15 for both row and col.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _44.GameOfPage
{
   class GameOfPage
   {
      static void Main()
      {

         string commandEnd = "paypal";
         string commandBuy = "buy";
         string commandWhatIs = "what is";
         double cookiePrice = 1.79;



         int row0 = Convert.ToInt32(Console.ReadLine(), 2);
         int row1 = Convert.ToInt32(Console.ReadLine(), 2);
         int row2 = Convert.ToInt32(Console.ReadLine(), 2);
         int row3 = Convert.ToInt32(Console.ReadLine(), 2);
         int row4 = Convert.ToInt32(Console.ReadLine(), 2);
         int row5 = Convert.ToInt32(Console.ReadLine(), 2);
         int row6 = Convert.ToInt32(Console.ReadLine(), 2);
         int row7 = Convert.ToInt32(Console.ReadLine(), 2);
         int row8 = Convert.ToInt32(Console.ReadLine(), 2);
         int row9 = Convert.ToInt32(Console.ReadLine(), 2);
         int row10 = Convert.ToInt32(Console.ReadLine(), 2);
         int row11 = Convert.ToInt32(Console.ReadLine(), 2);
         int row12 = Convert.ToInt32(Console.ReadLine(), 2);
         int row13 = Convert.ToInt32(Console.ReadLine(), 2);
         int row14 = Convert.ToInt32(Console.ReadLine(), 2);
         int row15 = Convert.ToInt32(Console.ReadLine(), 2);

         int cookieSold = 0;

         while (true)
         {
            string command = Console.ReadLine();

            if (command == commandEnd)
            {
               break;
            }


            int row = int.Parse(Console.ReadLine());
            int col = 15 - int.Parse(Console.ReadLine()); // the columns are counted from right to left

            int upperRow = 0;
            int middleRow = 0;
            int lowerRow = 0;

            switch (row)
            {
               case 0: upperRow = 0; middleRow = row0; lowerRow = row1; break;
               case 1: upperRow = row0; middleRow = row1; lowerRow = row2; break;
               case 2: upperRow = row1; middleRow = row2; lowerRow = row3; break;
               case 3: upperRow = row2; middleRow = row3; lowerRow = row4; break;
               case 4: upperRow = row3; middleRow = row4; lowerRow = row5; break;
               case 5: upperRow = row4; middleRow = row5; lowerRow = row6; break;
               case 6: upperRow = row5; middleRow = row6; lowerRow = row7; break;
               case 7: upperRow = row6; middleRow = row7; lowerRow = row8; break;
               case 8: upperRow = row7; middleRow = row8; lowerRow = row9; break;
               case 9: upperRow = row8; middleRow = row9; lowerRow = row10; break;
               case 10: upperRow = row9; middleRow = row10; lowerRow = row11; break;
               case 11: upperRow = row10; middleRow = row11; lowerRow = row12; break;
               case 12: upperRow = row11; middleRow = row12; lowerRow = row13; break;
               case 13: upperRow = row12; middleRow = row13; lowerRow = row14; break;
               case 14: upperRow = row13; middleRow = row14; lowerRow = row15; break;
               case 15: upperRow = row14; middleRow = row15; lowerRow = 0; break;

            }

            int cookeiCenter = 1 << col; //mask

            bool isCookieCrumb = (middleRow & cookeiCenter) != 0; // the middle is 1, which is different than 0
            bool isBrockenCookie =

                ((middleRow & (1 << col)) != 0) && ( //the middle has to be 1 and one of the following has to have 1

               //upper row 
               ((upperRow & (1 << (col + 1))) != 0) || //upper left diagonal
               ((upperRow & (1 << col)) != 0) || //upper center
               ((upperRow & (1 << (col - 1))) != 0) || //upper right diagonal

            //middle row
               ((middleRow & (1 << (col + 1))) != 0) ||

               ((middleRow & (1 << (col - 1))) != 0) ||

               //lower row
               ((lowerRow & (1 << (col + 1))) != 0) || //lower left diagonal
               ((lowerRow & (1 << col)) != 0) || //lower center
               ((lowerRow & (1 << (col - 1))) != 0) //lower right diagonal
               );

            bool isWholeCookie =
                ((middleRow & (1 << col)) != 0) && ( //the middle has to be 1 and all of the following has to have 1

               //upper row 
               ((upperRow & (1 << (col + 1))) != 0) && //upper left diagonal
               ((upperRow & (1 << col)) != 0) && //upper center
               ((upperRow & (1 << (col - 1))) != 0) && //upper right diagonal

            //middle row
               ((middleRow & (1 << (col + 1))) != 0) &&

               ((middleRow & (1 << (col - 1))) != 0) &&

               //lower row
               ((lowerRow & (1 << (col + 1))) != 0) && //lower left diagonal
               ((lowerRow & (1 << col)) != 0) && //lower center
               ((lowerRow & (1 << (col - 1))) != 0) //lower right diagonal
               );

            if (command == commandWhatIs)
            {
               if (isWholeCookie)
               {
                  Console.WriteLine("cookie");
               }
               else if (isBrockenCookie)
               {
                  Console.WriteLine("broken cookie");
               }
               else if (isCookieCrumb)
               {
                  Console.WriteLine("cookie crumb");
               }
               else
               {
                  Console.WriteLine("smile");
               }

            }

            else if (command == commandBuy)
            {
               if (isWholeCookie)
               {
                  ++cookieSold;

                  //clear the cookie
                  //remove cookie bits from the rows
                  upperRow ^= 1 << (col - 1);
                  upperRow ^= 1 << (col);
                  upperRow ^= 1 << (col + 1);

                  middleRow ^= 1 << (col - 1);
                  middleRow ^= 1 << (col);
                  middleRow ^= 1 << (col + 1);


                  lowerRow ^= 1 << (col - 1);
                  lowerRow ^= 1 << (col);
                  lowerRow ^= 1 << (col + 1);

                  switch (row)
                  {
                     case 0:                  row0 = middleRow; row1 = lowerRow; break;
                     case 1: row0 = upperRow; row1 = middleRow; row2 = lowerRow; break;
                     case 2: row1 = upperRow; row2 = middleRow; row3 = lowerRow; break;
                     case 3: row2 = upperRow; row3 = middleRow; row4 = lowerRow; break;
                     case 4: row3 = upperRow; row4 = middleRow; row5 = lowerRow; break;
                     case 5: row4 = upperRow; row5 = middleRow; row6 = lowerRow; break;
                     case 6: row5 = upperRow; row6 = middleRow; row7 = lowerRow; break;
                     case 7: row6 = upperRow; row7 = middleRow; row8 = lowerRow; break;
                     case 8: row7 = upperRow; row8 = middleRow; row9 = lowerRow; break;
                     case 9: row8 = upperRow; row9 = middleRow; row10 = lowerRow; break;
                     case 10: row9 = upperRow; row10 = middleRow; row11 = lowerRow; break;
                     case 11: row10 = upperRow; row11 = middleRow; row12 = lowerRow; break;
                     case 12: row11 = upperRow; row12 = middleRow; row13= lowerRow; break;
                     case 13: row12 = upperRow; row13 = middleRow; row14 = lowerRow; break;
                     case 14: row13 = upperRow; row14 = middleRow; row15 = lowerRow; break;
                     case 15: row14 = upperRow; row15 = middleRow;  break;
                  }

               }
               else if (isBrockenCookie || isCookieCrumb)
               {
                  Console.WriteLine("page");
               }
               else if (isCookieCrumb)
               {
                  Console.WriteLine("cookie crumb");
               }
               else
               {
                  Console.WriteLine("smile");
               }

            }
         }
         Console.WriteLine("{0:F2}", cookieSold * cookiePrice);
      }
   }
}
