using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HloWrld
{
    public class DataSheet
    {
        //Methods
        public static string[] GetDetails()
        {
            string[] details = new string[4];
            Console.WriteLine("What is your character's name?");
            details[0] = Console.ReadLine();
            Console.WriteLine("What is your character's class?");
            details[1] = Console.ReadLine();
            Console.WriteLine("What is your character's race?");
            details[2] = Console.ReadLine();
            bool success = false;
            while (success != true)
            {
                Console.WriteLine("Please enter the numerical value corresponding to your character's gender.");
                Console.WriteLine("1: Male, 2: Female");
                int result;
                success = int.TryParse(Console.ReadLine(), out result);
                if (success == true && result == 1)
                {
                    details[3] = "male";
                } else if (success == true && result == 2)
                {
                    details[3] = "female";
                } else
                {
                    success = false;
                    Console.WriteLine("Invalid Entry! Please enter a numerical value of either 1 or 2.");
                }
            }
            return details;


        }




        public static int[] GetStats()
        {
            bool success = false;
            int[] stats = new int[9];
            while (success != true)
            {
                Console.WriteLine("What is your character's level?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[0]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("What is your character's age?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[1]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("Please enter the number corresponding to your character's alignment.");
                Console.WriteLine("1: Lawful Good, 2: Neutral Good, 3: Chaotic Good");
                Console.WriteLine("4: Lawful Neutral, 5: True Neutral, 6: Chaotic Neutral");
                Console.WriteLine("7: Lawful Evil, 8: Neutral Evil, 9: Chaotic Evil");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[2]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value between 1 and 9.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("What is your character's strength?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[3]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("What is your character's dexterity?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[4]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("What is your character's constitution?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[5]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("What is your character's intelligence?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[6]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("What is your character's wisdom?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[7]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }
            success = false;
            while (success != true)
            {
                Console.WriteLine("What is your character's charisma?");
                string readValue = Console.ReadLine();
                success = int.TryParse(readValue, out stats[8]);
                if (success != true)
                {
                    Console.WriteLine("Invalid Entry! Please enter a numerical value.");
                }
                else break;
            }

            return stats;
        }
    }
}
