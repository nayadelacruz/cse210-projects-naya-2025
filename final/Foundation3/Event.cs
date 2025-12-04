using System;
using System.Net.Sockets;
class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private DateTime _eventDate;
    private TimeSpan _eventTime;
    private Address _address;
    private string _eventType;
    public Event (string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address address, string eventType)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _address = address;
        _eventType = eventType;
    }
    public string GetStandardDetails()
    {
        return $"Event Title: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_eventDate.ToShortDateString()}\nTime: {_eventTime}\nAddress: {_address.GetFullAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Event Type: {_eventType}\nEvent Title: {_eventTitle}\nDate: {_eventDate.ToShortDateString()}";
    }
    virtual public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {_eventType}";
    }
}