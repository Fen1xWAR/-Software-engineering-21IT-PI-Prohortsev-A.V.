namespace ConsoleApp2;

public class Battery
{
    public string Type { get; set; }
    public Int32 Capacity { get; set; }

    public Battery(string type, int capacity)
    {
        if (!string.IsNullOrEmpty(type))
        {
            Type = type; 
        }
        else
        {
            throw new ArgumentException(null, nameof(type));
        }

        if (!(capacity <= 0))
        {
            Capacity = capacity;
        }
        else
        {
            throw new ArgumentException(null, nameof(capacity));
        }
       
    }
}