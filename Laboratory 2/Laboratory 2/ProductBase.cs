namespace Laboratory_2;

public abstract class ProductBase
{
    public int Price { get; set; }
    public int Count { get; set; }

    public double GetTotalPrice() => Price * Count;

    protected ProductBase(int price, int count)
    {
        Price = price;
        Count = count;
    }
}