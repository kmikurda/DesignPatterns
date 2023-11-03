namespace Strategy;

public struct TravelData
{
    public TravelCostEnum Cost { get; init; }
    public TravelTimeEnum Time { get; init; }
    
    public TravelData( TravelCostEnum cost, TravelTimeEnum time)
    {
        Cost = cost;
        Time = time;
    }
}