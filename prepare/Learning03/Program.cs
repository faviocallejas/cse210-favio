using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());

        Fraction b = new Fraction(6);
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());

        Fraction c = new Fraction(6, 7);
        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimalValue());
    }
}