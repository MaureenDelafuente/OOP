using System.Diagnostics;

namespace Inheritance;

public class Wolfman : Wolf, IPerson
{
    public string Sex;
    public Wolfman(string sex, bool isCastrated, string name, int age, double weight) : base(isCastrated, name, age, weight)
    {
        Sex = sex;
    }
    public void Talk()
    {
        Console.WriteLine("I am a wolfman");
    }
    public override string Stats()
    {
        return $"{IsCastrated}, {Name}, {Age}, {Weight}";
    }
}