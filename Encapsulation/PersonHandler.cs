using System.ComponentModel.Design.Serialization;
using System.Runtime.Versioning;

namespace Encapsulation;

public class PersonHandler
{    
    public void SetAge(Person pers, int age)
    {//set property Age of pers to age
        pers.Age = age;
    }

    public Person CreatePerson(int age, string fname, string lname, double height, double weight)
    {
        Person p = new Person(fname, lname);
        p.Age = age;
        p.Height = height;
        p.Weight = weight;
        return p;
    }
    /*    5. När denna klass är klar, kommentera bort er tidigare instans av Person från
Program.cs, och instansiera istället en PersonHandler. Skapa därigenom några
personer och testa era metoder.
        */
    public void ChangeName(Person pers, string fname, string lname)
    {
        pers.FName = fname;
        pers.LName = lname;
    }
    public void ChangeHeight(Person pers, double height)
    {
        pers.Height = height;
    }
    public void ChangeWeight(Person pers, double weight)
    {
        pers.Weight = weight;
    }
}