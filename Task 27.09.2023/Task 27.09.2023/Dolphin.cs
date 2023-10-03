namespace Task_27._09._2023;

public class Dolphin: AnimalBase
{
    public byte Age { get; set; }
    public byte Width { get; set; }
    public Dolphin(byte weight, byte age, byte width) : base(weight)
    {
        Age = age;
        Width = width;
    }
}