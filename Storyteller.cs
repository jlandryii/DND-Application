using System;

public class Storyteller
{
    public static void TellStory(int passage)
    //Manual mode for the storyteller.
    {
        switch (passage)
        //Select which passage to make a decision for
        {
            case 1:
                switch (GetSelector())
                //User-Input decided selector for passage's outcome
                {
                    case 1:
                        Console.WriteLine("An adventurer walks into an open field.");
                        break;
                    case 2:
                        Console.WriteLine("An adventurer walks into a dark cave.");
                        break;
                    case 3:
                        Console.WriteLine("An adventurer walks into an ominous castle.");
                        break;
                    default:
                        Console.WriteLine("An adventurer walks into an open field.");
                        break;

                }
                goto case 2;
            case 2:
                switch (GetSelector())
                //User-Input decided selector for passage's outcome
                {
                    case 1:
                        Console.WriteLine("In front of the adventurer lies a shortsword. They pick it up and continue on.");
                        break;
                    case 2:
                        Console.WriteLine("The adventurer encounters a slime. They escape from the enemy and move forward.");
                        break;
                    case 3:
                        Console.WriteLine("A noise comes from behind the Adventurer. They check their surroundings, seeing nothing. They cautiously continue onwards.");
                        break;
                    default:
                        Console.WriteLine("In front of the adventurer lies a shortsword. They pick it up and continue on.");
                        break;
                }
                goto case 3;
            case 3:
                switch (GetSelector())
                //User-Input decided selector for passage's outcome
                {
                    case 1:
                        Console.WriteLine("The adventurer finds a wooden chest. Upon opening it, they find it filled with gems and coins.");
                        break;
                    case 2:
                        Console.WriteLine("An arrow flies from the right of the adventurer and hits them in the side. They fall to the ground, wounded.");
                        break;
                    case 3:
                        Console.WriteLine("A skeleton rises from the ground in front of the adventurer. The adventurer engages the enemy, and emerges victorious.");
                        break;
                    default:
                        Console.WriteLine("The adventurer finds a wooden chest. Upon opening it, they find it filled with gems and coins.");
                        break;
                }
                break;
            default:
                goto case 1;
        }
        Console.Read();
        //Wait for enter key to end program
    }

    public static void TellStoryRand(int passage)
    //Randomly generate a story without user input.
    {
        Random r = new Random();
        int rMin = 1;
        int rMax = 3;
        //Variables for default passage selector range

        int didPickup = 0;
        int isCautious = 0;
        int hasShield = 0;
        //Variables to affect final passage outcomes. Values are changed in second passage.

        switch (passage)
        //Uses passage parameter to decide which passage to start at.
        {
            case 1:
                rMin = 1;
                rMax = 3;
                switch (RandSelector(rMin, rMax, r))
                //Randomly decided selector for passage's outcome
                {
                    case 1:
                        Console.WriteLine("An adventurer walks into an open field.");
                        break;
                    case 2:
                        Console.WriteLine("An adventurer walks into a dark cave.");
                        break;
                    case 3:
                        Console.WriteLine("An adventurer walks into an ominous castle.");
                        break;
                    default:
                        Console.WriteLine("An adventurer walks into an open field.");
                        break;

                }
                goto case 2;
            case 2:
                rMin = 1;
                rMax = 3;
                switch (RandSelector(rMin, rMax, r))
                //Randomly decided selector for passage's outcome. Edits variables that may affect outcomes of final passage.
                {
                    case 1:
                        Console.WriteLine("In front of the adventurer lies a shortsword. They pick it up and continue on.");
                        didPickup = 1;
                        break;
                    case 2:
                        Console.WriteLine("The adventurer encounters a slime. They defeat it and loot a shield from it.");
                        hasShield = 1;
                        break;
                    case 3:
                        Console.WriteLine("A noise comes from behind the Adventurer. They check their surroundings, seeing nothing. They cautiously continue onwards.");
                        isCautious = 1;
                        break;
                    default:
                        Console.WriteLine("In front of the adventurer lies a shortsword. They pick it up and continue on.");
                        didPickup = 1;
                        break;
                }
                goto case 3;
            case 3:
                rMin = 1;
                rMax = 3;
                switch (RandSelector(rMin, rMax, r))
                //Randomly decided selector for passage's outcome. Uses Variables from previous passage to change outcomes of specific selector instance.
                {
                    case 1:
                        if (isCautious == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The adventurer finds a wooden chest. They disarm a trap mechanism, then open the chest. Inside is plenty of gems and coins.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The adventurer finds a wooden chest. They trigger a trap, releasing poision gas. Their last thing they saw was the twinkle of gold in the chest.");
                        }
                        break;
                    case 2:
                        if (hasShield == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("An arrow flies from the right of the adventurer. They raise their shield, deflecting the projectile with ease.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("An arrow flies from the right of the adventurer and hits them in the side. They fall to the ground, bleeding to death.");
                        }
                        break;
                    case 3:
                        if (didPickup == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("A skeleton rises from the ground in front of the adventurer. The adventurer engages the enemy with their sword, and emerges victorious.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A skeleton rises from the ground in front of the adventurer. The adventurer engages the enemy with their fist, and falls victim to the skeleton.");
                        }
                        break;
                    default:
                        Console.WriteLine("The adventurer finds a wooden chest. Upon opening it, they find it filled with gems and coins.");
                        break;
                }

                break;
            default:
                goto case 1;
        }
        Console.Read();
        //Wait for enter key to end program
    }

    public static int GetSelector()
    //Get user input to pass to switch inside of 
    {
        int selector = 0;
        int next = 0;
        while (next != 1)
        {
            Console.WriteLine("Enter a number from 1-3");
            string selectorString = Console.ReadLine();
            if (selectorString != "1" || selectorString != "2" || selectorString != "3")
            {
                selector = int.Parse(selectorString);
                next = 1;
            }
            else
            {
                Console.WriteLine("You have not entered a number from 1-3! Try again!");
            }
        }
        return selector;
    }

    public static int RandSelector(int rMin, int rMax, Random r)
    {
        int selector = r.Next(rMin, ++rMax);
        return selector;
    }
}
