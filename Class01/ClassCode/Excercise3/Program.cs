
using Excercise3;
#region
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
        return userMove;
    }

}
static int ComputerMove()
{
    Random rand = new Random();
    int randomNumber = rand.Next(1,4);
    return randomNumber;
}
static ResultEnum DecideWinner(OptionEnum userSelection, OptionEnum computerSelection)
{
    if(userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Rock || 
        userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Scissors ||
        userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Paper)
    {
        return ResultEnum.PlayerWins;
    }
    if(computerSelection == OptionEnum.Paper && userSelection == OptionEnum.Rock||
        computerSelection == OptionEnum.Rock && userSelection == OptionEnum.Scissors ||
        computerSelection == OptionEnum.Scissors && userSelection == OptionEnum.Paper)
    {
        return ResultEnum.ComputerWins;
    }

        return ResultEnum.Draw;
    
}
static decimal CalculatePercentage(int wins, int total)
{
    return (wins / (decimal)total); 
}
while (true)
{
    Console.Clear();
    OptionEnum userSelection = (OptionEnum)UserPick();
    OptionEnum compSelection = (OptionEnum)ComputerMove();
    ResultEnum result = DecideWinner(userSelection, compSelection);

    switch (result)
    {
        case ResultEnum.PlayerWins:
            userWins++;
            break;
        case ResultEnum.ComputerWins:
            computerWins++;
            break;
        case ResultEnum.Draw:
            draws++;
            break;
        default:
            throw new Exception("Invalid outcome");
    }
    int playedGames = userWins + computerWins + draws;
    Console.WriteLine($"{"User", 10}|{userWins, 6}|{CalculatePercentage(userWins,playedGames):P} \n" +
        $" {"Computer",10}|{computerWins,6}|{CalculatePercentage(computerWins,playedGames)}\n" +
        $"{"Draws",10}|{draws}");
    Console.WriteLine("Wanna play again?\n Type yes / no ");
    if(Console.ReadLine() == "no")
    {
        break;
    }
    continue;
}

#endregion
