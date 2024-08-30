namespace FactoryPattern;

public class Sandals : IOrderShoes
{
    public void ShoeType()
    {
        Console.WriteLine("Got it! Sandals it is.");
    }

    // public void ShoeColor()
    // {
    //     Console.WriteLine($"Perfect. We can definitely make your sandals {shoeColor}");
    // }
    //
    // public void ShoeSize()
    // {
    //     Console.WriteLine($"Sounds great. Your {shoeColor} sandals will be size {shoeSize}.");
    // }
}