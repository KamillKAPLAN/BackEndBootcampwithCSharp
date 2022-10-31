using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastsController : ControllerBase
    {
        private readonly ILogger<WeatherForecastsController> _logger;
        WeatherForecast weather = new WeatherForecast();
        public WeatherForecastsController(ILogger<WeatherForecastsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return weather.GetAllWeather();
        }

        /* public WeatherForecast GetMetot(int id, [FromQuery] int idd) */
        [HttpGet("{id}")]
        public WeatherForecast Get(int id)
        {
            return weather.GetAllWeather().Find(x => x.Id == id);
        }

        [HttpPost]
        public List<WeatherForecast> Post([FromBody] WeatherForecast weatherForecast)
        {
            var postData = weather.GetAllWeather();
            postData.Add(weatherForecast);
            return postData;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WeatherForecast weatherForecast)
        {
            if (id != weatherForecast.Id)
                return BadRequest();

            var postData = weather.GetAllWeather();
            var updateData = postData.Find(x => x.Id == weatherForecast.Id);
            updateData.Summary = weatherForecast.Summary;
            updateData.TemperatureC = weatherForecast.TemperatureC;
            updateData.Date = weatherForecast.Date;
            return Ok("Başarılı");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var postData = weather.GetAllWeather();

            if (postData == null)
                return NotFound();

            var deleteWeather = postData.Find(x => x.Id == id);
            if (deleteWeather == null)
                return NotFound();
            
            var result = postData.Remove(deleteWeather);
            if (result)
                return Ok($"{weather.Summary} başarıyla silindi.");
            return BadRequest($"{weather.Summary} silinemedi.");
        }

    }
}
