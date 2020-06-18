using System;

//http://bgcoder.com/Contests/106/Telerik-Academy-Exam-1-6-December-2013-Morning
//http://telerikacademy.com/Courses/Courses/Details/212

//There is a circuit board full of capacitors.The circuit board is 16x16 cells wide and tall.The capacitors are placed in a different manner.The circuit board is divided into two sections of 8x16 cells. In the left section, there is an attached red wire and on the right section – there is a blue one.
//We also took notice that some capacitors are randomly placed, and some are forming figures.The other two privates calculated that if there are exactly 8 capacitors that form a square, having a single empty cell inside of it, they have exactly the right amount of current to sustain the warhead.
//111
//101
//111
//We believe and strongly hope, that if we use an electro-magnetically charged screwdriver to touch the center of this shape of capacitors, we can safely remove them.After removing all such shapes from one section, we can cut the wire that connects to it and the warhead will be dead.
//- Can you do it, Jackson? Can you save as all?
//Instructions from the other two privates:
//You need to create a simulator, that has the following functionalities:
//1.	The command “hover” will not touch the board, but it will gently place the screwdriver on top of a selected location and it must return “*” if there is a capacitor in this location, and “-” if the cell is empty.This command is totally safe and cannot set the nuclear off.
//2.	The command “operate” must place the magnetic screwdriver on the selected location, so you can disturb the electric current of the board at this position and safely remove all the 8 capacitors around it.If there are less than 8 capacitors around the location, you should do nothing,
// There is a risk when performing the “operate” command.If you try to operate on top of a capacitor and touch it directly, the bomb will detonate. Note: There will be no case in which you can remove two shapes with one “operate” command! This means that there will be no case in which capacitors are placed like this:
//11111
//10101
//11111
//3.	For a location of a figure, we take the location of the center cell that is empty.
//Input
//You will receive a random number of commands from the console. Each command will be on a separate line of the console.You must read the commands and print your answer accordingly. The program will finish when the warhead is either disarmed or when it explodes. This will be valid at all times.
//After each command you will receive two integers, which will represent the location in which you must perform the command. The first integer will hold the line of the circuit board, and the second integer will hold the cell, in which you must perform the command.
//Output
//You have different output scenarios, but only one will be valid in a given situation.
//If you cut the red wire and there are no square shapes with a single empty cell in them in the left sector of the circuit board, the warhead will be disarmed.In this case you need to print 2 lines.On the first one you must say how many shapes with exactly 8 capacitors and a single empty cell in the middle are there on the other side of the board.On the second one you must type “disarmed”.
//If you cut the blue wire, you need to do the same, but in reverse.
//If you hit a capacitor, the bomb will detonate instantaneously.In this case you need to print 3 lines.On the first one you must print “missed”, on the second one you should print the number of shapes with 8 capacitors with a single empty cell inside for both sections, and on the third one you must print “BOOM”.
//If you cut a wire, but not all shapes of 8 capacitors with a single empty cell are removed from the current section of the board, the warhead will detonate instantaneously.In this case you must print 2 lines.On the first one you must print the number of these shapes in the current section, not the opposite one. Meaning if you cut the red wire, you must look at the left sector, and vise versa.On the second line you must print “BOOM”.
//Only one of these scenarios will be valid for the given situation.You cannot have more than one of these in a single case.
//Constraints
//•	The circuit board of the warhead will always be 16x16.
//•	The only shape that you need and can remove is a shape of 8 capacitors with a single empty space, or:
//111
//101
//111
//None of the other shapes matters, and only this shape can be removed by the “operate” command.
//•	The integers for line and cell will always be valid, meaning 0 – 15 inclusive.
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

namespace _28.Warhead
{
   class Warhead
   {
      static void Main()
      {
         int[,] board = new int[16, 16];

         for (int i = 0; i < 16; i++)
         {
            string currentLine = Console.ReadLine();
            for (int j = 0; j < 16; j++)
            {
               char currentSymbol = currentLine[j];
               board[i, j] = currentSymbol - '0';
            }

         }

         while (true)
         {
            string currentOperation = Console.ReadLine();

            if (currentOperation == "cut")
            {
               string wire = Console.ReadLine();
               if (wire == "blue")
               {

                  int countBlue = 0; 
                  int countRed = 0;


                  for (int row = 1; row < 15; row++)
                  {
                     for (int col = 1; col < 8; col++)
                     {
                        int currentRow = row;
                        int currentCol = col;


                        int aboveRow = row - 1;
                        int belowRow = row + 1;

                        int beforeCol = col - 1;
                        int afterCol = col + 1;

                        bool topLeft = false;
                        bool topMiddle = false;
                        bool topRight = false;
                        bool currentRight = false;
                        bool currentLeft = false;
                        bool bottomLeft = false;
                        bool bottomMiddle = false;
                        bool bottomRight = false;

                        //check if all are 1
                        if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, beforeCol] == 1)
                        {
                           topLeft = true;
                        }

                        if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                        {
                           topMiddle = true;
                        }

                        if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                        {
                           topRight = true;
                        }

                        if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                        {
                           currentLeft = true;
                        }

                        if (afterCol < 16 && board[currentRow, afterCol] == 1)
                        {
                           currentRight = true;
                        }

                        if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                        {
                           bottomLeft = true;
                        }

                        if (belowRow < 16 && board[belowRow, currentCol] == 1)
                        {
                           bottomMiddle = true;
                        }

                        if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                        {
                           bottomRight = true;
                        }


                        // if  all are 1 turn them into 0
                        if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                        {
                           countRed++;
                        }
                     }

                  }
                  Console.WriteLine(countRed);
                  Console.WriteLine("desarmed");                  
               }
               else
               {
                  int countRed = 0;


                  for (int row = 1; row < 15; row++)
                  {
                     for (int col = 8; col < 15; col++)
                     {
                        int currentRow = row;
                        int currentCol = col;


                        int aboveRow = row - 1;
                        int belowRow = row + 1;

                        int beforeCol = col - 1;
                        int afterCol = col + 1;

                        bool topLeft = false;
                        bool topMiddle = false;
                        bool topRight = false;
                        bool currentRight = false;
                        bool currentLeft = false;
                        bool bottomLeft = false;
                        bool bottomMiddle = false;
                        bool bottomRight = false;

                        //check if all are 1
                        if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, beforeCol] == 1)
                        {
                           topLeft = true;
                        }

                        if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                        {
                           topMiddle = true;
                        }

                        if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                        {
                           topRight = true;
                        }

                        if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                        {
                           currentLeft = true;
                        }

                        if (afterCol < 16 && board[currentRow, afterCol] == 1)
                        {
                           currentRight = true;
                        }

                        if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                        {
                           bottomLeft = true;
                        }

                        if (belowRow < 16 && board[belowRow, currentCol] == 1)
                        {
                           bottomMiddle = true;
                        }

                        if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                        {
                           bottomRight = true;
                        }


                        // if  all are 1 turn them into 0
                        if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                        {
                           countRed++;
                        }
                     }

                  }

                  if (countRed == 0)
                  {
                     Console.WriteLine(countRed);
                     Console.WriteLine("desarmed");

                  }
                  else
                  {

                  }
                 
               }

               break;
            }

            if (currentOperation == "hover" || currentOperation == "operate")
            {
               int currentRow = int.Parse(Console.ReadLine());
               int currentCol = int.Parse(Console.ReadLine());

               if (currentOperation == "hover")
               {
                  int currentNumber = board[currentRow, currentCol];
                  if (currentNumber == 1)
                  {
                     Console.WriteLine('*');
                  }
                  else
                  {
                     Console.WriteLine('-');
                  }
               }

               if (currentOperation == "operate")
               {
                  int currentNumber = board[currentRow, currentCol];

                  if (currentNumber == 1)
                  {
                     Console.WriteLine("missed");

                     int count = 0;


                     for (int row = 1; row < 15; row++)
                     {
                        for (int col = 1; col < 15; col++)
                        {

                           int aboveRow = row - 1;
                           int belowRow = row + 1;

                           int beforeCol = col - 1;
                           int afterCol = col + 1;

                           bool topLeft = false;
                           bool topMiddle = false;
                           bool topRight = false;
                           bool currentRight = false;
                           bool currentLeft = false;
                           bool bottomLeft = false;
                           bool bottomMiddle = false;
                           bool bottomRight = false;

                           //check if all are 1
                           if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, beforeCol] == 1)
                           {
                              topLeft = true;
                           }

                           if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                           {
                              topMiddle = true;
                           }

                           if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                           {
                              topRight = true;
                           }

                           if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                           {
                              currentLeft = true;
                           }

                           if (afterCol < 16 && board[currentRow, afterCol] == 1)
                           {
                              currentRight = true;
                           }

                           if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                           {
                              bottomLeft = true;
                           }

                           if (belowRow < 16 && board[belowRow, currentCol] == 1)
                           {
                              bottomMiddle = true;
                           }

                           if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                           {
                              bottomRight = true;
                           }


                           // if  all are 1 turn them into 0
                           if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                           {
                              count++;
                           }
                        }

                     }

                     if (count == 0)
                     {
                        Console.WriteLine(count);
                        Console.WriteLine("desarmed");

                     }
                     else
                     {

                     }


                     Console.WriteLine(count);
                     Console.WriteLine("BOOM");
                     break;
                  }
                  else
                  {
                     int aboveRow = currentRow - 1;
                     int belowRow = currentRow + 1;

                     int beforeCol = currentCol - 1;
                     int afterCol = currentCol + 1;

                     bool topLeft = false;
                     bool topMiddle = false;
                     bool topRight = false;
                     bool currentRight = false;
                     bool currentLeft = false;
                     bool bottomLeft = false;
                     bool bottomMiddle = false;
                     bool bottomRight = false;

                     //check if all are 1
                     if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, beforeCol] == 1)
                     {
                        topLeft = true;
                     }

                     if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                     {
                        topMiddle = true;
                     }

                     if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                     {
                        topRight = true;
                     }

                     if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                     {
                        currentLeft = true;
                     }

                     if (afterCol < 16 && board[currentRow, afterCol] == 1 )
                     {
                        currentRight = true;
                     }

                     if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                     {
                        bottomLeft = true;
                     }

                     if (belowRow < 16 && board[belowRow, currentCol] == 1)
                     {
                        bottomMiddle = true;
                     }

                     if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                     {
                        bottomRight = true;
                     }


                     // if  all are 1 turn them into 0
                     if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                     {
                        for (int row = aboveRow; row <= belowRow ; row++) 
                        {
                           for (int col = beforeCol; col <= afterCol; col++)
                           {
                              board[row, col] = 0;
                           }
                        }
                     }
                  }
               }

            }
         }




         //Console.WriteLine();

         //for (int i = 0; i < 16; i++)
         //{
         //   for (int j = 0; j < 16; j++)
         //   {
         //      Console.Write(board[i, j]);
         //   }
         //   Console.WriteLine();

         //}

      }
   }
}
