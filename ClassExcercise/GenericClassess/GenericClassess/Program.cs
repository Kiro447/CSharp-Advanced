using GenericClassess.Entities;
using GenericClassess.DataBase;

Dog sharko = new Dog()
{
    Id = 1,
    Name = "Sharko",
    IsShepard = true,
};

Dog lina = new Dog()
{
    Id = 2,
    Name = "Lina",
    IsShepard = false,
};
Cat Maco = new Cat()
{
    Name = "Maco",
    Id = 3,
    IsNice = true,
};
BaseEntity sijam = new Cat()
{
    Name = "Sijam",
    Id = 4,
    IsNice = true,
};

GenericDB<Dog>.Insert(sharko);
GenericDB<Dog>.Insert(lina);
GenericDB<Cat>.Insert(Maco);
GenericDB<BaseEntity>.Insert(sijam);

GenericDB<Dog>.PrintAll();
//GenericDB<Dog>.Remove(sharko);
//GenericDB<Dog>.PrintAll();
Console.WriteLine("\n");
GenericDB<Cat>.PrintAll();
Console.WriteLine("\n");
GenericDB<BaseEntity>.PrintAll();
Console.WriteLine(GenericDB<Dog>.GetById(1).Name);