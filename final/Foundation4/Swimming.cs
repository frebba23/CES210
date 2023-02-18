// Swimming class to deal with number of laps
public class Swimming : Activity
{
    // number of swimming laps
    private int laps;

    // constructor
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    // getter for laps
    public int GetLaps()
    {
        return laps;
    }

    // calculate distance of laps in kilometers
    public double CalculateDistance()
    {
        return laps * (50.0 / 1000);
    }

    // GetSummary method to produce a string with summary information
    public override string GetSummary()
    {
        // calculate distance of laps in kilometers
        double distance = CalculateDistance();
        
        return string.Format("Date({0}/{1}/{2}), Swimming, ({3}min, {4:0.00}km)",
            date.Day, date.Month, date.Year, length, distance);
    }
}
