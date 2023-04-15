using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private IHomeService _homeService;
        public HomeController(ILogger<WeatherForecastController> logger, IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        // GET: HomeController
        [HttpGet(Name = "Home")]
        public ActionResult BuscarHome()
        {


            return Ok();
        }


        [HttpPost(Name = "PostHome")]
        public ActionResult Post(Home en)
        {
            _logger.Log(LogLevel.Debug, "Iniciando get da aplicação");
            return Ok(en);
        }
    }
}
