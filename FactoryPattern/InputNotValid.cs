namespace FactoryPattern;

public class InputNotValid : IOrderShoes
{
    public void ShoeType()
    {
        Console.WriteLine("Sorry, we do not understand your answer.");
    }
}