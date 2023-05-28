public class Swimming : Activity

{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // kilometers
    }

    public override double GetPace()
    {
        return length / (laps / 2.0); // minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Pace: {GetPace()} min per km";
    }
}