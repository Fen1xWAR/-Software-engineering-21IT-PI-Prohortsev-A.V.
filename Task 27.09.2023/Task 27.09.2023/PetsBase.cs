namespace Task_27._09._2023;

public abstract class PetsBase : LandAnimalsBase
{
    public string Breed { get; set; }
    protected PetsBase(byte weight, byte height, string breed) : base(weight, height)
    {
        if (string.IsNullOrEmpty(breed))
        {
            throw new ArgumentException(nameof(breed));
        }
        Breed = breed;
    }
}