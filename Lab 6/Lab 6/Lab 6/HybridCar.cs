namespace Lab_6;

public class HybridCar
{
    private Dictionary<string, IState?> States = new Dictionary<string, IState?>()
    {
        { "ElectricMode", new ElectricityState()},
        {"GasMode", new GasState()}
    };

    public HybridCar(string state = null)
    {
        SetState(state ?? "ElectricMode");
    }

    public void SetState(string StateName)
    {
        if (States.TryGetValue(StateName, out IState? newState))
        {
            State = newState;
        }
        else
        {
            throw new ArgumentException("UnsupportedState!");
        }
    }
    private IState State { get; set; }

    public void Move()
    {
        State.UseStrategy();
    }
}