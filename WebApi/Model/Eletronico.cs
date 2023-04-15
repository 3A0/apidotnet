using WebApi.Enum;

namespace WebApi.Model
{
    // Eletronico esta estendendo a classe produto
    public class Eletronico : Produtocs
    {
        public  VoltagemEnum Voltagem { get; set; }
    }
}