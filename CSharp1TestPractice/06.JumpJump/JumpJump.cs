using System;

//The instructions

//As mentioned above, the instructions are a single string. The instructions can contain digits(0-9) and the party symbol '^'.
//•You will start jumping from the first symbol of the instructions(at position 0).
//•If you jump on an even digit, do the following: ◦Take it's value P as a number('2' is 2, '4' is 4 and so on)
//◦Jump P positions forward

//•If you jump on an odd digit ◦Take it's value P as a number('1' is 1, '3' is 3 and so on)
//◦Jump P positions backwards

//•If you jump on a '0'(zero), you pass out because you've drank too much alchohol ◦Print  Too drunk to go on after POSITION! , where POSITION is the index at which you jumped on the '0'
//◦Stop jumping

//•If you jump on '^'(party symbol), you did some good jumping ◦Print Jump, Jump, DJ Tomekk kommt at POSITION! , where POSITION is the index at which you jumped on the party symbol '^'
//◦Stop jumping

//•If you jump outside the boundaries of the instructions, you fall off the dancefloor ◦Print Fell off the dancefloor at POSITION! , where POSITION is the index at which you jumped you're out of the instructions
//◦Stop jumping


//Input
//•The input will consist of a single line - the instructions how to jump.

//Output
//•Your output should always be a single line.The content of that line is described in the section The instructions above.

//Constraints
//•The instructions string will never contain more than 100 symbols.
//•The instructions string will always only digits and party symbols '^'.
//•You will never jump in loops.Two examples of loops: ◦ 211  - 2 -> 1 -> 1 -> 2 -> 1 -> 1 -> 2 ... and so on forever
//◦ 212^3^  - 2 -> 2 -> 3 -> 1 -> 2 -> ... and so forever



namespace _06.JumpJump
{
   class JumpJump
   {
      static void Main()
      {
         string instructions = Console.ReadLine();
         string message = "Fell off the dancefloor at {0}!";

         int index = 0;
         while (index >= 0 && index < instructions.Length) // if jumping to the left (>=0)
         {
            char ch = instructions[index];
            int num = ch - '0'; // to get a number

            if (ch == '^' )
            {
               message = "Jump, Jump, DJ Tomekk kommt at {0}!";
               break;
            }
            else if (num == 0)
            {
               message = "Too drunk to go on after {0}!";
               break;
            }
            else if (num % 2 == 0)
            {
               index += num; 
            }
            else if (num % 2 == 1)
            {
               index -= num;
            }
         }
         Console.WriteLine(message, index);
      }
   }
}
