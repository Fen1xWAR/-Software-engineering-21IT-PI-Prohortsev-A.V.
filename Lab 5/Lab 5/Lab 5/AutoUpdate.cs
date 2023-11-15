namespace Lab_5;

public class AutoUpdate
{
    public void GetNewData(bool isConnected)
    {
        if (!isConnected)
        {
            throw new LostConnectionException();
        }
        else
        {
            Console.WriteLine("New data successfully loaded");
        }
    }
}