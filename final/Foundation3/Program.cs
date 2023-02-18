using System;

public class Program
{
    static void Main(string[] args)
    {
        // Create an event of each type
        Lecture lecture = new Lecture
        {
            Title = "Lecture",
            Description = "Learn about C#",
            Date = DateTime.Now,
            Time = DateTime.Now,
            Address = new Address { Street = "123 Main Street", City = "Atlanta", State = "GA", ZipCode = "12345" },
            SpeakerName = "John Doe",
            VenueCapacity = 100
        }; 

        Reception reception = new Reception
        {
            Title = "Reception",
            Description = "Networking event",
            Date = DateTime.Now,
            Time = DateTime.Now,
            Address = new Address { Street = "456 Main Street", City = "Atlanta", State = "GA", ZipCode = "12345" },
            Registration = new List<string> { "John Doe", "Jane Doe" },
            RSVP = new List<string> { "John Doe" }
        }; 

        OutdoorGathering outdoorGathering = new OutdoorGathering
        {
            Title = "Outdoor Gathering",
            Description = "Picnic in the park",
            Date = DateTime.Now,
            Time = DateTime.Now,
            Address = new Address { Street = "789 Main Street", City = "Atlanta", State = "GA", ZipCode = "12345" },
            WeatherForecast = "Sunny and warm"
        }; 

        // Generate marketing messages and output their results on the screen
        Console.WriteLine(lecture.GenerateMessage());
        Console.WriteLine(reception.GenerateMessage());
        Console.WriteLine(outdoorGathering.GenerateMessage());
        Console.ReadKey();
    }
}