namespace Inheritance;

public class Wolf :Animal
{
    public bool IsCastrated;

    public Wolf(bool isCastrated, string name, int age, double weight) : base(name, age, weight)
    {
        IsCastrated = isCastrated;
    }

    public override void DoSound()
    {
        Console.WriteLine("Auuuu");
    }
    public override string Stats()
    {
        return $"{IsCastrated}, {Name}, {Age}, {Weight}";
    }
}