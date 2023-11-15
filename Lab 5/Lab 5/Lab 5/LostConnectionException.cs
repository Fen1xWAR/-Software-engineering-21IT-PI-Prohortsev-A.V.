namespace Lab_5;

public class LostConnectionException : Exception
{
    public LostConnectionException(): base("Connection Lost")
    {

    }

}