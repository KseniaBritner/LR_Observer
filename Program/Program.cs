using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;

namespace Observer
{
    internal class Program
    {
        static void Main()
        {
            WeatherData weatherData = new WeatherData();
            GeneralDisplay generalDisplay = new GeneralDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForengateDisplay forengateDisplay = new ForengateDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30);
            weatherData.SetMeasurements(82, 70, 29);
            weatherData.SetMeasurements(78, 90, 29);
            Console.ReadLine();
        }
    }
}
