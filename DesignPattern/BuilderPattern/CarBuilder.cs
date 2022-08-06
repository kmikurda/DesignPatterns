namespace DesignPattern;

public abstract class CarBuilder
{
    protected Car carObject;

    public abstract void setEngine();
    public abstract void setTireSize();
    public abstract void setNumberOfDoors();
    public abstract void setCarType();

    public void CreateNewCar()
    {
        carObject = new Car();
    }

    public Car GetCar()
    {
        return carObject;
    }
}