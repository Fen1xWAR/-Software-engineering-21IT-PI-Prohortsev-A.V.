namespace Lab2;

public class Milk : ProductBase
{

    public string FatContent { get; set; }
    public Milk(int price, int count, string fatContent) : base(price, count)
    {
        FatContent = fatContent;
    }
}