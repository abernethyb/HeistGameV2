using System;

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

            if (bank.AlarmScore < 0)
            {
                Console.WriteLine($"{name} just disabled the alarm system, way to go {name}!");
            }
        }
        public override string ToString()
        {
            return "Hacker";
        }
    }
}