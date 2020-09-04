using System;

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
            if (bank.SecurityGuardScore < 0)
            {
                Console.WriteLine($"{name} just knocked that guy out, way to go {name}!");
            }
        }
    }
}
