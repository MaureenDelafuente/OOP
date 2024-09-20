namespace Inheritance;

public class Bird : Animal
{
    public int WingSpan;

    public Bird(int wingSpan, string name, int age, double weight) : base(name, age, weight)
    {
        WingSpan = wingSpan;
    }
    public override void DoSound()
    {
        Console.WriteLine("Firifiri");
    }

    public override string Stats()
    {
        return $"{WingSpan}, {Name}, {Age}, {Weight}";
    }
}