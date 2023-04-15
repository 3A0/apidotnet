using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TvBmwController1 : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private ITvBmwService _tvbmwService;
        public TvBmwController1(ILogger<WeatherForecastController> logger, ITvBmwService tvbmwService)
        {
            _logger = logger;
            _tvbmwService = tvbmwService;
        }

        [HttpGet(Name = "BuscarTvBmw")]
        public IActionResult BuscarTvBmw()
        {
            List<TvBmw> tvbmws = _tvbmwService.ObterTvBmw();

            return Ok(tvbmws);


        }

        [HttpPost(Name = "PostTvBmw")]
        public ActionResult Post(TvBmw en)
        {
            _logger.Log(LogLevel.Debug, "Iniciando get da aplicação");
            return Ok(en);
        }
    }
}
