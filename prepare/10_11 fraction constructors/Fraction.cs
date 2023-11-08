public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void DisplayFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public double DisplayFractionTrueAmount()
    {
        Console.WriteLine($"{(double)_top / (double)_bottom}");
        return 7;
    }




}