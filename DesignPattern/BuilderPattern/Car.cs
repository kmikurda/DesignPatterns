namespace DesignPattern;

public class Car
{
    public string Type { get; set; }
    public string Engine { get; set; }
    public int NUmberOfDoors { get; set; }
    public int TireSize { get; set; }

    public void DisplayParameters()
    {
        Console.WriteLine("Car parameter details: ");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"NumberOfDoors: {NUmberOfDoors}");
        Console.WriteLine($"Tire Size: {TireSize}");
        Console.WriteLine($"Engige: {Engine}");
        Console.WriteLine("__________________");
    }
}