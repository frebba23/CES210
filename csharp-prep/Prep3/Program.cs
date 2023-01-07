using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        //Console.Write("What is the magic number? ");
        

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        //magicNumber = Console.Read();

        //int guess = -1;

        while (true)
        //(guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            
            int guessNum = int.Parse(guess);
        
            if (magicNumber > guessNum)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}