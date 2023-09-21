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

    public Copybook(decimal price, string manufacter, string lineType, int listCount)
    {
        Price = price;
        Manufacter = manufacter;
        LineType = lineType;
        ListCount = listCount;
    }
    
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

    public Pensil(decimal price, string manufacter, string lineColor, string hardness, float width)
    {
        Price = price;
        Manufacter = manufacter;
        LineColor = lineColor;
        Hardness = hardness;
        Width = width;
    }
}

public class Marker : WrittingDevicesBase, IChangebleLineHeight
{
   

    public float LineHeight { get; set; }
    
    
}


