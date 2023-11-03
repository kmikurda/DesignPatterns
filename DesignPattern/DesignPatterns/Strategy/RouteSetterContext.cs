using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Strategy;

public class RouteSetterContext
{
    private IStrategy _strategy;

    public RouteSetterContext()
    {
        
    }
    public RouteSetterContext(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetTravelRoute()
    {
        var result = _strategy.Algorithm();
        Console.WriteLine(JsonConvert.SerializeObject(result));
    }
}