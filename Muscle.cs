using System;
using System.Threading;

namespace heistV2
{
    public class Muscle : IRobber
    {
        public string name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{name} is wrestling a security guard");
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
            if (bank.SecurityGuardScore < 0)
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
                Console.WriteLine($"{name} just knocked that guy out, way to go {name}!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
        public override string ToString()
        {
            return "Muscle";
        }
    }
}