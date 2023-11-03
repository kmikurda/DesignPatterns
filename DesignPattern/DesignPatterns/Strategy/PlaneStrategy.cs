namespace Strategy;

public class PlaneStrategy : IStrategy
{
    public object Algorithm()
    {
        return new TravelData(TravelCostEnum.TooExpensive, TravelTimeEnum.Fast);
    }
}