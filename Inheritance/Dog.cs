using System.Diagnostics;

namespace Inheritance;

public class Dog : Animal
{
    public int NrOfMealsPerDay;

    public Dog(int nrOfMealsPerDay, string name, int age, double weight) : base(name, age, weight)
    {
        NrOfMealsPerDay = nrOfMealsPerDay;
    }
    public override void DoSound()
    {
        Console.WriteLine("Guauguau");
    }
    public override string Stats()
    {
        return $"{NrOfMealsPerDay}, {Name}, {Age}, {Weight}";
    }

    public string TypeOfFood()
    {
        return "Wet Food";
    }
    
}