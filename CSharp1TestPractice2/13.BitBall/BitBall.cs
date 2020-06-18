using System;

//http://telerikacademy.com/Courses/LectureResources/Video/5469/Exam-preparation-Bit-Ball-%d0%9f%d0%b5%d0%bd%d0%ba%d0%b0
//http://bgcoder.com/Contests/42/Telerik-Academy-Exam-1-28-Dec-2012

//   Problem 5 – Bit Ball
//The life in Bitlandia is monotonous and boring.The only thing that makes the bits happy is the game of Bit ball.It’s a simple game, similar to football, in which two teams of eleven bits play against each other.Let’s refer to the teams as “Top” team and “Bottom” team.The playground is a grid of 8x8 cells, in which a zero denotes an empty cell, and one denotes a player.
//You will receive information about the field as a list of 16 bytes (positive integers in the range [0…255]) n0, n1, …, n15.The bits of the first 8 numbers(n0, n1, …, n7) denote the positions of the players from the “Top” team and they will contain a total of eleven bits with a value of one in their binary representations.The same applies for the second 8 numbers(n8, n9, …, n15), except that they denote the positions of the “Bottom” team players.For example the bits of n0 and the bits of n8 represent the first row of the field, the bits of n1 and n9 represent the second row and so on.
//The game consists of several phases:
//1.	First the players of the “Top” team take places on the field. Refer to Table 1. Each “T” in the table represents a player (i.e.a bit with a value of 1).
//2.	Then their opponents take their places.Refer to Table 2. Each “B” in the table represents a player (i.e.a bit with a value of 1).
//3.	 Here comes an interesting part.The bitballers(the players) are very similar to the Bulgarian football players - they are really rough.So, after the placement, if two players appear to be in the same cell, they instantly commit a foul and both receive a red card.Afterwards the cell becomes empty.Refer to Table 3.  Positions[4, 2] and [4, 1] (row 4, columns 2 and 1) are now empty.
//4.	The final part is attacking.Refer to Table 4. Each bit from the “Top” team attacks downwards and each bit from the “Bottom” team attacks upwards.A goal is scored if a bit can get to the end of the field(the bottom end for “Top” team and the top end for the “Bottom” team).  Each bit can only move in straight line and through empty cells(zeros) e.g.the “T” player on position[2, 5], (2 being the row and 5 being the column) can score, because no other player blocks his way to the end, but the “B” player on[6, 6] can’t, because the players on[4, 6], [3, 6] and[1, 6] block his way.
//Today is the important final of the Champions Bit League between the teams of Bitogorec and Bitev Plovdiv. Your task is to find what will be the final score of the game.
//Input
//The input data should be read from the console.
//There will be exactly 16 lines each holding an integer number (n0, n1, …, n15).
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the only output row you should print the final result of the game in the following format “X:Y”, where X is the score of the “Top” team, and “Y” is the score of the “Bottom” team.
//Constraints
//•	The numbers n0, n1, …, n15 are positive integers in the range [0…255]
//•	Two players from the same team will never be in the same cell
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _13.BitBall
{
   class BitBall
   {
      static void Main()
      {
         int fieldLenght = 8;
         int[,] matrix = new int[fieldLenght, fieldLenght];

         for (int i = 0; i < fieldLenght; i++)
         {
            int number = int.Parse(Console.ReadLine());

            for (int j  = 0; j < fieldLenght; j++)
            {
               int bit = (number >> j) & 1;
               if (bit == 1)
               {
                  matrix[i, j] = 1;
               }
            }
         }
        
         for (int i = 0; i < fieldLenght; i++)
         {
            int number = int.Parse(Console.ReadLine());

            for (int j  = 0; j < fieldLenght; j++)
            {
               int bit = (number >> j) & 1;
               if (bit == 1)
               {
                  if (matrix[i,j] == 1)
                  {
                     matrix[i, j] = 0;
                  }
                  else
                  {
                     matrix[i, j] = 2; 
                  }
               }
            }
         }


         int counter1 = 0; //for player 1
         int counter2 = 0; //for player 2

         //B

         for (int col = 0; col < fieldLenght; col++)
         {
            for (int row = 0; row < fieldLenght; row++)
            {
               if (matrix[row, col] == 1)
               {
                  break;
               }
               else if (matrix[row, col] == 2)
               {
                  counter2++;
                  break;
               }
            }
         }

         //T

         for (int col = 0; col < fieldLenght; col++)
         {
            for (int row = fieldLenght - 1; row >= 0; row--)
            {
               if (matrix[row, col] == 1)
               {
                  counter1++;
                  break;
               }
               else if (matrix[row, col] == 2)
               {
                 
                  break;
               }
            }
         }
         Console.WriteLine("{0}:{1}", counter1, counter2);
      }
   }
}
