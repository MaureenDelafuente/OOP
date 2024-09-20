using System.ComponentModel;
using static System.Net.WebRequestMethods;
using System.Diagnostics.Metrics;

namespace Inheritance;

internal class Program
{
    public List<Animal> Animals = new List<Animal>();
    public List<Dog> Dogs = new List<Dog>();
        

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.Animals.Add(new Dog(3,"Cookie", 1, 5.6));
        program.Animals.Add(new Flamingo("DarkTail","Pipo",2, 5.6, 3));
        //program.Dogs.Add(new Horse(maxSpeed:34,"Andrea", 4, 60));
        //F: De är inte kompatibla, horse är inte en subklass till Dog
        //F: Listen borde vara Animal så at alla klasser kan lagras där
        //F13: Den skriver ut stats av varje instance av animals och den använder den overskuggade stats i 
        //respektive subklass
        foreach (Animal a in program.Animals)
        {
            Console.WriteLine(a);
            a.DoSound();

            if (a is IPerson)
            {
                ((IPerson)a).Talk();
            }
        }

        foreach (Animal a in program.Animals)
        {
            Console.WriteLine(a.Stats());
        }
        foreach(Animal a in program.Animals)
        {
            if (a is Dog)
            {
                Console.WriteLine(a.Stats());
                //Console.WriteLine(a.TypeOfFood());
                //F17 no,e because the method is only for Dog class,
                //and I am using Dog object as an animal object
            }
        }

        foreach (Animal a in program.Animals)
        {
            if (a is Dog)
            {
                Dog aDog = (Dog) a;
                Console.WriteLine(aDog.TypeOfFood());
            }
        }
    }
}
/*Om under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
attribut, i vilken klass bör det ligga? Bird
Om alla djur behöver det nya attributet, vart skulle man lägga det då? Animal
*/



 