Outdoors Gatherings Class:
public class OutdoorGathering : Event
{
    // Track Weather Forecasts
    private string weatherForecast;
    public string WeatherForecast { get { return weatherForecast; } set { weatherForecast = value; } }

    // Generate a statement of the weather
    public string GenerateMessage()
    {
        return $"{base.GenerateMessage()}, {weatherForecast}";
    }
}