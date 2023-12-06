namespace Lab_6;

public class ElectricityState : IState
{
    public IStrategy Strategy { get; set; } = new ELectrisityStratege();
    
    
}