using System;
using System.IO;


//http://bgcoder.com/Contests/93/Telerik-Academy-Exam-1-24-June-2013-Evening
//http://telerikacademy.com/Courses/Courses/Details/212

//Uncle Pesho needs help to calculate his garden production.He grows different vegetable plants.You are assigned to write a program to help him with the production calculations.
//Uncle Pesho wants to plant the following vegetables: tomato, cucumber, potato, carrot, cabbage, beans.
//For each vegetable, except the beans, uncle Pesho knows:
//•	how many seeds he wants to plant
//•	on what area he wants to plant those seeds
//For the beans, uncle Pesho has decided:
//•	how many seeds he wants to plant
//•	the area for the beans will be the area remaining after planting the other vegetables
//The total area uncle Pesho has is 250 square meters.
//Of course, everything in life has a price – including seeds. Below you will find a table with prices per seed for each vegetable
//Write a program to calculate the total cost of all the seeds Pesho needs to buy and the total area remaining for the beans.
//Seeds Costs
//tomato   0.5$ per seed     carrot   0.6$ per seed
//cucumber 0.4$ per seed     cabbage  0.3$ per seed
//potato   0.25$ per seed    beans 0.4$ per seed
//Input
//The input data consists of 11 lines describing all the vegetables.Each line will hold a single number:
//•	The first line holds the tomato seeds amount, the second – the tomato area.
//•	The third line holds the cucumber seeds amount, the fourth line – cucumber area. 
//•	The fifth line holds the potato seeds amount, sixth line – potato area.
//•	The seventh line holds the carrot seeds amount, eighth line – carrot area.
//•	The ninth line holds the cabbage seeds amount, tenth line – cabbage area. 
//•	The eleventh line holds the beans seeds amount.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed at the console in two lines:
//•	At the first line print the total seeds cost, rounded to second digit after the decimal separator, in format “Total costs: X.XX” where X.XX are the costs.
//•	At the second line print the remaining area for beans.
//o In case there is some area for beans left, print its size in format “Beans area: X” where X is the area left for beans.
//o In case of no area for beans is left, print „No area for beans“.
//o In case the area for the tomato, cucumber, potato, carrot and cabbage is insufficient, print “Insufficient area”.
//Constraints
//•	The seeds amount is non-negative integer number in the range [0…1000].
//•	The plants area is non-negative integer number in the range [0…250].
//•	All numbers should use as a decimal separator the symbol “.” (point, no comma).
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 4 MB.


namespace _34.Garden 
{
   //using System.IO;

   class Garden
   {
      static void Main()
      {

         // right click on the project --> Add --> New Item --> Text File --> name it.txtm using System.IO;

         //StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
         //Console.SetIn(reader);

         double tomatoPrice = 0.5;
         double cucumberPrice = 0.4;
         double patatoPrice = 0.25;
         double carrotPrice = 0.6;
         double cabbagePrice = 0.3;
         double beansPrice = 0.4;

         int availableArea = 250;

         int tomatoAmount = int.Parse(Console.ReadLine());
         int tomatoArea = int.Parse(Console.ReadLine());

         int cucumberAmount = int.Parse(Console.ReadLine());
         int cucumberArea = int.Parse(Console.ReadLine());

         int patatoAmount = int.Parse(Console.ReadLine());
         int patatoArea = int.Parse(Console.ReadLine());

         int carrotAmount = int.Parse(Console.ReadLine());
         int carrotArea = int.Parse(Console.ReadLine());

         int cabbageAmount = int.Parse(Console.ReadLine());
         int cabbageArea = int.Parse(Console.ReadLine());

         int beansAmount = int.Parse(Console.ReadLine());

         double totalPrice = tomatoAmount * tomatoPrice + cucumberAmount * cucumberPrice + patatoAmount * patatoPrice + carrotAmount * carrotPrice + cabbageAmount * cabbagePrice + beansAmount * beansPrice;

         Console.WriteLine("Total costs: {0:F2}", totalPrice);



         int usedArea = tomatoArea + cucumberArea + patatoArea + carrotArea + cabbageArea;

         if (usedArea == availableArea)
         {
            Console.WriteLine("No area for beans");
         }
         else
         {
            if (usedArea > availableArea)
            {
               Console.WriteLine("Insufficiant area");
            }
            else
            {
               Console.WriteLine("Beans area: {0}", availableArea - usedArea);
            }
         }
      }
   }
}
