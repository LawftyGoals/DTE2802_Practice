// See https://aka.ms/new-console-template for more information


Console.WriteLine("Rektangel Lengde: ");
var length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Rektangel Bredde: ");
var width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Areal: {length * width}\nOmkrets: {length * 2 + width * 2}");