using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherDataEvent : WeatherDataBase
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public event Action WeatherChanged;

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            OnWeatherChanged();
        }
        protected virtual void OnWeatherChanged()
        {
            WeatherChanged.Invoke();
        }
        public float GetTemperatureEvent()
        {
            return temperature;
        }
        public float GetHumidityEvent()
        {
            return humidity;
        }
        public float GetPressureEvent()
        {
            return pressure;
        }
        protected override void Notify()
        {
        }
    }
}
