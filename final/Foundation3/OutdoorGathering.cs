using System;
class OutdoorGathering : Event
{
    private string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEvent Type: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}