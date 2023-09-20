// See https://aka.ms/new-console-template for more information

using System.Text;

namespace Task_20._09._2023;

public abstract class ItemBase
{
    public decimal Price { get; set; }
    public string Manufacter { get; set; }
}

public class Copybook : ItemBase
{
    public string LineType { get; set; }
    public int ListCount { get; set; }
}

public abstract class WrittingDevicesBase : ItemBase
{
    public string LineColor { get; set; }
    
    
}

interface IChangebleLineHeight
{
    public float LineHeight { get; set; }
}


public class GelPen : WrittingDevicesBase, IChangebleLineHeight
{
    public byte GelWight { get; set; }
    public float LineHeight { get; set; }

    public GelPen(decimal price, string manufacter, string lineColor, byte gelWight,float lineHeight)
    {
        Price = price;
        Manufacter = manufacter;
        LineColor = lineColor;
        GelWight = gelWight;
        LineHeight = lineHeight;
    }
}

public class BallPointPen : WrittingDevicesBase, IChangebleLineHeight
{
    public Boolean IsChangebleRod { get; set; }
    public float LineHeight { get; set; }
}

public class Pensil : WrittingDevicesBase
{
    public string Hardness { get; set; }
    public float Width { get; set; }
}

public class Marker : WrittingDevicesBase, IChangebleLineHeight
{
    public float LineHeight { get; set; }
}

public abstract class Program
{
    
    public static void Main(string[] args)
    {
        GelPen pen1 = new GelPen(100, "Brauberg", "black", 20, 0.5f);
        GelPen pen2 = new GelPen(100, "Brauberg", "black", 20, 0.5f);
        List<ItemBase> items = new List<ItemBase>() 
        { 
            pen1, pen2
        };
        StringBuilder result = new StringBuilder();
        result.Append("Цена: " + pen1.Price + "\n");
        result.Append("Производитель: " + pen1.Manufacter + "\n");
        result.Append("Цвет линии: " + pen1.LineColor + "\n");
        result.Append("Масса геля: " + pen1.GelWight + "\n");
        result.Append("Ширина линии: " + pen1.LineHeight);
        Console.WriteLine(result.ToString());
        foreach (var obj in items)
        {
            Console.WriteLine(obj is WrittingDevicesBase);
        }
        
    }
}
