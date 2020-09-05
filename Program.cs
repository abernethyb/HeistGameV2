using System;
using System.Collections.Generic;
using System.Threading;

namespace heistV2
{
    class Program
    {
        static void Main(string[] args)
        {

            Hacker owl = new Hacker()
            {
                name = "Owl",
                SkillLevel = 100, //50,
                PercentageCut = 25
            };
            Hacker eeyore = new Hacker()
            {
                name = "Eeyore",
                SkillLevel = 100, //90,
                PercentageCut = 25 //95
            };
            LockSpecialist piglet = new LockSpecialist()
            {
                name = "Piglet",
                SkillLevel = 100, //15,
                PercentageCut = 25 //5
            };
            Muscle kangor = new Muscle()
            {
                name = "kangor",
                SkillLevel = 100,
                PercentageCut = 25
            };
            Muscle pooh = new Muscle()
            {
                name = "Pooh",
                SkillLevel = new Random().Next(0, 100),
                PercentageCut = new Random().Next(0, 100)
            };

            List<IRobber> rolodex = new List<IRobber>()
            {
                owl,
                eeyore,
                piglet,
                kangor,
                pooh
            };
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Beep(294, 2000);
            Console.Beep(440, 2500);
            Console.Beep(330, 2500);
            Console.Beep(294, 2900);
            Console.Beep(276, 2700);

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
                Console.Clear();
                if (newName == "")
                {
                    isNotDone = false;
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Choose their specialty:");
                    Console.WriteLine("");
                    Console.WriteLine("Enter h for Hacker (Disables alarms)");
                    Console.WriteLine("Enter m for Muscle (Disarms guards)");
                    Console.WriteLine("Enter L Lock Specialist (cracks vault)");
                    string newType = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.Write("Enter a number between 1 and 100, this will be their skill level: ");
                    string strNewSkillLevel = Console.ReadLine();
                    int newSkillLevel = Int32.Parse(strNewSkillLevel);

                    Console.WriteLine("");

                    Console.Clear();

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.Write("Now enter a number between 1 and 100, this will be their percentage of the loot: ");
                    string strNewPercentage = Console.ReadLine();
                    int newPercentage = Int32.Parse(strNewPercentage);

                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

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
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
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

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"The Bank's most secure element is the {mostSecure} and the least secure element is the {leastSecure}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Here's a list of all the possible recruits:");
            Console.WriteLine("");
            Console.WriteLine("");

            rolodex.ForEach(robber => Console.WriteLine($"{robber.name}: {robber}. Skill Level: {robber.SkillLevel}. Demands: {robber.PercentageCut}% of the loot"));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

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

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("this is the crew you have chosen:");

            crew.ForEach(robber => Console.WriteLine($"{robber}: {robber.name}, Skill Level: {robber.SkillLevel}, Demands: {robber.PercentageCut}% of the loot"));

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("---------GAME TIME----------");

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("THREE");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("TWO");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("ONE");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Beep();
            // Console.WriteLine(theBank.IsSecure);
            // Console.WriteLine(theBank.AlarmScore);
            // Console.WriteLine(theBank.SecurityGuardScore);
            // Console.WriteLine(theBank.VaultScore);
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

                int lootTaken = 0;

                crew.ForEach(robber => lootTaken = lootTaken + ((theBank.CashOnHand * robber.PercentageCut) / 100));

                Console.WriteLine($"Loot taken {lootTaken}");

                // crew.ForEach(robber => theBank.CashOnHand = theBank.CashOnHand - ((theBank.CashOnHand * robber.PercentageCut) / 100));

                Console.WriteLine($"The bank now has {theBank.CashOnHand - lootTaken}");

                int userLoot = theBank.CashOnHand - lootTaken;

                theBank.CashOnHand = theBank.CashOnHand - lootTaken;

                Console.WriteLine($"You got {userLoot}.");
                theBank.CashOnHand = theBank.CashOnHand - userLoot;

                Console.WriteLine($"The bank now has {theBank.CashOnHand}");

            }

        }
    }
}