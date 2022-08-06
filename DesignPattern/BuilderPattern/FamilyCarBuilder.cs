namespace DesignPattern;

public class FamilyCarBuilder : CarBuilder
{
    public override void setEngine()
    {
        carObject.Engine = "1.6 105KM";
    }

    public override void setCarType()
    {
        carObject.Type = "Family";
    }

    public override void setTireSize()
    {
        carObject.TireSize = 16;
    }

    public override void setNumberOfDoors()
    {
        carObject.NUmberOfDoors = 6;
    }
}