namespace Inheritance;

public class Pelican : Bird

{
    public double ThroatPouchSize;
    public Pelican(double throatPouchSize, int wingSpan,  string name, int age, double weight) : base(wingSpan, name, age, weight)
    {
        ThroatPouchSize = throatPouchSize;
    }
    public override string Stats()
    {
        return $"{ThroatPouchSize}, {WingSpan}, {Name}, {Age}, {Weight}";
    }
}