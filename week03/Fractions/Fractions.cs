public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
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

    public string GetFraction()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimal()
    {   
        double Decimal = _top/_bottom;
        return Decimal;
    }
}