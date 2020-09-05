using System;
using System.Threading;

namespace heistV2
{
    public class LockSpecialist : IRobber
    {
        public string name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;

            Console.WriteLine($"{name} is picking the lock on the vault.");
            Thread.Sleep(1000);
            Console.WriteLine($@"
                                    ...      ...
                                    ....    ....
                                    .............
                                   ...        ...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            if (bank.VaultScore < 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($@"   ...      ...
                                    ....    ....
                                    .............
                                   ...        ...");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"{name} is has broken into the vault, way to go {name}!!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
        public override string ToString()
        {
            return "Lock Specialist";
        }
    }
}