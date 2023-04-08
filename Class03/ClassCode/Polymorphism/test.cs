using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class test
    {
        public void Eat()
        {
            Console.WriteLine("Eat kebap");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"Eating {food}");
        }
        public void Eat(string food, int kg)
        {
            Console.WriteLine($"Eating {kg}kg {food}.");
        }
        public void Eat(int kg , string food)
        {
            Console.WriteLine("king");
        }
    }
}
