using System;
using System.Threading;

namespace heistV2
{
    public class Hacker : IRobber
    {
        public string name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{name} is hacking the alarm system");
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

            if (bank.AlarmScore < 0)
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
                Console.WriteLine($"{name} just disabled the alarm system, way to go {name}!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
        public override string ToString()
        {
            return "Hacker";
        }
    }
}