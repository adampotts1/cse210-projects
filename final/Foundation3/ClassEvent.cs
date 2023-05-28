class Event
{
    private string eventTitle;
    private string eventDescription;
    private DateTime eventDate;
    private TimeSpan eventTime;
    private Address eventAddress;

    public string EventTitle
    {
        get { return eventTitle; }
        set { eventTitle = value; }
    }

    public string EventDescription
    {
        get { return eventDescription; }
        set { eventDescription = value; }
    }

    public DateTime EventDate
    {
        get { return eventDate; }
        set { eventDate = value; }
    }

    public TimeSpan EventTime
    {
        get { return eventTime; }
        set { eventTime = value; }
    }

    public Address EventAddress
    {
        get { return eventAddress; }
        set { eventAddress = value; }
    }

    public virtual string GetStandardDetails()
    {
        return $"Event: {eventTitle}\nDescription: {eventDescription}\nDate: {eventDate.ToShortDateString()}\nTime: {eventTime}\nAddress: {eventAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Generic Event\nEvent: {eventTitle}\nDate: {eventDate.ToShortDateString()}";
    }
}
