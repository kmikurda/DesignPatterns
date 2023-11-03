namespace Strategy;

public class AutoStrategy : IStrategy
{
    public object Algorithm()
    {
        return new TravelData(TravelCostEnum.Acceptable, TravelTimeEnum.Average);
    }
}