using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastApp.Models;
using WeatherForecastApp.OpenWeatherMap_Model;
using WeatherForecastApp.Repositories;
using WeatherForecastApp.Controllers;

namespace WeatherForecastApp.Controllers
{
    public class WForecastRepository : Controller
    {
        private readonly IWForecastRepository _WForecastRepository;

        public WForecastRepository(IWForecastRepository wForecastRepository)
        {
            _WForecastRepository = WForecastRepository;
        }

        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new { city = model.CityName });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            City viewModel = new City();
            WeatherResponse weatherResponse = _WForecastRepository.GetForecast(city);

            if (weatherResponse !=null)
            {
                viewModel.Name = weatherResponse.Name;
                viewModel.Temperature = weatherResponse.Main.Temp;
                viewModel.Humidity = weatherResponse.Main.Humidity;
                viewModel.Pressure = weatherResponse.Main.Pressure;
                viewModel.Weather = weatherResponse.Weather[0].Main;
                viewModel.Wind = weatherResponse.Wind.Speed;
            } 
            return View(viewModel);
        }
    }
}
