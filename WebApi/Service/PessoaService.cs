using WebApi.Enum;
using WebApi.Interfaces;

namespace WebApi.Service
{
    public class PessoaService : IPessoaService
    {
        private Interfaces.Repository.IPessoaRepository _pessoaRepository;

        public PessoaService(WebApi.Interfaces.Repository.IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public List<Pessoa> ObterPessoa()
        {
            return _pessoaRepository.ObterPessoas();
        }
    }
}

