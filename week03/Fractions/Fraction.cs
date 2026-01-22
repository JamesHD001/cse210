public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public Fraction(int FirstNumber, int SecondNumber)
    {
        _top = FirstNumber;
        _bottom = SecondNumber;
    }

    public string GetFractionString()
    {
         string Fraction = ($"{_top}/{_bottom}");
         return Fraction;
    }

    public double GetDecimalValue()
    {
        
        double number =  (double)_top /  _bottom;
        return number;
    }
    public int GetTop() {
        return _top;
    }

    public void SetTop(int top) {
        _top = top;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void SetBottom(int bottom) {
        _bottom = bottom;
    }

}