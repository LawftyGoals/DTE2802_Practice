// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string friends = "scott and others, but really just scott";

friends = friends.Replace("scott", "damien");

Console.WriteLine(friends);


string bob = "bob";

Boolean isBob = bob switch { "bob" => true, _ => false };

Console.WriteLine(isBob);