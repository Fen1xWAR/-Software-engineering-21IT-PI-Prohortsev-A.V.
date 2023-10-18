namespace Lab2;

public abstract class ProductBase
{
    private int Price { get; set; }
    private int Count { get; set; }

    public double GetTotalPrice() => Price * Count;

    protected ProductBase(int price, int count)
    {
        Price = price;
        Count = count;
    }
}