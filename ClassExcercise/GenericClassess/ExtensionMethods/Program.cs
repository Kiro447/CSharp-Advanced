using ExtensionMethods.Helpers;

List<string> words = new List<string>()
{
    "hello","bye","sedc","bojan"
};

words.Print();
List<int> numbers = new List<int>()
{ 1, 2, 3, 4, 5, 6,};
numbers.Print();
numbers.GetInfo();
words.GetInfo();
Console.WriteLine("hello".CapitalizeFirstLetter("Marko"));

string king = "blabla";
king.ColorText(ConsoleColor.Green);
Console.WriteLine("blabla");

//same thing as abowe
ListHelper.ColorText(king, ConsoleColor.Cyan);