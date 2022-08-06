namespace DesignPattern;

public class SportCarBuilder : CarBuilder
{
    public override void setEngine()
    {
        carObject.Engine = "5.0 300KM";
    }

    public override void setCarType()
    {
        carObject.Type = "Sport";
    }

    public override void setTireSize()
    {
        carObject.TireSize = 19;
    }

    public override void setNumberOfDoors()
    {
        carObject.NUmberOfDoors = 2;
    }
}