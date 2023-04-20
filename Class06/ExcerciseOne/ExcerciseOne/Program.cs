List<string> names = new List<string>() { "stevo","kakulu","senpo","gavril","posen"};

Func<List<string>,bool> CheckIfListIsEmpty = x => x.Count == 0;

bool namesIsEmpty = CheckIfListIsEmpty(names);
Console.WriteLine(namesIsEmpty);

Func<int,int,int> Sum = (x,y) => x+y;
Func<double, double, double> Devide = (x, y) =>
{
    if (y == 0)
    {
        //throw new DivideByZeroException("POZZ DZIPERI");
        //return -1;
    }
    return x / y;
};

Console.WriteLine(Sum(400, 2));
Console.WriteLine(Devide(400, 0));

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> broevi = new List<int>() {2,5,6,7,8,9,22,33,44,55 };
var even = numbers.Where(x => x % 2 == 0);

// Same Query with func
Func<int,bool> checkEven = x => x % 2 == 0;
List<int> EvenNumbers = numbers.Where(checkEven).ToList();


// ------------- Action -------------

Action sayHello = () => Console.WriteLine("pozzdravv");

sayHello();

Action<string> printText = x =>
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine(x);
    Console.ResetColor();
};
printText("JA JA JAJ A JA JA");