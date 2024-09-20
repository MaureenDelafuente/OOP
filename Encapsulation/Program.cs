using System.Security.Cryptography.X509Certificates;

namespace Encapsulation;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        PersonHandler ph = new PersonHandler();
        try
        {
            //Person p = new Person("Elon", "Musk");
            Person p1 = ph.CreatePerson(40, "Mark", "Zuckerberg", 1.82, 80);
            Person p2 = ph.CreatePerson(56, "Elon", "Musk", 1.80, 86);
            people.Add(p1);
            people.Add(p2);
            ph.ChangeName(p1, "Mr", "Beast");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        //p.age;
        //p.Age;
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.FName} {person.LName}");
        }

        Console.ReadLine();
    }
}