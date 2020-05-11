using System;

namespace MyCoreWebAPI
{
    public class WeatherForecast
    {
        //weatherforcast model
        public DateTime Date { get; set; }

        public int TemperatureCelcius { get; set; }

        public int TemperatureFahrenheit => 32 + (int)(TemperatureCelcius / 0.5556);

        public string Summary { get; set; }

    }
}
