using ClassExcercise.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise.Models
{
    public abstract class Car : ICar
    {
        public string Brand { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public DateTime YearOfProduction { get; set; }
        public int HorsePower { get; set; }
        public FuelTypeEnum FuelType { get; set; }

        public Car()
        {

        }
        public Car(string brand, string model, DateTime yearOfProduction, int horsePower, FuelTypeEnum fuelType)
        {
            Brand = brand;
            Model = model;
            YearOfProduction = yearOfProduction;
            HorsePower = horsePower;
            FuelType = fuelType;
        }

        public void Drive(string destination)
        {
            Console.WriteLine($"You are driving to {destination}");
        }

        public void Radio(string song)
        {
            Console.WriteLine($"Playing {song}");
        }
        public static void PrintGermanCar(string brand)
        {
            Console.WriteLine($"This is german car model {brand}");
        }
        public static void PrintFrenchCar(string brand)
        {
            Console.WriteLine($"This is french car model {brand}");
        }


    }
}
