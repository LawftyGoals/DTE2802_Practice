

var names = new List<string> {"Scott", "Ana", "Felipe"};
var arra = new int[] {0,1,2,3,4,5};
var arra2 = arra[1..3];


names.Add("David");
names.Add("Damien");

var names2 = names.GetRange(1, 4);


int[] arra3 = new int[1 + arra.Length];

for (int i = 0; i < arra3.Length; i++)
{
    if (i < arra.Length)
    {
        arra3[i] = arra[i];
    }
    else
    {
        arra3[i] = i;
    }
}

names.Sort();

foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}

Console.WriteLine(names[^1]);