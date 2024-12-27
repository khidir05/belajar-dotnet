// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("What is your Name");
var name = Console.ReadLine();
var CurrentDate = DateTime.Now;
Console.WriteLine($"Hello {name}, today is {CurrentDate}");
Console.Write($"{Environment.NewLine}Press any key to exit....");
Console.ReadKey(true);
