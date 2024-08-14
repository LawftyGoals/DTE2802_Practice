// See https://aka.ms/new-console-template for more information

if (args.Length > 0) {
    if (args[0] == "convert") {
        if (args[2] == "C") {
            Console.WriteLine(((Convert.ToDouble(args[1]) * 9 / 5) + 32) + "°F");
        }
        else if (args[2] == "F") {
            Console.WriteLine(((Convert.ToDouble(args[1]) - 32) * 5 / 9) + "°C");
        }
    }
}
else {
    Console.WriteLine("Missing Arguments");
}