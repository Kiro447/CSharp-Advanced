using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassess.Entities
{
    internal class Cat : BaseEntity
    {
        public bool IsNice { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Dog info:\n Name:{Name}\n Is the cat nice: {(IsNice ? "yes" : "no")}");
        }
    }
}
