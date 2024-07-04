<<<<<<< HEAD
using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // is just number 1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
       
       return (double)_top / (double)_bottom;
    }
=======
using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // is just number 1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
       return (double)_top / (double)_bottom;
    }
>>>>>>> a889faa156b6abf8bc715541c86b14ba20c0869c
}