using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Polymorphism;

public class NumericInputError : UserError
{
    public override string UEMessage()
    {
        string message = "You tried to use a numeric input in a text only field. This fired an error!”";
        return message;
    }
}