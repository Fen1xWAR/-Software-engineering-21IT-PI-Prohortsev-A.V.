namespace Lab2;

public class ProductList<T> : List<T> where T: ProductBase
{
    public double GetTotalPurchasePrice()=>
        this.Sum(x => x.GetTotalPrice());
}