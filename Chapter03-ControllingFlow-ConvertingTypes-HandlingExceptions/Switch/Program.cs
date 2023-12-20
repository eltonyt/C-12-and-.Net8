// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string testSwitch = "a";

string result = testSwitch switch 
{
    "a" => "A",
    "b" => "B",
    _ => "Default",
};

WriteLine(result);

string[] names = {"a", "b", "c"};
foreach (string name in names) {
    WriteLine(name);
}