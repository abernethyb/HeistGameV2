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
                SkillLevel = 101,
                PercentageCut = 25
            };
            Hacker eeyore = new Hacker()
            {
                name = "Eeyore",
                SkillLevel = 101,
                PercentageCut = 1
            };
            LockSpecialist piglet = new LockSpecialist()
            {
                name = "Piglet",
                SkillLevel = 101,
                PercentageCut = 15
            };
            Muscle pooh = new Muscle()
            {
                name = "Pooh",
                SkillLevel = 101,
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

            Bank theBank = new Bank()
            {
                AlarmScore = new Random().Next(0, 100),
                VaultScore = new Random().Next(0, 100),
                SecurityGuardScore = new Random().Next(0, 100),
                CashOnHand = new Random().Next(500000, 1000000)

            };
            theBank.TestSecure();

            string mostSecure = "";
            string leastSecure = "";

            if (theBank.AlarmScore > theBank.VaultScore && theBank.AlarmScore > theBank.SecurityGuardScore)
            {
                mostSecure = "Alarm System";
            }
            else if (theBank.VaultScore > theBank.AlarmScore && theBank.VaultScore > theBank.SecurityGuardScore)
            {
                mostSecure = "Vult";
            }
            else if (theBank.SecurityGuardScore > theBank.AlarmScore && theBank.SecurityGuardScore > theBank.VaultScore)
            {
                mostSecure = "Security Team";
            }
            if (theBank.SecurityGuardScore < theBank.AlarmScore && theBank.SecurityGuardScore < theBank.VaultScore)
            {
                leastSecure = "Security Team";
            }
            else if (theBank.VaultScore < theBank.AlarmScore && theBank.VaultScore < theBank.SecurityGuardScore)
            {
                leastSecure = "Vult";
            }
            else if (theBank.AlarmScore < theBank.VaultScore && theBank.AlarmScore < theBank.SecurityGuardScore)
            {
                leastSecure = "Alarm System";
            }

            Console.WriteLine($"The Bank's most secure element is the {mostSecure} and the least secure element is the {leastSecure}");

            Console.WriteLine("Here's a list of all the possible recruits:");

            rolodex.ForEach(robber => Console.WriteLine($"{robber}: {robber.name}, Skill Level: {robber.SkillLevel}, Demands: {robber.PercentageCut}% of the loot"));

            List<IRobber> crew = new List<IRobber>() { };

            bool stillAddingCrew = true;

            while (stillAddingCrew)
            {
                Console.Write("enter the number, starting with 0, of the team member you would like to add to your crew. Hit enter when you're done ");
                string strCrewMember = Console.ReadLine();
                if (strCrewMember == "")
                {
                    stillAddingCrew = false;
                }
                try
                {
                    int newCrewMember = Int32.Parse(strCrewMember);
                    crew.Add(rolodex[newCrewMember]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("C'mon, you know that's not a number");
                }

            }

            Console.WriteLine("this is the crew you have chosen:");

            crew.ForEach(robber => Console.WriteLine($"{robber}: {robber.name}, Skill Level: {robber.SkillLevel}, Demands: {robber.PercentageCut}% of the loot"));

            Console.WriteLine("---------GAME TIME----------");
            Console.WriteLine(theBank.IsSecure);
            Console.WriteLine(theBank.AlarmScore);
            Console.WriteLine(theBank.SecurityGuardScore);
            Console.WriteLine(theBank.VaultScore);
            crew.ForEach(robber => robber.PerformSkill(theBank));
            theBank.TestSecure();

            if (theBank.IsSecure == true)
            {
                Console.WriteLine("FAILURE!");
            }
            else if (theBank.IsSecure == false)
            {
                Console.WriteLine("SUCCESS!!!");
                Console.WriteLine($"Here's the takeaway: ");
                Console.WriteLine($"The bank had {theBank.CashOnHand}");

                // int loot = theBank.CashOnHand;
                // theBank.CashOnHand = 0;

                crew.ForEach(robber => Console.WriteLine($"{robber} took {((theBank.CashOnHand * robber.PercentageCut) / 100)}"));
                crew.ForEach(robber => theBank.CashOnHand = theBank.CashOnHand - ((theBank.CashOnHand * robber.PercentageCut) / 100));
                Console.WriteLine($"The bank now has {theBank.CashOnHand}");

                int userLoot = theBank.CashOnHand;

                Console.WriteLine($"You got {userLoot}.");
                theBank.CashOnHand = theBank.CashOnHand - userLoot;

                Console.WriteLine($"The bank now has {theBank.CashOnHand}");

            }

        }
    }
}