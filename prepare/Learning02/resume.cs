public class Resume
{
    public string _name = "";
    public List<string> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job in _jobs)
        job.Display();
    }

}