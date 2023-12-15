using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class GeneralDisplay : IObserver
    {
        private WeatherDataBase weatherData;
        public GeneralDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this);
        }
        public GeneralDisplay(WeatherDataEvent weatherData)
        {
            this.weatherData = weatherData;
            weatherData.WeatherChanged += Update;
        }
        public void Update()   
        {
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Общие значения: " + weatherData.GetTemperature() + "градусов по Фаренгейту и " + weatherData.GetHumidity() + "% влажности");
        }
    }
}
