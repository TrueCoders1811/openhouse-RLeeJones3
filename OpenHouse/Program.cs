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

                if (response  == "yes")
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

            string[] rooms = new string[]{ "living room", "kitchen" };
            string[] descriptions = new string[] { "The living room has shag carpet.", "The kitchen has black and white tile floors." };
            
            for(int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine($"Would you like to see the {rooms[i] }?");

                if (GetResponse() == true)
                {
                    Console.WriteLine(descriptions[i]);
                }
            }
        }



           
           
                

         

            
          
          
    
