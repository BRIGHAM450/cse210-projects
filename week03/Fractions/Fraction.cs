using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Default constructor: 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with only the numerator (denominator defaults to 1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom); // use setter to avoid zero denominator
    }

    // Getter and Setter for numerator
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int value)
    {
        _top = value;
    }

    // Getter and Setter for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int value)
    {
        if (value != 0) // prevent division by zero
        {
            _bottom = value;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero. Defaulting to 1.");
            _bottom = 1;
        }
    }

    // Return the fraction as "a/b"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
