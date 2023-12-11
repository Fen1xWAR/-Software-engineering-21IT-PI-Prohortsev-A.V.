namespace Lab_6;

public class GasState : IState
{
    public IStrategy Strategy { get; set; } = new FuelStratege();
   
}