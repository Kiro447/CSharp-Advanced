#region Excercise2
List<DateTime> holidays = new List<DateTime>() {
new DateTime(DateTime.Now.Year,1,1),
new DateTime(DateTime.Now.Year,1,7),
new DateTime(DateTime.Now.Year,4,20),
new DateTime(DateTime.Now.Year,4,30),
new DateTime(DateTime.Now.Year,5,1),
new DateTime(DateTime.Now.Year,5,3),
new DateTime(DateTime.Now.Year,5,25),
new DateTime(DateTime.Now.Year,5,24),
new DateTime(DateTime.Now.Year,8,2),
new DateTime(DateTime.Now.Year,9,8),
new DateTime(DateTime.Now.Year,12,8),
new DateTime(DateTime.Now.Year,10,12),
new DateTime(DateTime.Now.Year,12,10),
};
while (true)
{
    Console.WriteLine("Please enter date for check in the format day/month/year");
    string inputDate = Console.ReadLine();

    if (string.IsNullOrEmpty(inputDate))
    {
        Console.WriteLine("Please enter a valid date\nPlease enter continue");
        Console.ReadKey();
        continue;
    }
    bool dateParseValidation = DateTime.TryParse(inputDate, out DateTime date);
    if (!dateParseValidation)
    {
        Console.WriteLine("Please enter a valid date\nPlease enter continue");
        Console.ReadKey();
        continue;
    }
    if(holidays.Any(x=>x.Day == date.Day && x.Month == date.Month && x.Year == date.Year)) // za Year nemora
    {
        Console.WriteLine("It's a holiday so it's a non working day");
        continue;

    }
    if(date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
    {
        Console.WriteLine("Its weekend");
        continue;
    }
    Console.WriteLine("Its a working day");

    Console.WriteLine("Do you want to check another date\n Type yes or no");
    if(Console.ReadLine() == "yes")
    {
        continue;
    }
    break;

}




#endregion

