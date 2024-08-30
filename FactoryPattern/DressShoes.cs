namespace FactoryPattern;

public class DressShoes : IOrderShoes
{
    public void ShoeType()
    {
        Console.WriteLine("Got it! Dress Shoes it is.");
    }

    // public void ShoeColor()
    // {
    //     Console.WriteLine($"Perfect. We can definitely make your dress shoes {shoeColor}");
    // }
    //
    // public void ShoeSize()
    // {
    //     Console.WriteLine($"Sounds great. Your {shoeColor} dress shoes will be size {shoeSize}.");
    // }
}