using System;
class OutdoorGathering : Event
{
    private string _weatherForecast;
    public OutdoorGathering(string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address address, string eventType, string weatherForecast)
    : base (eventTitle, eventDescription, eventDate, eventTime, address, "Outdoor Gathering")
    {
        _weatherForecast = weatherForecast;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}