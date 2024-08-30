using Microsoft.VisualBasic.CompilerServices;

namespace FactoryPattern;

public static class ShoeFactory
{
    public static IOrderShoes GetShoeType(string shoeType)
    {
        switch (shoeType.ToLower())
        {
            case "1":
            case "running shoes":
            case "running":
                return new RunningShoes();
            case "2":
            case "dress shoes":
            case "dress":
                return new DressShoes();
            case "3":
            case "sandals":
                return new Sandals();
            default:
                return new InputNotValid();
        }
    }

// public static IOrderShoes GetShoeColor(string shoeColor)
    // {
    //     switch (shoeColor.ToLower())
    //     {
    //         case Console.ReadLine()
    //     }
    // }
}