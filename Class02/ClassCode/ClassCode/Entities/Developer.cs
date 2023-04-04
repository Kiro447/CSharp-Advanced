using ClassCode.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCode.Entities
{
    public class Developer : Human, IDeveloper
    {
        public Developer(string fullName, int age, long phone, List<string> language, int experience) 
            : base(fullName, age, phone)
        {
            ProgrammingLanguages = language;
            YearsOfExpirience = experience;
        }

        public int YearsOfExpirience { get; set; }
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();

        public void Code()
        {
            Console.WriteLine("Shtrak shtrak shtraaaak ! ! !");
            Console.WriteLine("Opens ChatGPT");
            Console.WriteLine("Can not find a solution");
            Console.WriteLine("*cries*");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age} years) - {YearsOfExpirience} years of expirience";
        }
    }
}
