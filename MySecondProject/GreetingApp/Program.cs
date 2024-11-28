// Welcome user to the app.
Console.WriteLine("Wecome to our Greeting Application");
Console.WriteLine("This application was built by Rony");
Console.WriteLine("----------------------------------");
Console.WriteLine();

// Ask first name.
Console.Write("What is your first name: ");
string? firstName;
firstName = Console.ReadLine();

// Greet them by first name.
Console.WriteLine();
Console.WriteLine("Hello " + firstName);
Console.WriteLine("Thank you for using our Greeting Application");
Console.ReadLine();