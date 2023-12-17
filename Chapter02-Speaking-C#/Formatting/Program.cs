// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// numbered positions arguments
int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

// interpolated strings
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

// 123.4 -> 01234.40
float a = 123.4F;
Console.WriteLine($"{a:0000.00}");
Console.WriteLine($"{a:####.##}");

// 1234567 -> 1234567.000
int longNumber = 1234567;
Console.WriteLine($"{longNumber:0.000}");

// 1234567 -> 1,234,567
Console.WriteLine($"{longNumber:0,000}");

// 123.4 -> 12340%
Console.WriteLine($"{a:0%}");