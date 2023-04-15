using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Model;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EstoqueController1 : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private IEstoqueService _estoqueService;
        public EstoqueController1(ILogger<WeatherForecastController> logger, IEstoqueService estoqueService)
        {
            _logger = logger;
            _estoqueService = estoqueService;
        }

        [HttpGet(Name = "BuscarEstoque")]
        public IActionResult BuscarEstoque()
        {
            List<Estoque> estoques = _estoqueService.ObterEstoque();


            return Ok(estoques);
        }

        [HttpPost(Name = "PostEstoque")]
        public ActionResult Post(Estoque en)
        {
            _logger.Log(LogLevel.Debug, "Iniciando get da aplicação");
            return Ok(en);
        }
    }
}
