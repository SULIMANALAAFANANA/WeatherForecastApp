﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastApp.OpenWeatherMap_Model
{
    public class Sys
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public float Message { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunshine { get; set; }
    }
}
