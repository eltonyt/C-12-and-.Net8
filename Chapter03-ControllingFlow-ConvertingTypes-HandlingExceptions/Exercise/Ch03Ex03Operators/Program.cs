// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x, y;

// 1. x = 4, y = 6
x = 3;
y = 2 + ++x;
Console.WriteLine($"X: {x}, Y: {y}");

// 2. x = 12, y = 5
x = 3 << 2;
y = 10 >> 1;
Console.WriteLine($"X: {x}, Y: {y}");

// 3. x = 8, y = 15
x = 10 & 8;
y = 10 | 7;
Console.WriteLine($"X: {x}, Y: {y}");


