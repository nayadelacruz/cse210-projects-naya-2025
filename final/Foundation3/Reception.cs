using System;
class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string eventTitle, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address address, string eventType, string rsvpEmail)
    : base (eventTitle, eventDescription, eventDate, eventTime, address, "Reception")
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}