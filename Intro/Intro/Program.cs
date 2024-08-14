// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Oliver!");

var _name = "Oliver";

Console.WriteLine("Hello " + _name + "!");

Console.WriteLine($"Hello {_name}!");

Console.WriteLine($"Hello {_name.ToUpper()}!");

var names = new[] { "Your Name", "Felipe", "Emillia" };

foreach (var name in names) {
    Console.WriteLine($"Hello {name}!");
}
