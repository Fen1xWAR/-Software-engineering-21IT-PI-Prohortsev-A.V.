namespace ConsoleApp2;

public class BatteryList : List<Battery>
{
    public IEnumerable<Battery> SortAaByCapacity()
    {
        return  this.Where(e => e.Type == "AA").OrderBy(e => e.Capacity);
        
    }
}