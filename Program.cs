using System;
using System.Collections.Generic;

namespace heistV2
{
    class Program
    {
        static void Main(string[] args)
        {

            Hacker owl = new Hacker()
            {
                name = "Owl",
                SkillLevel = 75,
                PercentageCut = 25
            };
            Hacker eeyore = new Hacker()
            {
                name = "Eeyore",
                SkillLevel = 75,
                PercentageCut = 1
            };
            LockSpecialist piglet = new LockSpecialist()
            {
                name = "Piglet",
                SkillLevel = 25,
                PercentageCut = 15
            };
            Muscle pooh = new Muscle()
            {
                name = "Pooh",
                SkillLevel = 75,
                PercentageCut = 50
            };

            List<IRobber> rolodex = new List<IRobber>()
            {
                owl,
                eeyore,
                piglet,
                pooh
            };

            /*
            

            When the program starts, print out the number of current operatives in the roladex. Then prompt the user to enter the name of a new possible crew member. Once the user has entered a name, print out a list of possible specialties and have the user select which specialty this operative has. The list should contain the following options

                Hacker (Disables alarms)
                Muscle (Disarms guards)
                Lock Specialist (cracks vault)

            Once the user has selected a specialty, prompt them to enter the crew member's skill level as an integer between 1 and 100. Then prompt the user to enter the percentage cut the crew member demands for each mission. Once the user has entered the crew member's name, specialty, skill level, and cut, you should instantiate the appropriate class for that crew member (based on their specialty) and they should be added to the rolodex.

            Continue the above action and allow the user to enter as many crew members as they like to the rolodex until they enter a blank name before continuing.

            */

            Console.WriteLine($"There are currently {rolodex.Count} team members to choose from.");

            bool isNotDone = true;

            while (isNotDone)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("You're going to want more to choose from. Enter a new crew member.");
                Console.Write("Name: ");
                string newName = Console.ReadLine();
                if (newName == "")
                {
                    isNotDone = false;

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Choose their specialty:");
                    Console.WriteLine("");
                    Console.WriteLine("Enter h for Hacker (Disables alarms)");
                    Console.WriteLine("Enter m for Muscle (Disarms guards)");
                    Console.WriteLine("Enter L Lock Specialist (cracks vault)");
                    string newType = Console.ReadLine();

                    Console.WriteLine("");

                    Console.Write("Enter a number between 1 and 100, this will be their skill level: ");
                    string strNewSkillLevel = Console.ReadLine();
                    int newSkillLevel = Int32.Parse(strNewSkillLevel);

                    Console.WriteLine("");

                    Console.Write("Now enter a number between 1 and 100, this will be their percentage of the loot: ");
                    string strNewPercentage = Console.ReadLine();
                    int newPercentage = Int32.Parse(strNewSkillLevel);

                    if (newType == "h")
                    {
                        Hacker newhacker = new Hacker()
                        {
                        name = newName,
                        SkillLevel = newSkillLevel,
                        PercentageCut = newPercentage
                        };
                        rolodex.Add(newhacker);
                    }
                    else if (newType == "m")
                    {
                        Muscle newMuscle = new Muscle()
                        {
                        name = newName,
                        SkillLevel = newSkillLevel,
                        PercentageCut = newPercentage
                        };
                        rolodex.Add(newMuscle);
                    }
                    else if (newType == "l")
                    {
                        LockSpecialist newLockSpecialist = new LockSpecialist()
                        {
                        name = newName,
                        SkillLevel = newSkillLevel,
                        PercentageCut = newPercentage
                        };
                        rolodex.Add(newLockSpecialist);
                    }
                }

                Console.WriteLine($"There are currently {rolodex.Count} team members to choose from.");
            }

        }
    }
}