using System;
using System.Collections.Generic;

namespace Inheritance;

public abstract class Animal
{
    public string Name { get; set; }

    public int Age { get; set; }

    public double Weight { get; set; }

    public Animal(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public abstract void DoSound();

    public abstract string Stats();

    public override string ToString()
    {
        return Name;
    }

}
/*1. Skapa metoden Stats() i klassen Animal som har returtypen string.
Metoden ska kunna overridas i dess Subklasser.Metoden ska returnera alla
egenskaper(properties) som djuret har. */