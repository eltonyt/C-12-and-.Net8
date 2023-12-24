// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 1; i <= 100; i ++) 
{
    if (i != 1)
    {
        Console.Write(", ");
    }
    if (i % 3 == 0)
    {
        int rest = i / 3;
        if (rest % 5 == 0)
        {
            Console.Write("FizzBuzz");
        }
        else
        {
            Console.Write("Fizz");   
        }
    }
    else if (i % 5 == 0)
    {
        Console.Write("Buzz");   
    }
    else
    {
        Console.Write(i);   
    }
}