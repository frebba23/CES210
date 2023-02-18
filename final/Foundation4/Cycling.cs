// Cycling class to deal with speed
public class Cycling : Activity
{
    // pace of cycling in kilometers per hour
    private double pace;

    // constructor
    public Cycling(DateTime date, int length, double pace) : base(date, length)
    {
        this.pace = pace;
    }

    // getter for pace
    public double GetPace() 
    {
        return pace;
    }

    // calculate speed in kilometers per hour
    public double CalculateSpeed()
    {
        return pace / (length / 60.0);
    }

    // GetSummary method to produce a string with summary information
    public override string GetSummary()
    {
        // calculate speed in kilometers per hour
        double speed = CalculateSpeed();
        
        return string.Format("Date({0}/{1}/{2}), Cycling, ({3}min, {4:0.00}kmph)",
            date.Day, date.Month, date.Year, length, speed);
    }
}