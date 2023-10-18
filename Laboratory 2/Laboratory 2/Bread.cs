namespace Laboratory_2;

public class Bread : ProductBase
{
    public string Grade { get; set; }
    public Bread(int price, int count, string grade) : base(price, count)
    {
        Grade = grade;
    }
}