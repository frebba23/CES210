using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction5 = new Fraction();
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        Fraction fraction6 = new Fraction(5);
        Console.WriteLine(fraction6.GetFractionString());
        Console.WriteLine(fraction6.GetDecimalValue());

        Fraction fraction7 = new Fraction(3, 4);
        Console.WriteLine(fraction7.GetFractionString());
        Console.WriteLine(fraction7.GetDecimalValue());

        Fraction fraction8 = new Fraction(1, 3);
        Console.WriteLine(fraction8.GetFractionString());
        Console.WriteLine(fraction8.GetDecimalValue());
    }
}