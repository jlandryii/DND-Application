using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HloWrld
{
    class Program
    {
        


        
        static void Main(string[] args)
        {
            //TellStoryRand(1);
            int selection;
            bool success = false;

            while (success != true)
            {
                Console.WriteLine("Please Select from the following Menu Items:");
                Console.WriteLine("1. Create a new character");
                Console.WriteLine("2. Show the details of a character");
                Console.WriteLine("3. Edit a character");
                Console.WriteLine("4. Delete a character");
                Console.WriteLine("");
                Console.Write("Selected Option:");
                success = int.TryParse(Console.ReadLine(), out selection);
                if (success != true)
                {
                    Console.WriteLine("Invalid input! Please enter a numerical value from 1 - 4.");
                }
                else
                {
                    break;
                }
                Menu.Selection(selection);
            }

            Character slot1 = new Character(DataSheet.GetDetails(), DataSheet.GetStats());
            slot1.ListStats();
            Console.ReadLine();
        }

        /*

        */
    }

    class Menu
    {
        public static void Prompt()
        {
            int selection;
            bool success = false;

            while (success != true)
            {
                Console.WriteLine("Please Select from the following Menu Items:");
                Console.WriteLine("1. Create a new character");
                Console.WriteLine("2. Show the details of a character");
                Console.WriteLine("3. Edit a character");
                Console.WriteLine("4. Delete a character");
                Console.WriteLine("");
                Console.Write("Selected Option:");
                success = int.TryParse(Console.ReadLine(), out selection);
                if (success != true)
                {
                    Console.WriteLine("Invalid input! Please enter a numerical value from 1 - 4.");
                }
                else
                {
                    break;
                }
                Selection(selection);
            }
        }

        public static void Selection(int selection)
        {
            switch (selection)
            {
                case 1:
                    //Devise a way to use some user input to define what the name of the created class instance will be
                    Character slot1 = new Character(DataSheet.GetDetails(), DataSheet.GetStats());
                    Prompt();
                case 2:
                    //Will need a way to pull a specific reference to a created class.
                    Console.WriteLine("Please select which character you would like to show the details of");
                    int characterCount = 0;
                    //Pull total amount of character classes
                    for (int n = characterCount, n != 0, n-- ) //Fix for loop
                    {
                        //Access name property and possibly 1 or 2 others, list them with associated id #s
                        //Selector to handle which class is chosen
                    }
                    /*selectedClass*/.ListStats();
            }
                
        }
    }
}
