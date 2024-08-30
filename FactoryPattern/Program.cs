namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" +
                              "Welcome to our made-to-order shoe factory.\n" +
                              "Please select from the following options:\n" +
                              "1 - Running Shoes\n" +
                              "2 - Dress Shoes\n" +
                              "3 - Sandals");
            
            //Create new variable for user input
            var userInput = Console.ReadLine();
            
            //Variable Type is Interface Name, new variable name "shoes", Static Factory Class(ShoeFactory).Method (parameters are for new user input variable).
            IOrderShoes shoes = ShoeFactory.GetShoeType(userInput);
            
            //Variable name for Interface, then .Method (in interface)
            shoes.ShoeType();
        }
    }
}
