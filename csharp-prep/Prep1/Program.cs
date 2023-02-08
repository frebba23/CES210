using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("How many students came to school? ");
      int t = int.Parse(Console.ReadLine());
      string[] students = new string(t);
      
      for(int i = 0; i < t; i++)
      {
        Console.WriteLine("Name of the students? ");
        students[i] = Console.ReadLine();
      }
       Console.WriteLine("Attended School Today ");
       for(int i = 0; i < t; i++)
       {
        Console.WriteLine(students[i]);
       }
    }
    
}