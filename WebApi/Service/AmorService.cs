using WebApi.Interfaces;

namespace WebApi.Service
{
    public class AmorService : IAmorService
    {
        public List<Amor> ObterAmor()
        {
            Amor amor1 = new();
            amor1.Nome = "Amor, me desculpa. Temos ..";
            amor1.Idade = 2.6M;


            Amor amor2 = new();
            amor2.Nome = "Anos juntos. Prometo que estou me esforçando. Obrigada pela ajuda. Te amo! ";


            Amor amor3 = new();
            amor3.Nome = "Contrato renovado para mais 100 anos ?";
            amor3.Idade = 100;

            List<Amor> lista = new List<Amor>();
            lista.Add(amor1);
            lista.Add(amor2);
            lista.Add(amor3);

            return lista;

        }
    }
}
