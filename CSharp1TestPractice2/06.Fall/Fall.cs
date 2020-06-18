using System;
using System.Text;

//http://bgcoder.com/Contests/3/CSharp-Fundamentals-2011-2012-Part-1-Test-Exam
//http://telerikacademy.com/Courses/LectureResources/Video/5456/Exam-preparation-Fall-Down-Bitwise-%d0%a2%d0%be%d0%bd%d0%b8-%d0%96%d0%b5%d0%ba%d0%be%d0%b2

//You are given a list of 8 bytes(positive integers in the range [0…255]) n0, n1, …, n7.These numbers represent a square grid consisting of 8 lines and 8 columns.Each cell of the grid could either be empty or full.The first line is represented by the bits of n0, the second – by the bits of n1 and so on, and the last line is represented by the bits of n7.Each bit with value 1 denotes a full cell and each bit with value 0 denotes an empty cell. The lines are numbered from the first (top) to the last(bottom) with the numbers 0, 1, …, 7. The columns are numbered from right to left with the indices 0, 1, …, 7. The figure shows a sample square grid and its representation by a sequence of 8 numbers n0, n1, …, n7:
//	7	6	5	4	3	2	1	0				7	6	5	4	3	2	1	0	
//0									n0 = 0		0									n0 = 0
//1		■							n1 = 64		1									n1 = 0
//2					■				n2 = 8		2									n2 = 0
//3					■				n3 = 8		3									n3 = 0
//4									n4 = 0		4									n4 = 0
//5					■	■			n5 = 12		5					■				n5 = 8
//6	■	■	■						n6 = 224		6		■			■				n6 = 72
//7									n7 = 0		7	■	■	■		■	■			n7 = 236
//Suppose the full cells hold squares which can "fall down" by the influence of the gravity.Each full cell in certain row and column falls down to the lowest row possible but stays in the same column and up from any other full cells on the same column that ware initially down from it. At the figure the "fall down" process is illustrated.
//Write a program to calculate how the grid will look like after the "fall down" process is applied.
//Input
//The input data is being read from the console.
//There will be exactly 8 lines each holding the integer numbers n0, n1, …, n7.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output consists of the numbers n0, n1, …, n7 after the "fall down process".
//Ouput should be printed on the console, in exactly 8 lines, each holding a single integer.
//Constraints
//•	The numbers n0, n1, …, n7 are positive integers between 0 and 255, inclusive.
//•	Allowed work time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.



namespace _06.Fall
{
   class Fall
   {
      static void Main()
      {

         ////Input
         //int n0 = int.Parse(Console.ReadLine());
         //int n1 = int.Parse(Console.ReadLine());
         //int n2 = int.Parse(Console.ReadLine());
         //int n3 = int.Parse(Console.ReadLine());
         //int n4 = int.Parse(Console.ReadLine());
         //int n5 = int.Parse(Console.ReadLine());
         //int n6 = int.Parse(Console.ReadLine());
         //int n7 = int.Parse(Console.ReadLine());

         ////Solution
         //for (int i = 0; i < 8; i++)
         //{
         //   for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //   {
         //      if ((n7 >> bitPosition & 1) == 0 &&
         //          (n6 >> bitPosition & 1) == 1)
         //      {
         //         n7 |= (1 << bitPosition);
         //         n6 ^= (1 << bitPosition); //n6 &= ~(1 << bitPosition);
         //      }
         //   }
         //   for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //   {
         //      if ((n6 >> bitPosition & 1) == 0 &&
         //          (n5 >> bitPosition & 1) == 1)
         //      {
         //         n6 |= (1 << bitPosition);
         //         n5 ^= (1 << bitPosition);
         //      }
         //   }
         //   for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //   {
         //      if ((n5 >> bitPosition & 1) == 0 &&
         //          (n4 >> bitPosition & 1) == 1)
         //      {
         //         n5 |= (1 << bitPosition);
         //         n4 ^= (1 << bitPosition);
         //      }
         //   }
         //   for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //   {
         //      if ((n4 >> bitPosition & 1) == 0 &&
         //          (n3 >> bitPosition & 1) == 1)
         //      {
         //         n4 |= (1 << bitPosition);
         //         n3 ^= (1 << bitPosition);
         //      }
         //   }
         //   for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //   {
         //      if ((n3 >> bitPosition & 1) == 0 &&
         //          (n2 >> bitPosition & 1) == 1)
         //      {
         //         n3 |= (1 << bitPosition);
         //         n2 ^= (1 << bitPosition);
         //      }
         //   }
         //   for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //   {
         //      if ((n2 >> bitPosition & 1) == 0 &&
         //          (n1 >> bitPosition & 1) == 1)
         //      {
         //         n2 |= (1 << bitPosition);
         //         n1 ^= (1 << bitPosition);
         //      }
         //   }
         //   for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //   {
         //      if ((n1 >> bitPosition & 1) == 0 &&
         //          (n0 >> bitPosition & 1) == 1)
         //      {
         //         n1 |= (1 << bitPosition);
         //         n0 ^= (1 << bitPosition);
         //      }
         //   }
         //}

         ////Output
         //Console.WriteLine(n0);
         //Console.WriteLine(n1);
         //Console.WriteLine(n2);
         //Console.WriteLine(n3);
         //Console.WriteLine(n4);
         //Console.WriteLine(n5);
         //Console.WriteLine(n6);
         //Console.WriteLine(n7);



         ////Arrays

         ////Input
         //int[] nums = new int[8];
         //for (int i = 0; i < 8; i++)
         //{
         //   nums[i] = int.Parse(Console.ReadLine()); //filling in the Array
         //}
         //Console.WriteLine();
         //for (int i = 0; i < 8; i++)
         //{
         //   Console.Write(nums[i] + " "); //printig out the Array
         //}
         //Console.WriteLine();

         ////Solution 

         //for (int i = 0; i < 8; i++)
         //{
         //   for (int row = 7; row > 0; row--)
         //   {
         //      for (int bitPosition = 0; bitPosition < 8; bitPosition++)
         //      {
         //         if ((nums[row] >> bitPosition & 1) == 0 &&
         //             (nums[row - 1] >> bitPosition & 1) == 1)
         //         {
         //            nums[row] |= (1 << bitPosition);
         //            nums[row - 1] ^= (1 << bitPosition);
         //         }
         //      }
         //   }
         //   for (int j = 0; j < 8; j++)
         //   {
         //      string numToString = Convert.ToString(nums[j], 2).PadLeft(8, '0');
         //      Console.WriteLine(numToString);
         //   }
         //   Console.WriteLine();
         //}

         ////Otput
         ////foreach (var num in nums)
         ////{
         ////   Console.WriteLine(num);
         ////}   
         //for (int i = 0; i < 8; i++)
         //{
         //   Console.WriteLine(nums[i]);
         //}



         //Martix

         int[,] matrix = new int[8, 8];

         //Input
         for (int row = 0; row < 8; row++)
         {
            int num = int.Parse(Console.ReadLine());
            string numToString = Convert.ToString(num, 2).PadLeft(8, '0');

            for (int col = 0; col < 8; col++)
            {
               matrix[row, col] = int.Parse(numToString[col].ToString());
            }
         }

         //Solution

         for (int col = 0; col < 8; col++)
         {
            int count = 0;
            for (int row = 0; row < 8; row++)
            {
               if (matrix[row, col] == 1)
               {
                  count++; //count the 1
                  matrix[row, col] = 0; //after that erase it
               }
            }
            for (int i = 0; i < count; i++)
            {
               matrix[7 - i, col] = 1;
            }
         }


         //Shows the matrix
         //for (int row = 0; row < 8; row++)
         //{
         //   for (int col = 0; col < 8; col++)
         //   {
         //      Console.Write(matrix[row, col] + " ");
         //   }
         //   Console.WriteLine();
         //}


         //Output
         for (int row = 0; row < 8; row++)
         {
            StringBuilder sb = new StringBuilder();
            for (int col = 0; col < 8; col++)
            {
               sb.Append(matrix[row, col]);
            }
            int num = Convert.ToInt32(sb.ToString(), 2);
            Console.WriteLine(num);
         }
      }
   }
}
