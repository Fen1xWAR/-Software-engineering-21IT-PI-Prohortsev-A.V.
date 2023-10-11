namespace Laboratory_2;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        ProductList list = new ProductList{
            new Milk(70,2,"3.2%"),
            new Bread(100,10,"Borodinskiy"),
            new Eggs(90,2,"C0")
            };
        
        Console.WriteLine(list.GetTotalPurchasePrice());
        list.PrintAllElemToConsole();
            
           
        

    }
}