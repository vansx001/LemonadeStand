using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
        public class Weather
    {
        Random random = new Random();
        List<string> weatherConditionName = new List<string>();
        int predictedTemperature;
        string weatherCondition;

        public Weather()
        {
        }

        public void SetPredictedTemperature()
        {
            predictedTemperature = random.Next(70, 100);
        }

        public void GetWeatherForecast()
        {
            Console.Clear();
            SetPredictedWeatherCondition();
            SetPredictedTemperature();
            Console.WriteLine("Today's weather forecast is {0} at {1}° F.\n", GetWeatherCondition(), GetPredictedTemperature());
        }

        public void SetPredictedWeatherCondition()
        {

            weatherConditionName.Add("rainy");
            weatherConditionName.Add("cloudy");
            weatherConditionName.Add("sunny");

            weatherCondition = weatherConditionName[random.Next(1, 3)];
        }
        public string GetWeatherCondition()
        {
            return weatherCondition;
        }

        public int GetPredictedTemperature()
        {
            return predictedTemperature;
        }


    }
}
