namespace Inheritance;

public class Hedgehog : Animal
{
    public int NrOfSpikes;

    public Hedgehog(int nrOfSpikes, string name, int age, double weight) : base(name, age, weight)
    {
        NrOfSpikes = nrOfSpikes;
    }

    public override void DoSound()
    {
        Console.WriteLine("Shoshoshosho");
    }
    public override string Stats()
    {
        return $"{NrOfSpikes}, {Name}, {Age}, {Weight}";
    }
}