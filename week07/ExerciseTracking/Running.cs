using System;

public class Running : Activity
{
    private double _distance; // in km

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}