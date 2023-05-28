public class StationaryBicycles : Activity
{
    private double speed;

    public StationaryBicycles(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed} mph";
    }
}