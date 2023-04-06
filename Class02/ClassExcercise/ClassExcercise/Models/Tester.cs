using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    public class Tester : Employee, IDeveloper
    {
        public Tester()
        {
        }

        public Tester(string fullName, int age, Role Role) : base(fullName, age, Role)
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"This is {FullName} and he id {Age} old, and his role is {Role}");
        }

    }
}
