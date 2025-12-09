using System;
class Cycling : Activity
{
    private double _speedInMph;
    public Cycling(DateTime date, int lengthMinutes, double speedMph)
        : base(date, lengthMinutes)
    {
        _speedInMph = speedMph;
    }
    public override double GetDistance()
    {
        return (_speedInMph / 60) * GetLengthMinutes();
    }
    public override double GetSpeed()
    {
        return _speedInMph;
    }
    public override double GetPace()
    {
        return 60/ _speedInMph;
    }
}