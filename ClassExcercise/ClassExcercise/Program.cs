
using ClassExcercise.Models;
using ClassExcercise.Models.Enum;
FrenchCar renault = new FrenchCar()
{
    Brand = "Reno",
    Model = "Megane",
    YearOfProduction = new DateTime(2019,5,5),
    FuelType = FuelTypeEnum.Diesel,
    Navigation = true,
    HorsePower = 205
};
renault.Nav();

GermanCar skoda = new GermanCar("Reno", "Megane", DateTime.Now, 205, FuelTypeEnum.Diesel,250);

skoda.Speeder();
skoda.Drive("Resen");

Car.PrintFrenchCar(renault.Brand);
Car.PrintGermanCar(skoda.Model);
