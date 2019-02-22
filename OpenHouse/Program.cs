using System;

namespace OpenHouse
{
    class Program
    {
        static bool GetResponse()
        {
            while (true)
            {
                string response = Console.ReadLine();

                if (response == "yes")
                {
                    return true;
                }
                else if (response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please type yes or no.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Open House!");
            Console.WriteLine("Do you want to see the living room?");
            if (GetResponse())
            {
                ChangeTextColor("The living room has shag carpet.", ConsoleColor.DarkMagenta);
               
            }
            Console.WriteLine("Do you want to see the dining room?");
            if (GetResponse())
            {
                ChangeTextColor("The table is scratched.", ConsoleColor.Cyan);
            }
       
            Console.WriteLine("How many steps do you think are in the staircase?");
            int guessCount = 0;
            while (guessCount < 3)
            {
                int stepStairs = int.Parse(Console.ReadLine());
                guessCount++;
                if (stepStairs < 10)
                {
                    ChangeTextColor("You did not guess high enough. Guess Again.", ConsoleColor.DarkGreen);
                }
                else if (stepStairs > 10)
                {
                    ChangeTextColor("You guessed too high. Guess Again.", ConsoleColor.DarkRed);
                }
                else if (stepStairs == 10)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
            }
              
            
            Console.WriteLine("There are exactly ten steps.");
        
                    
                

                
            
        }
        private static void ChangeTextColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }


            
    }
}





           
           
                

         

            
          
          
    
