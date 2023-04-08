using ClassExcercise.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise.Models
{
    public class GermanCar : Car
    {
        public GermanCar()
        {

        }
        public GermanCar(string brand, string model, DateTime yearOfProduction, int horsePower, FuelTypeEnum FuelType, int MaxSpeed) : base(brand, model, yearOfProduction, horsePower, FuelType)
        {
            MaxSpeed = MaxSpeed;
        }

        public int MaxSpeed { get; set; }
        
        public void Speeder()
        {
            if(MaxSpeed > 200)
            {
                Radio("VETAR PROMENE");
            }
            else
            {
                Console.WriteLine("BRZI OD METKA");
            }
        }
    }
}
