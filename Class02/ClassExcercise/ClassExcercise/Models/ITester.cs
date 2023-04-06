using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    public interface ITester : IEmployee
    {
        int Test(int numberOfBugs);
    }
}
