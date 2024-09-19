namespace Polymorphism;

public class TextInputError : UserError
{
    public override string UEMessage()
    {
        string message = "You tried to use a text input in a numeric only field. This fired an error!";
        return message;
    }
}