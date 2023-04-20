void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
void ToLowerCase(string text) => Console.WriteLine(text.ToLower());

StringDelegate stringDelegateToUpper = ToUpperCase;

stringDelegateToUpper("Some lower case text => [transform to uppercase]");

public delegate void StringDelegate(string text);


