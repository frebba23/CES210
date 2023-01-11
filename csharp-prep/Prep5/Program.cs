using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        
        Console.Write("Welcome to the program!");
        Console.Write("Please enter your name: ");
        string name = Console.Read("");

        Console.Write("Please enter your favourite number");
        string number = Console.Read();
        int number = int.Parse(number);

        int squareNumber = number * number;

        Console.Write($"{name}, the square of your number is {squareNumber}");
    }
}