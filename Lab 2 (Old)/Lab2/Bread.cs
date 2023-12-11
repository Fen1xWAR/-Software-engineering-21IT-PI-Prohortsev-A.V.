using Lab2;

namespace ConsoleApp1;

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