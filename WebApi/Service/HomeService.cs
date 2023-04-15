using WebApi.Interfaces;
using WebApi.Model;

namespace WebApi.Service
{
    public class HomeService : IHomeService
    {
        public List<Home> ObterHome()
        {
            Home home1 = new();
            home1.Quantidade = 1;

            Home home2 = new();
            home2.Quantidade = 2;


            List<Home> lista = new List<Home>();
            lista.Add(home1);
            lista.Add(home2);

            return lista;
        }
    }
}




