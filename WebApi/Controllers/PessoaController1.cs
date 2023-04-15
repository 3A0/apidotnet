using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PessoaController1 : ControllerBase
    {
        private IPessoaService _pessoaService;
        public PessoaController1(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet(Name = "BuscarPessoa")]
        public IActionResult BuscarPessoa()
        {
            List<Pessoa> pessoas = _pessoaService.ObterPessoa();

            return Ok(pessoas);

        }

        [HttpPost(Name = "PostPessoa")]
        public ActionResult Post(Pessoa en)
        {
            return Ok(en);
        }
    }
}