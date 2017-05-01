using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, condition, location, tempHigh, tempLow, identity, windDirection, visibility;

        public Day()
        {
            date = currentTemp = condition = location = tempHigh = tempLow = identity = windDirection = visibility = "";
        }
    }
}
