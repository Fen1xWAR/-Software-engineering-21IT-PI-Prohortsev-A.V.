namespace Task_27._09._2023;

public abstract class LandAnimalsBase : AnimalBase
{
    public byte Height { get; set; }

    protected LandAnimalsBase(byte weight, byte height) : base(weight)
    {
        Height = height;
    }
}