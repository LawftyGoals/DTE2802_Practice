// See https://aka.ms/new-console-template for more information
using Oppgave4;
using System.Reflection.Metadata.Ecma335;
using System.Text;

Console.WriteLine("Hello, World!");

int fi = 3, fj = 4;

void Swap(ref int i,  ref int j)
{
    int temp;
    temp = i;
    i = j;
    j = temp;

}

// or 

void TupSwap(ref int i, ref int j)
{
    (i, j) = (j, i);
}

Swap(ref fi, ref fj);

Console.WriteLine($"{fi} {fj}");


Console.WriteLine("Oppgave4");

Livsform[] livsformer = { new Amfibie(), new Apekatt(), new Edderkopp(), new Frosk(), new Hund(), new Insekt(), new Livsform(), new Menneske(), new Mygg(), new Pattedyr(), new Sau(), new Slange() };


foreach ( Livsform livsform in livsformer)
{
    livsform.LagLyd();
}

Console.WriteLine("\nOppgave5");

BinTall bintall1 = new(5);
BinTall bintall2 = new("101011001");

Console.WriteLine($"{+bintall1 + 1 + bintall1}");
Console.WriteLine($"{-bintall1 - 1 - bintall1}");
Console.WriteLine($"{bintall1 * 2 * bintall1}");
Console.WriteLine($"{bintall1}");
Console.WriteLine($"{bintall1.Number}");
Console.WriteLine($"{bintall1.Bits}");

Console.WriteLine($"{+bintall2 + 1 + bintall2}");
Console.WriteLine($"{-bintall2 - 1 -bintall2}");
Console.WriteLine($"{bintall2 * 2 * bintall2}");
Console.WriteLine($"{bintall2}");
Console.WriteLine($"{bintall2.Number}");
Console.WriteLine($"{bintall2.Bits}");



class BinTall
{
    int number;
    string bits;
    public BinTall(int heltall)
    {
        number = heltall;
        bits = Convert.ToString(heltall, 2);
    }

    public BinTall(string binstreng)
    {
        number = Convert.ToInt32(binstreng, 2);
        bits = binstreng;
    }

    public static int operator +(BinTall b) => b.number;

    public static int operator +(BinTall b, int n) => b.number + n;
    
    public static int operator +(int n,BinTall b)=> b.number + n;

    public static int operator -(BinTall b) => -b.number;

    public static int operator -(BinTall b, int n) => b.number - n;

    public static int operator -(int n, BinTall b) => n - b.number;

    public static int operator *(BinTall b, int n) => b.number * n;

    public static int operator *(int n, BinTall b) => b.number * n;

    public int Number { get => number;}
    public string Bits { get => bits;}

    public override string ToString()
    {
        return $"{number}: {bits}";
    }

}