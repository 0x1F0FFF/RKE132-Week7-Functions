Console.WriteLine("Are you in or out?");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}

static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, alligator");
}