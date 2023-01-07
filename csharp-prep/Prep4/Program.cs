using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.Write("Enter a list of numbers, type 0 when done");
        List<int> numbers = new List<int>();
        int enterNumber = -1;

        while (true)
        {
            Console.Write("Enter a number ");
            string enterNum = Console.ReadLine();
            enterNumber = int.Parse(enterNum);
            numbers.Add(enterNumber);
            numbers.Sort();

            if (enterNumber == 0)
            {
                int sum = numbers.AsQueryable().Sum();
                double average = Queryable.Average(numbers.AsQueryable());
                int bigNum = numbers.Max();
                long smallNum = numbers.AsQueryable().Min();
                
                Console.WriteLine($"The sum is {sum}");
                Console.WriteLine($"The average is {Math.Round(average, 3)}");
                Console.WriteLine($"The largest number is {bigNum}");

                Console.WriteLine($"The sorted list is: ");
                for(int i = 0; i < numbers.Count; x++);
                {
                    Console.WriteLine(numbers[i]);
                }
                break;
            }
        }
    }
}