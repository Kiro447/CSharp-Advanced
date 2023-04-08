using ClassExcercise.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise.Models
{
    public class FrenchCar : Car
    {
        public FrenchCar()
        {
        }

        public FrenchCar(string brand, string model, DateTime yearOfProduction, int horsePower, FuelTypeEnum FuelType, bool navigation) : base(brand, model, yearOfProduction, horsePower, FuelType)
        {
            Navigation = navigation;
        }

        public bool Navigation { get; set; }
        

        public void Nav()
        {
            if (Navigation)
            {
                Drive("Skopje");
            }
            Console.WriteLine("I do not have navigation :@");
        }

    }
}
