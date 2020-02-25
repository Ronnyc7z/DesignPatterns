using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace Observer
{
    public class CurrentConditionsDisplay : Interfaces.Observer, Interfaces.DisplayElement
    {
        private float Temp;
        private float Pressure;
        private Subject WeatherData { get; set; }
        public CurrentConditionsDisplay(Interfaces.Subject weatherData)
        {
            WeatherData = weatherData;
        }

        public void Display()
        {
            Console.WriteLine($"Temperature is at: {Temp} // Pressure is at: {Pressure}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temp = temp;
            Pressure = pressure;
            Display();
        }
    }
}
