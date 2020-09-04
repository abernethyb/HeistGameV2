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
        }
    }
}