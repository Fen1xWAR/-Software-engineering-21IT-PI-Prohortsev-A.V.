// See https://aka.ms/new-console-template for more information

namespace ConsoleApp2;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        var battery = new Battery("AA", 20);
        var battery2 = new Battery("AA", 15);
        var battery3 = new Battery("AA", 11);
        var battery4 = new Battery("AAA", 20);
        var list = new BatteryList{battery,battery2,battery3,battery4};
        list.ForEach(e=> Console.WriteLine(e.Capacity));
        Console.WriteLine();
        
        foreach (var battery1 in list.SortAaByCapacity())
        {
            Console.WriteLine(battery1.Capacity);
        }

    }
}