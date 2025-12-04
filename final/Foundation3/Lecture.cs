using System;
class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    public Lecture(string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address address, string eventType, string speakerName, int capacity)
    : base(eventTitle, eventDescription, eventDate, eventTime, address, "Lecture")
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {_speakerName}\nCapacity: {_capacity} people";
    }
}