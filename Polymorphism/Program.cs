using System.ComponentModel;
using System.Data;

namespace Polymorphism;

internal class Program
{
    static void Main(string[] args)
    {
        List<UserError> errors = new List<UserError>();
        errors.Add(new NumericInputError());
        errors.Add(new TextInputError());
        errors.Add(new Error1());
        errors.Add(new Error2());
        errors.Add(new Error3());
            
        foreach (UserError userError in errors)
        {
            Console.WriteLine(userError.UEMessage());
        }
    }
}