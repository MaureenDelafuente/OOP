using System.ComponentModel;
using System.Xml.Linq;

namespace Inheritance;

public class Flamingo : Bird
{
    public string Race;

    public Flamingo(string race, string name, int age, double weight, int wingSpan) : base(wingSpan, name, age, weight)
    {
        Race = race;
    }
    public override string Stats()
    {
        return $"{Race}, {WingSpan}, {Name}, {Age}, {Weight}";
    }

   
}