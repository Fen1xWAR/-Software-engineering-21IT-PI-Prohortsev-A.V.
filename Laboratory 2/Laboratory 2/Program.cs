using System.Text.Json;

namespace Laboratory_2;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        var M1 = new Milk(70, 2, "3.2%");
        ProductList list = new ProductList{
            new Milk(70,2,"3.2%"),
            new Bread(100,10,"Borodinskiy"),
            new Eggs(90,2,"C0")
            };
        
        Console.WriteLine(list.GetTotalPurchasePrice());
        list.PrintAllElemToConsole();
        using (var fileStream = new FileStream("test.json",FileMode.Create))
        {
            JsonSerializer.Serialize(fileStream, M1, typeof(Milk));
            
        }
          
           
        

    }
}