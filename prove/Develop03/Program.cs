using System;

class Program
{
    static void Main(string[] args)
    {
        Reference verseReference = new Reference("Proverbs", "3", "5-6");
        Scripture verse = new Scripture(verseReference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(verse);

        string userInput = "";

        while(userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.format("{0} {1}", verseReference.toString(),scriptureMemorizer.toString()));
            Console.WriteLine();
            Console.ReadLine();
            scriptureMemorizer.removeWordsFromList();
        }

    }
}