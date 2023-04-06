using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    public abstract class Employee : IDeveloper
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }

        public string Code()
        {
            throw new NotImplementedException();
        }

    }
    public enum Role
    {
        Developer = 1,
        Tester
    }
}
