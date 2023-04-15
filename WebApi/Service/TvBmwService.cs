using WebApi.Interfaces;

namespace WebApi.Service
{
    public class TvBmwService : ITvBmwService
    {
        public List<TvBmw> ObterTvBmw()
        {

            TvBmw tvbmw1 = new();
            tvbmw1.Nome = "Vinicius";


            List<TvBmw> lista = new List<TvBmw>();
            lista.Add(tvbmw1);


            return lista;
        }
    }
}

