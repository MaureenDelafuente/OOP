using System.Threading.Channels;

namespace Inheritance;

public class Horse : Animal
{
    public double MaxSpeed;

    public Horse(double maxSpeed, string name, int age, double weight) : base(name, age, weight)
    {
        MaxSpeed = maxSpeed;
    }
    public override void DoSound()
    {
        Console.WriteLine("Yihihhi");
    }

    public override string Stats()
    {
        return $"{MaxSpeed}, {Name}, {Age}, {Weight}";
    }
}