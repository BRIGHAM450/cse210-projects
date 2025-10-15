using System;

public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance()
    {
        return (GetSpeed() * GetLength()) / 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
