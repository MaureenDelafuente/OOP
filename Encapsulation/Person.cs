using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation;

public class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    public Person(string fName, string lName)
    {
        FName = fName;
        LName = lName;
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Wrong value,age can only be higher than 0");
            }
        }
    }        
    public string FName
    {
        get { return fName;}
        set
        {
            if (value.Length >= 2 || value.Length <= 10)
            {
                fName = value;
            }
            else
            {
                throw new ArgumentException("Wrong value, fName can not be less than 2 or higher than 10 characters");

            }
        }
    }
    public string LName
    {
        get { return lName; }
        set
        {
            if (value.Length >= 3 || value.Length <= 15)
            {
                lName = value;
            }
            else
            {
                throw new ArgumentException("lName can not be less than 3 or more than 15 characters");
            }

        }
    }
    public double Height { get; set; }
    public double Weight { get; set; }
        
}