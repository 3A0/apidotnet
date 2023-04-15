using WebApi.Model;

namespace WebApi.Interfaces
{
    public interface IEletronicoService
    {
        public List<Eletronico> ObterEletronico(Produtocs produto);
    }
}
