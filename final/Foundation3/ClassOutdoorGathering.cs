class OutdoorGathering : Event
{
    private string weatherForecast;

    public string WeatherForecast
    {
        get { return weatherForecast; }
        set { weatherForecast = value; }
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}
