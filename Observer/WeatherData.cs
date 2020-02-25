using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class WeatherData : Subject
    {
        private float Temp;
        private float Humidity;
        private float Pressure;
        private List<Interfaces.Observer> Observers;
        public WeatherData()
        {
            Observers = new List<Interfaces.Observer>();
        }
        public void NotifyObservers()
        {
            for(int i = 0; i < Observers.Count; i++)
            {
                Observers[i].Update(Temp, Humidity, Pressure);
            }
        }

        public void RegisterObserver(Interfaces.Observer o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(Interfaces.Observer o)
        {
            Observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            Temp = temp;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
