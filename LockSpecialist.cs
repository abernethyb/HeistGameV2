using System;

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

            if (bank.VaultScore < 0)
            {
                Console.WriteLine($"{name} is has broken into the vault, way to go {name}!!");
            }
        }
    }
}
