using Class09;
using Logger;

LoggerService loggerService = new LoggerService();

List<User> users = new List<User>()
{
    new User() { 
        FirstName = "Jordanov",
        Id = 1,
        LastName = "Jordanov",
        Password = "blabla" ,
        UserName = "kiro447"},
    new User() { 
        FirstName = "stevo",
        LastName = "Pendarovski",
        UserName = "stevo446",
        Password="blabla 2",
        Id=2 ,}
};

void Login(string username, string password)
{
    User user = users.FirstOrDefault(x => x.UserName == username && x.Password == password);
    if (user == null)
    {
        throw new Exception($"Invalid login for {username} was not found.");

    }
}

try
{
    TextHelper.TextGenerator("Enter a username", ConsoleColor.Green);
    string userName = Console.ReadLine();
    TextHelper.TextGenerator("Enter a password", ConsoleColor.Green);
    string password = Console.ReadLine();
    loggerService.Log($"Trying to log in a user with username: {userName}");
    Login(userName, password);
}
catch (Exception ex)
{
    TextHelper.TextGenerator("An error occured",ConsoleColor.Red);

    loggerService.Log(ex.Message,true);
}