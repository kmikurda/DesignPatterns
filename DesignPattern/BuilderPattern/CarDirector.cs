using System.Security.AccessControl;

namespace DesignPattern;

public class CarDirector
{
    public Car MakeCar(CarBuilder builder)
    {
        builder.CreateNewCar();
        builder.setEngine();
        builder.setCarType();
        builder.setTireSize();
        builder.setNumberOfDoors();
        
        return builder.GetCar();
    }
}