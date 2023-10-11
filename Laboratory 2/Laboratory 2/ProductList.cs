namespace Laboratory_2;

public class ProductList : List<ProductBase> 
{
    public double GetTotalPurchasePrice()=>
        this.Sum(x => x.GetTotalPrice());
	public void PrintAllElemToConsole()=> this.ForEach(el=>Console.WriteLine(el.Price));
}