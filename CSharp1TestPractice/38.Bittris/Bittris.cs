using System;
//Problem description
//You are tasked with implementing Bittris, a slightly modified version of Tetris.It is played on a 4x8 field, with the 4 rows represented by 4 8-bit integers, whose '0' bits represent free cells, and '1' bits - occupied cells.Pieces appear on the top row and fall down until they reach the bottom row or until they cannot move any lower without crashing into occupied cells.


//The pieces are just sequences of '1' bits, represented as 32 bit integers. Their low 8 bits represent the shape of the piece; the high 24 bits do not influence the piece's shape, but are important for the scoring (see below). The pieces cannot be rotated, but they can be shifted left or right before every move. Note that the shifting does not affect the high 24 bits, which means the score for a shape is the same, regardless of whether it has been shifted or not. The shift direction is controlled by the player and occurs immediately before the piece tries to move downward.

//If the shift direction is such that part of the piece would leave the playing field, the command is ignored and the piece simply moves downward.Note that the pieces cannot be shifted on the final row - they land in the position in which they were when they got there.Note also that not all commands need to be used – if the piece has landed before that, they are ignored and the game continues with the next piece.

//When a piece lands (reaches its final position), several things can occur.Normally, the player simply gains points equal to the number of '1' bits in the piece's input integer (including any leading bits that have no relation to its shape). However, if the row in which it ended up has been filled completely (it contains only '1' bits), then the row must be cleared - all rows above it are shifted down by one position, and the score for the move is multiplied by 10.


//If after the piece has landed, the top row contains any '1' bits, the game ends; otherwise the game ends after all pieces in the input have been exhausted.
//Note that it is completely legal to have a piece that covers an entire row; if it lands on the final row, the row will be cleared normally and the game will continue.
//   Input
//The input data should be read from the console.
//On the first line of the standard input, there will be the number N – the total number of commands (creating and shifting pieces) which will be entered.
//For each next group of 4 lines, the following will be true:
//•	The first line will be an integer number – describing the current falling piece
//•	Each of the next 3 lines will contain a single capital letter – 'L', 'D' or 'R', operating on the current falling piece
//o  'L' means "shift left", 'R' means "shift right" and 'D' means just continue down without shifting
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console. On the only output row, you should print the final score of the game.
//Constraints
//	All input integers are non-negative and will fit into 4 bytes.
//	N is divisible by 4 (N%4==0 is always true)
//	Allowed work time for your program: 0.1 seconds.Allowed memory: 16 MB.



namespace _38.Bittris
{
   class Bittris
   {
      static void Main()
      {



      }
   }
}
