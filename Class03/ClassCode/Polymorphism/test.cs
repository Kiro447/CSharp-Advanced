using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class test
    {
        void Eat()
        {
            Console.WriteLine("Eat kebap");
        }
        void Eat(string food)
        {
            Console.WriteLine($"Eating {food}");
        }
        void Eat(string food, int kg)
        {
            Console.WriteLine($"Eating {food} it is {kg}kg");
        }
    }
}
