// See https://aka.ms/new-console-template for more information

namespace Lab_6;

public static class Program
{
    public static void Main(string[] args)
    {
        var car = new HybridCar();
        car.Move();
        car.SetState("GasMode");
        car.Move();
    }
}