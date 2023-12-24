// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter a number between 0 and 255");
string? first = Console.ReadLine();

Console.WriteLine("Enter another number between 0 and 255");
string? second = Console.ReadLine();

try
{
    int result = int.Parse(first) / int.Parse(second);
    Console.WriteLine($"{first} divded by {second} is {result}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Input string was not in a correct format");
}
catch (Exception)
{
    Console.WriteLine("Something wrong.");
}

