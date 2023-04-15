using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Service;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AmorController1 : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private IAmorService _amorService;
        public AmorController1(ILogger<WeatherForecastController> logger, IAmorService amorService)
        {
            _logger = logger;
            _amorService = amorService;
        }

        [HttpGet(Name = "BuscarAmor")]
        public IActionResult BuscarAmor()
        {

            List<Amor> amores = _amorService.ObterAmor();


            return Ok(amores);
        }
        [HttpPost(Name = "PostAmor")]
        public ActionResult Post(Amor en)
        {
            _logger.Log(LogLevel.Debug, "Iniciando get da aplicação");
            return Ok(en);
        }
    }
}
