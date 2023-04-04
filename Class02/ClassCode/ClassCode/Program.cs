using ClassCode.Entities;

//Human damjan = new Human();
Developer lukaku = new Developer("Lukaku King",25,123456789,
    new List<string>{"C#","c++","Python"},10);
lukaku.Greet("Stevo");
lukaku.Code();
Console.WriteLine(lukaku.GetInfo());
Tester krste = new Tester("Krki Krski", 32, 123123123, 12);
krste.Greet("Kakulu");
Console.WriteLine(krste.GetInfo()); 
krste.TestFeature("Generate SSH");
DevOps shady = new DevOps("Nenad Shady", 23, 074203753, true, false);
Console.WriteLine(shady.GetInfo());
Console.WriteLine(shady.CheckInfrastructure(203));
shady.Code();