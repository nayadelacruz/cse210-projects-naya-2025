using System;
class Running : Activity
{
    private double _distanceInMiles;
    public Running(DateTime date, int lengthMinugtes, double distance)
        : base(date, lengthMinugtes)
        {
            _distanceInMiles = distance;
        }
    public override double GetDistance()
    {
        return _distanceInMiles;
    }
    public override double GetSpeed()
    {
        return (_distanceInMiles / GetLengthMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetLengthMinutes() / _distanceInMiles;
    }

}
