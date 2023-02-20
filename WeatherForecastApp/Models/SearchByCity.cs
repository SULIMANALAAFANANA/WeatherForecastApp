using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastApp.Models
{
    public class SearchByCity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="City name is empty!")]
        [Display(Name ="City Name")]
        [StringLength(30,MinimumLength =2, ErrorMessage ="Invalid Input, Length must be between 2 to 20 characters")]
        public string CityName { get; set; }
    }
}
