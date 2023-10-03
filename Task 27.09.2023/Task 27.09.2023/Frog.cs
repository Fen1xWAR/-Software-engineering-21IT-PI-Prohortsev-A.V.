using static System.String;

namespace Task_27._09._2023;

public class Frog : AnimalBase
{
    public string Color { get; set; }
    public bool IsToxic { get; set; }
    public Frog(byte weight, string color, bool isToxic) : base(weight)
    {
        if (IsNullOrEmpty(color))
        {
            throw new ArgumentException(nameof(color));

        }
        Color = color;
        IsToxic = isToxic;
    }
}