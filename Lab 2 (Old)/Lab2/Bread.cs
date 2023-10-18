namespace Lab2;

public class Bread : ProductBase
{
    public string Grade { get; set; }
    public Bread(int price, int count, string grade) : base(price, count)
    {
        if (!string.IsNullOrEmpty(grade))
            Grade = grade;
        else
            throw new ArgumentException(null, nameof(grade));
        Grade = grade;
    }
}