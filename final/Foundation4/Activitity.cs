using System;

// Base Activity class 
public class Activity 
{
    // store date of activity
    private DateTime date;
    // store length of activity in minutes
    private int length;
 
    // constructor
    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    // getter for date of activity
    public DateTime GetDate()
    {
        return date;
    }

    // getter for length of activity in minutes
    public int GetLength() 
    {
        return length;
    }

    // GetSummary method to produce a string with summary information
    public virtual string GetSummary()
    {
        return string.Format("Date({0}/{1}/{2}), Activity, ({3}min)",
            date.Day, date.Month, date.Year, length);
    }
}