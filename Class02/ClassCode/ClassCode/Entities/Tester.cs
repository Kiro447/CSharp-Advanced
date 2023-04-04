using ClassCode.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCode.Entities
{
    internal class Tester : Human, ITester
    {
        public Tester(string fullName, int age, long phone, int bugsFound) : base(fullName, age, phone)
        {
            BugsFound = bugsFound;
        }

        public int BugsFound { get; set; }

        public override string GetInfo()
        {
            return $"Hello i am {FullName} and i found {BugsFound} bugs";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"Testing some software");
            Console.WriteLine($"{BugsFound}");
        }
    }
}
