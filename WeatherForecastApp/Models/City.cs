using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastApp.Models
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "City Name:")]
        public string Name { get; set; }
        [Display(Name = "Temp.")]
        public float Temperature { get; set; }
        [Display(Name="Humidity")]
        public int Humidity { get; set; }
        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }
        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }
        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }
    }
}
