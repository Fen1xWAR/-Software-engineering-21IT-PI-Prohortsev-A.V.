namespace Lab_6;

public interface IState
{
    public IStrategy Strategy { get; set; }

    public void UseStrategy()
    {
        Strategy.Move();
    }
}