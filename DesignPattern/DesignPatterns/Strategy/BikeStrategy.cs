namespace Strategy;

public class BikeStrategy : IStrategy
{
    public object Algorithm()
    {
        return new TravelData(TravelCostEnum.Free, TravelTimeEnum.Slow);
    }
}