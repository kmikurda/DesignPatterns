namespace Builder;

public interface IBuilder
{
    void AddWheels();
    void PutEngine();
    void AddFifthDoor();
}

public class Builder : IBuilder
{
    private Car _car = new Car();
    public Builder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._car = new Car();
    }
    
    public void AddWheels() => _car.Add("Wheels");
    public void PutEngine() => _car.Add("Engine");
    public void AddFifthDoor() => _car.Add("Fifth Door");
    public Car GetCar() => _car;
}

public class Director
{
    private readonly IBuilder _builder = new Builder();
    

    public void BuildSportCar()
    {
        _builder.AddWheels();
        _builder.PutEngine();
    }
    public void BuildNormalCar()
    {
        _builder.AddWheels();
        _builder.PutEngine();
        _builder.AddFifthDoor();
    }
    
    
}

public class Car
{
    private List<string> _parts = new List<string>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void PartList()
    {
        Console.WriteLine("Car Parts: ");
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
    
}