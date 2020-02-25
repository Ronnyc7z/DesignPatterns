using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Observer demo:");
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay display1 = new CurrentConditionsDisplay(weatherData);
            weatherData.RegisterObserver(display1);
            weatherData.SetMeasurements(20.3f, 50, 12);
            weatherData.SetMeasurements(23.1f, 55, 17);
        }
    }
}
