namespace Inheritance;

public class Swan : Bird
{
    public double NeckLength;

    public Swan(double neckLength, int wingSpan, string name, int age, double weight) : base(wingSpan, name, age, weight)
    {
        NeckLength = neckLength;
    }
    public override string Stats()
    {
        return $"{NeckLength}, {WingSpan}, {Name}, {Age}, {Weight}";
    }
}