class Reception : Event
{
    private string rsvpEmail;

    public string RsvpEmail
    {
        get { return rsvpEmail; }
        set { rsvpEmail = value; }
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

