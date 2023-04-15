using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult Get()
        {
            _logger.Log(LogLevel.Debug, "Iniciando get da aplicação");
            return Ok();
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public ActionResult Post(WeatherForecast en)
        {
            _logger.Log(LogLevel.Debug, "Iniciando get da aplicação");
            return Ok(en);
        }
    }
}