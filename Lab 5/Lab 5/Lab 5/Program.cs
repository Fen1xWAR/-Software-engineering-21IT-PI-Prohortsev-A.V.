namespace Lab_5;

internal abstract class Program
{
    static void Main(string[] args)
    {
        var upd = new AutoUpdate();
        try
        {
            upd.GetNewData(false);
        }
        catch (LostConnectionException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}