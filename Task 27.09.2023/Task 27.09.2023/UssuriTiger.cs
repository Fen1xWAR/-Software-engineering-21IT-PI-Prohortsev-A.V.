namespace Task_27._09._2023;

public class UssuriTiger : LandAnimalsBase
{
    public string Habitat { get; set; }
    public int Count { get; set; }
    public UssuriTiger(byte weight, byte height, string habitat) : base(weight, height)
    {
        Habitat = habitat;
    }
}