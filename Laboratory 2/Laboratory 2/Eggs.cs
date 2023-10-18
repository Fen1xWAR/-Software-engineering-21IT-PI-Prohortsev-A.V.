namespace Laboratory_2;

public class Eggs : ProductBase
{
    public string Categoty { get; set; }

    public Eggs(int price, int count, string categoty) : base(price, count)
    {
        Categoty = categoty;
    }
}