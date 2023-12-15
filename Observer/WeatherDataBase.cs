using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class WeatherDataBase
    {
        private float temperature;
        private float humidity;
        private float pressure;

        protected abstract void Notify();

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Notify();
        }
        public float GetTemperature()
        {
            return temperature;
        }
        public float GetHumidity()
        {
            return humidity;
        }
        public float GetPressure()
        {
            return pressure;
        }
    }
}
