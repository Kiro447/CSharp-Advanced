using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCode.Entities.Interfaces
{
    public interface IHuman
    {
        string GetInfo();
        void Greet(string name);
    }
}
