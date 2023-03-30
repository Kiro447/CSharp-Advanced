#region Excercise 1
List<string> names = new List<string>();
while (true)
{
    Console.WriteLine("Please enter a name or enter x to continue");
    string name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("You did not enter anything. Please enter a name!\nPress enter to continue");
        Console.ReadKey();
        continue;
    }
    else if (name.ToLower() == "x")
    {
        break;
    }
    if (names.Contains(name))
    {
        Console.WriteLine("You entered that name");
        continue;
    }
    names.Add(name);
}
string text = string.Empty;

while (true)
{
    Console.WriteLine("Enter text");

    text = Console.ReadLine();
    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("You did not enter anything. Please enter a name!\nPress enter to continue");
        Console.ReadKey();
        continue;

    }

    break;
}

foreach (string name in names)
{
    List<string> splittedText = text.Split(" ").ToList();
    int wordCount = splittedText
        .Count(x => string
        .Equals(x, name, StringComparison.InvariantCultureIgnoreCase));
    Console.Write($"{name}: {wordCount}");
};

#endregion