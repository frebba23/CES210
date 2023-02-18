public class Program
{
    public static void Main()
    {
        // create one activity of each type
        Activity activity1 = new Activity(DateTime.Now, 30);
        Running activity2 = new Running(DateTime.Now, 60, 10.0);
        Cycling activity3 = new Cycling(DateTime.Now, 45, 20.0);
        Swimming activity4 = new Swimming(DateTime.Now, 30, 10);

        // put each of the activities in the same list
        Activity[] activities = { activity1, activity2, activity3, activity4 };

        // iterate through this list and call the GetSummary method on each item and display the results
        foreach (Activity activity in activities) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}