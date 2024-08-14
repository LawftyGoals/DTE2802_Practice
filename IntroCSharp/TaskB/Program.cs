// See https://aka.ms/new-console-template for more information
Console.WriteLine("vekt (kg): ");
var vekt = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("høyde (m): ");
var hoyde = Convert.ToDouble(Console.ReadLine());

var BMI = vekt / (hoyde * hoyde);

Console.WriteLine("Din BMI er: " + BMI);

if (BMI < 18.5) {
    Console.WriteLine("* mindre enn 18,5 betyr undervekt");
}
else if (BMI >= 18.5 && BMI < 25) {
    Console.WriteLine("* fra og med 18,5 til og med 24,9 betyr normalvekt");
}
else if (BMI >= 25.0 && BMI < 30) {
    Console.WriteLine("* mellom 25 og 29,9 betyr overvekt");
}
else if (BMI >= 30) {
    Console.WriteLine("* er større enn 30 betyr fedme");
}
