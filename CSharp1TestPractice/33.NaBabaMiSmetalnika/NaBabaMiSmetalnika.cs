using System;

//http://bgcoder.com/Contests/105/Telerik-Academy-Exam-1-5-December-2013-Evening
//http://telerikacademy.com/Courses/Courses/Details/212

//See this mad baba? She is crazy I tell you! But this is life and you are going to be stuck with her for all the lqto, so better pay attention!
//The baba has very izbuhliva personality, so every time you mess up something she smacks your head with her tochilka. She mainly spends her vreme in pletene of sweaters, which she sells to important klienti on the selski market.
//Every sweater has a different sharka, so she needs to calculate how many reda to use of one prejda and how many of some other kind. She figured out a formula that helps her to izchisli the right amount of rows and brimki.
//The formula is as follows: She uses a different smetalo for every sweater, and every smetalo has different number of topchenca. As she plete, she moves the topchenca to the left or right side of the smetaloto.If she makes a mistake she resets the smetaloto by placing all the topchenca on the left most side.
//Once she is done she izchislqva the sum of all the lines and then multiplies them by the broikata of all columns that don’t have any topchenca in them.
//Since you are spending the summer with her, she put you in charge of the smetaloto, but be vnimatelen, because if you opleskash the formula she will mess up the sweater and you will get smacked.Every time she smacks your head some mozuchni cells are dying and you lose a part of your genialnost.
//Quick! Use what mozuk you have left to create a computer program, that can do your rabota for you, before you get so tup that you cannot think straight from getting smacked on the head by this luda baba!
//How the smetalnika works:
//You need to know how wide it needs to be, so that it can calculate the sharkata for the current sweater.Listen to the babata, she will tell you the width at the beginning.After that she will give you 8 positive numbers that you have to magically preobrazuvash into bitwise data and use the bits as topchenca for your smetalnik.
//After this is done she will start giving you commands: Whenever she makes a mistake she will tell you to “reset” the smetaloto, so she can start over.Then you must burzo put all the topchenca to the left most corner.When she tells you to slide “right” or “left”, this means that you need to put your prust on a selected line and position and to slide all the topchenca to the left or to the right most corner of the smetaloto.
//Once she is gotova she will tell you to “stop” and tell her the result.You better do it fast or that brain cells killing smack is coming right at you!
//Input
//The input data should be red from the console.
//On the first line you will be given the width of the smetaloto.
//On the next 8 lines you will be given 8 numbers, one number on each line, so you can use them to understand where to put your topchenca. 
//After that you will receive a random number of commands - “reset”, “right” and “left”. If there is no topchence where she tells you to slide your finger, you must do it either way, since she is a little kiorava, and sometimes misses the right position. When you slide you must always start from where she instructs you and stop when you reach the opposite krai of the smetaloto.
//The program must end when the “stop” command is given.The result must be printed right afterwards.
//Output
//The output data should be printed on the console.
//The output result is the sum of all the lines as numbers multiplied by the number of columns that don’t have any topchenca in them.
//Constraints
//•	The width of the smetaloto will be from 5 to 32 inclusive.
//•	The eight numbers will be from 0 to 2 147 483 647 inclusive.
//•	The line will be from 0 to 7 inclusive.
//•	The prust position will be from -50 to 50 inclusive.
//•	There will be no topchenca outside of the smetaloto at any given time.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.



namespace _33.NaBabaMiSmetalnika
{
   class NaBabaMiSmetalnika
   {
      static void Main()
      {

         //input
         int width = int.Parse(Console.ReadLine());

         long row0 = long.Parse(Console.ReadLine());
         long row1 = long.Parse(Console.ReadLine());
         long row2 = long.Parse(Console.ReadLine());
         long row3 = long.Parse(Console.ReadLine());
         long row4 = long.Parse(Console.ReadLine());
         long row5 = long.Parse(Console.ReadLine());
         long row6 = long.Parse(Console.ReadLine());
         long row7 = long.Parse(Console.ReadLine());


         //logic
         int row, col, bitsCount;
         long mask;
         long bits = 0;
         long newBits = 0;

         bool proceed = true;
         while (proceed)
         {
            //read commands
            string command = Console.ReadLine();


            switch (command)
            {
               case "right":                            //right command
                  row = int.Parse(Console.ReadLine());
                  col = int.Parse(Console.ReadLine());

                  if (col < 0) //make sure, that we don't go outside the frame
                  {
                     col = 0;
                  }
                  if (col > width - 1)
                  {
                     col = width - 1;
                  }

                  //mask
                  mask = 0;
                  for (int i = 0; i < width - col; i++)
                  {
                     mask |= (long)(1 << i);
                     
                     //mask <<= 1;
                     //mask |= 1;
                  }

                  //extract bits & empty row part
                  switch (row)
                  {
                     case 0: bits = row0 & mask; row0 &= ~mask; break;
                     case 1: bits = row1 & mask; row1 &= ~mask; break;
                     case 2: bits = row2 & mask; row2 &= ~mask; break;
                     case 3: bits = row3 & mask; row3 &= ~mask; break;
                     case 4: bits = row4 & mask; row4 &= ~mask; break;
                     case 5: bits = row5 & mask; row5 &= ~mask; break;
                     case 6: bits = row6 & mask; row6 &= ~mask; break;
                     case 7: bits = row7 & mask; row7 &= ~mask; break;
                  }

                  //count bits
                  bitsCount = 0;
                  while (bits > 0)
                  {
                     if ((bits & 1) == 1)
                     {
                        bitsCount++;
                     }
                     bits >>= 1;
                  }

                  //newBits
                  newBits = 0;
                  for (int i = 0; i < bitsCount; i++)
                  {
                     newBits |= (1 << i);
                  }


                  //apply newBits to row
                  switch (row)
                  {
                     case 0: row0 |= newBits; break;
                     case 1: row1 |= newBits; break;
                     case 2: row2 |= newBits; break;
                     case 3: row3 |= newBits; break;
                     case 4: row4 |= newBits; break;
                     case 5: row5 |= newBits; break;
                     case 6: row6 |= newBits; break;
                     case 7: row7 |= newBits; break;
                  }


                  break;

               case "left": //left command
                  break;
                  row = int.Parse(Console.ReadLine());
                  col = int.Parse(Console.ReadLine());


                  if (col < 0)
                  {
                     col = 0;
                  }
                  if (col > width - 1)
                  {
                     col = width - 1;
                  }

                  //mask
                  mask = 0;
                  for (int i = width - col - 1; i < width; i++)
                  {
                       mask |= (long)(1L << i);  //mask <<= 1;
                                                 //mask |= 1;
                  }

                  //extract bits & empty row part
                  switch (row)
                  {
                     case 0: bits = row0 & mask; row0 &= ~mask; break;
                     case 1: bits = row1 & mask; row1 &= ~mask; break;
                     case 2: bits = row2 & mask; row2 &= ~mask; break;
                     case 3: bits = row3 & mask; row3 &= ~mask; break;
                     case 4: bits = row4 & mask; row4 &= ~mask; break;
                     case 5: bits = row5 & mask; row5 &= ~mask; break;
                     case 6: bits = row6 & mask; row6 &= ~mask; break;
                     case 7: bits = row7 & mask; row7 &= ~mask; break;
                  }

                  //count bits
                  bitsCount = 0;
                  while (bits > 0)
                  {
                     if ((bits & 1) == 1)
                     {
                        bitsCount++;
                     }
                     bits >>= 1;
                  }

                  //newBits
                  newBits = 0;
                  for (int i = width - 1; i >= width - bitsCount; i--)
                  {
                     newBits |= (1L << i);
                  }
                  
                  //apply newBits to row
                  switch (row)
                  {
                     case 0: row0 |= newBits; break;
                     case 1: row1 |= newBits; break;
                     case 2: row2 |= newBits; break;
                     case 3: row3 |= newBits; break;
                     case 4: row4 |= newBits; break;
                     case 5: row5 |= newBits; break;
                     case 6: row6 |= newBits; break;
                     case 7: row7 |= newBits; break;
                  }

                  break;  

               case "reset":                   //reset

                  //mask
                  mask = 0;
                  for (int i = 0; i < width; i++)
                  {
                     mask |= (long)(1L << i); //mask <<= 1;
                                              //mask |= 1;
                  }

                  //extract bits & empty row part
                  bits = row0 & mask;
                  row0 &= ~mask;
                  row1 &= ~mask;
                  row2 &= ~mask;
                  row3 &= ~mask;
                  row4 &= ~mask;
                  row5 &= ~mask;
                  row6 &= ~mask;
                  row7 &= ~mask;


                  //count bits
                  bitsCount = 0;
                  while (bits > 0)
                  {
                     if ((bits & 1) == 1)
                     {
                        bitsCount++;
                     }
                     bits >>= 1;
                  }

                  //newBits
                  newBits = 0;
                  for (int i = width - 1; i >= width - bitsCount; i--)
                  {
                     newBits |= (1 << i);
                  }

                  //apply newBits to row
                  row0 |= newBits;
                  row1 |= newBits;
                  row2 |= newBits;
                  row3 |= newBits;
                  row4 |= newBits;
                  row5 |= newBits;
                  row6 |= newBits;
                  row7 |= newBits;
                  
                  break;  

               case "stop": proceed = false; break;  //stop
               default: break;
            }

         }

         //calculations

         long sum = row0 + row1 + row2 + row3 + row4 + row5 + row6 + row7;
         int zeroColCount = 0;
         long colSum = row0 | row1 | row2 | row3 | row4 | row5 | row6 | row7;

         for (int i = 0; i < width; i++)
         {
            if ((colSum & (1 << i)) == 0)
            {
               zeroColCount++;
            }
         }

         //output
         Console.WriteLine(sum * zeroColCount);
      }
   }
}
