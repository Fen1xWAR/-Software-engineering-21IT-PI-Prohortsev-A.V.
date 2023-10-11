namespace Lab2;

public class Eggs : ProductBase
{
    public string Categoty { get; set; }

    public Eggs(int price, int count, string categoty) : base(price, count)
    {
        if (!string.IsNullOrEmpty(categoty))
            Categoty = categoty;
        else
            throw new ArgumentException(null, nameof(categoty));
        Categoty = categoty;
    }
}