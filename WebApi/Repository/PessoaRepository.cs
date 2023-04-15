using WebApi.Interfaces.Repository;

namespace WebApi.Repository
{
    public class PessoaRepository : BaseContext, IPessoaRepository
    {
        
        public PessoaRepository(IConfiguration configuration) : base(configuration)
        {
        }


        public List<Pessoa> ObterPessoas()
        {
            return base.Pessoas.ToList();
        }
    }
}
