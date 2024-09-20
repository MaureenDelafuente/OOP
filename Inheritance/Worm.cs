using System.Diagnostics;

namespace Inheritance;

public class Worm : Animal
{
    public bool IsPoisonous;
    public Worm(bool isPoisonous, string name, int age, double weight) : base(name, age, weight)
    {
        IsPoisonous = isPoisonous;
    }
    public override void DoSound()
    {
        Console.WriteLine("Chlichlichli");
    }
    public override string Stats()
    {
        return $"{IsPoisonous}, {Name}, {Age}, {Weight}";
    }
}