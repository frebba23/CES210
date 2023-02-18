// Running class to deal with distance ran
public class Running : Activity
{
    // distance ran in kilometers
    private double distance;

    // constructor
    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    // getter for distance ran
    public double GetDistance()
    {
        return distance;
    }

    // calculate distance ran in kilometers per hour
    public double CalculateDistancePerHour()
    {
        return distance / (length / 60.0);
    }

    // GetSummary method to produce a string with summary information
    public override string GetSummary()
    {
        // calculate distance ran in kilometers per hour
        double distancePerHour = CalculateDistancePerHour();

        return string.Format("Date({0}/{1}/{2}), Running, ({3}min, {4:0.00}kmph)",
            date.Day, date.Month, date.Year, length, distancePerHour);
    }
}