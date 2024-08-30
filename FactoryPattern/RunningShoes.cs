namespace FactoryPattern;

public class RunningShoes : IOrderShoes
{
    public void ShoeType()
    {
        Console.WriteLine("Got it! Running Shoes it is.");
    }

    // public void ShoeColor()
    // {
    //     Console.WriteLine($"Perfect. We can definitely make your running shoes {shoeColor}");
    // }
    //
    // public void ShoeSize()
    // {
    //     Console.WriteLine($"Sounds great. Your {shoeColor} running shoes will be size {shoeSize}.");
    // }
}