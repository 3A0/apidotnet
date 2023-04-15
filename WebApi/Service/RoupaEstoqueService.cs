using WebApi.Interfaces;
using WebApi.Model;

namespace WebApi.Service
{
    public class RoupaEstoqueService : IRoupaService
    {
        public List<Roupa> ObterRoupaEstoque()
        {
            var list = new List<Roupa>();
             Roupa roupa1 = new();
            roupa1.Estilo= "camisa";

            list.Add(roupa1);

            return list;

        }       
    }
}
