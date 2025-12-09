using System;
public abstract class Activity
{
    private DateTime _date;
    private int _length;
    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _length = lengthMinutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public int GetLengthMinutes()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}