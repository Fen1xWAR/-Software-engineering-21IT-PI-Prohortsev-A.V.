namespace Task_27._09._2023;

public abstract class AnimalBase
{
    public byte Weight { get; set; }

    protected AnimalBase(byte weight)
    {
        Weight = weight;
    }
}

