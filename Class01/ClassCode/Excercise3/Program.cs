#region Excercise3
int draws = 0;
int userWins = 0;
int computerWins = 0;
static int UserPick()
{
    while (true)
    {
        Console.WriteLine("Pleace pick one:\n1. Rock 2. Paper 3. Scissors");
        string userOption = Console.ReadLine();
        if (string.IsNullOrEmpty(userOption))
        {
            Console.WriteLine("Enter ValidInput\nPress enter ");
            Console.ReadKey();
            continue;
        }
        bool userInputValidation = int.TryParse(userOption, out int userMove);
        if (!userInputValidation)
        {
            Console.WriteLine("Enter ValidInput\nPress enter ");
            Console.ReadKey();
            continue;
        }
        if(userMove > 3 || userMove <= 0)
        {
            Console.WriteLine("Enter ValidInput\nPress enter ");
            Console.ReadKey();
            continue;
        }
    }
}
#endregion