

Console.WriteLine("Welcome to our Student Check Application.");
Console.WriteLine("-----------------------------------------\n");

string? readResult;
string firstName = "";
int age;

Console.Write("Please type your first name: ");
readResult = Console.ReadLine();
if (readResult != null)
{
    firstName = readResult;
}

Console.Write("Please type your age: ");
readResult = Console.ReadLine();
int.TryParse(readResult, out age);

string userName;

if (firstName == "Bob" || firstName == "Sue")
{
    userName = $"Professor {firstName}";
}
else
{
    userName = firstName;
}

Console.WriteLine($"\nHi {userName},");

if (age < 21)
{
    Console.WriteLine($"\nI recommend you to wait {21 - age} years to start this class.");
} else
{
    Console.WriteLine("\nI am happy to let you know, you are ready to start this class.");
}

Console.WriteLine("\nThank you.");

Console.Write("\nPlease enter to continue.");
Console.ReadLine();
