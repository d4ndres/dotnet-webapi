using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
// [Route("[controller]")] // http://localhost:5293/weatherforecast/...
[Route("api/[controller]")] // http://localhost:5293/api/weatherforecast/...
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private static List<WeatherForecast> listWeatherForcast = new List<WeatherForecast>();



    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        if( listWeatherForcast == null || !listWeatherForcast.Any() )
        {
            listWeatherForcast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();
        }
    }


    // * GET
    // http://localhost:5293/api/weatherforecast
    [HttpGet(Name = "GetWeatherForecast")]
    // Tambien puede funcionar
    // http://localhost:5293/api/weatherforecas/get/xd
    [Route("get/xd")]
    // O tambien si lo deseo por
    // http://localhost:5293/api/weatherforecas/yolo
    [Route("yolo")]
    // O tambien puedo hacer uso del nombre del metodo
    // http://localhost:5293/api/weatherforecas/yolo
    [Route("[action]")]

    public IEnumerable<WeatherForecast> Getx()
    {
        _logger.LogInformation($"Todo chill perrors {listWeatherForcast[0]}");
        return listWeatherForcast;
    }

    [HttpPost]
    public IActionResult Post( WeatherForecast weatherForecast )
    {
        listWeatherForcast.Add(weatherForecast);
        return Ok();
    }

    [HttpDelete("{index}")]
    public IActionResult Delete( int index )
    {
        listWeatherForcast.RemoveAt(index);
        return Ok();
    }

}
