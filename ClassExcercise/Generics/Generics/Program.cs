List<int> numbers = new List<int>()
{
    0,1, 2, 3, 4, 5, 6
};
List<string> names = new List<string>()
{
    "Steve","Murphy","Leo","Cyril"
};

List<bool> booleans = new List<bool>()
{
    true,false,false,false,true,false,false,false,false,false,false,true
};
//void PrintNumbers(List<int> listOfNumbers)
//{
//    foreach (int number in listOfNumbers)
//    {
//        Console.WriteLine(number);
//    }
//}
//PrintNumbers(numbers);
//void PrintStrings(List<string> listOfStrings)
//{
//    foreach(string strings in listOfStrings) { Console.WriteLine(strings); }
//}
//PrintStrings(names);

void PrintEveryType<Neshto>(List<Neshto> someList)
{
    foreach(Neshto item in someList)
    {
        Console.WriteLine(item);
    }
}
PrintEveryType(names);
Console.WriteLine("\n");
PrintEveryType(numbers);
Console.WriteLine("\n");
PrintEveryType(booleans);
    
