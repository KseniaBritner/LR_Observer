using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ForengateDisplay : IObserver
    {
        private WeatherDataBase weatherData;
        private float lastPressure;
        private float currentPressure;
        public ForengateDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }
        public ForengateDisplay(WeatherDataEvent weatherData)
        {
            this.weatherData = weatherData;
           weatherData.WeatherChanged += Update;
        }
        public void Update()
        {
            if (weatherData != null)
            {
                lastPressure = currentPressure;
                currentPressure = weatherData.GetPressure();
                Display();
            }
        }
        public void Display()
        {
            Console.WriteLine("Прогноз погоды: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Погода улучшается!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("Продолжается та же погода");
            }
            else
            {
                Console.WriteLine("Ожидайте более прохладной, дождливой погоды");
            }
        }
    }
}
