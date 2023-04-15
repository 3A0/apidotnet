namespace WebApi
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public bool Ativo { get; set; }

        public DateTime Nascimento { get; set; }

        public decimal Altura { get; set; }
        public string Signo { get; set; }

        internal static List<Pessoa> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
