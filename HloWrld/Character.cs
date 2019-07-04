using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HloWrld
{
    public class Character
    {
        //Member Variables
        private int statStr;
        private int statDex;
        private int statCon;
        private int statInt;
        private int statWis;
        private int statCha;
        private string charName;
        private int charAge;
        private int charLevel;
        private string charClass;
        private string charAlign;
        private string charRace;
        private string charGender;

        //Constructor
        public Character(string[] charDetails, int[] charStats)
        {
            this.charLevel = charStats[0];
            this.charAge = charStats[1];
            this.charAlign = getAlignment(charStats[2]);
            this.statStr = charStats[3];
            this.statDex = charStats[4];
            this.statCon = charStats[5];
            this.statInt = charStats[6];
            this.statWis = charStats[7];
            this.statCha = charStats[8];
            this.charName = charDetails[0];
            this.charClass = charDetails[1];
            this.charRace = charDetails[2];
            this.charGender = charDetails[3];
        }

        //Member Methods
        public void ListStats()
        {
            Console.WriteLine();
            Console.WriteLine("Your Character is {0}, a {1} year-old {2} {3}.", charName, charAge, charRace, charClass);
            if (charGender == "male")
            {
                Console.WriteLine("He is level {0} and is {1}", charLevel, charAlign);
            }
            else
            {
                Console.WriteLine("She is level {0} and is {1}", charLevel, charAlign);
            }
            Console.WriteLine("~Stats~");
            Console.WriteLine("Strength: {0}", this.statStr);
            Console.WriteLine("Dexterity: {0}", this.statDex);
            Console.WriteLine("Constitution: {0}", this.statCon);
            Console.WriteLine("Intelligence: {0}", this.statInt);
            Console.WriteLine("Wisdom: {0}", this.statWis);
            Console.WriteLine("Charisma: {0}", this.statCha);
        }

        private string getAlignment(int selector)
        {
            switch (selector)
            {
                case 1:
                    return "lawful good";
                case 2:
                    return "neutral good";
                case 3:
                    return "chaotic good";
                case 4:
                    return "lawful neutral";
                case 5:
                    return "true neutral";
                case 6:
                    return "chaotic neutral";
                case 7:
                    return "lawful evil";
                case 8:
                    return "neutral evil";
                case 9:
                    return "chaotic evil";
                default:
                    return "true neutral";
            }

                    
        }

    }
}
