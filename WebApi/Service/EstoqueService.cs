using WebApi.Interfaces;
using WebApi.Model;

namespace WebApi.Service
{
    public class ClasseAService 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Soma(int x, int y, int z)
        {
            return x + y + z;
        }

        public int Subtrai(int x, int y)
        {
            return x - y;
        }

        public int Multiplica(int x, int y)
        {
            return x * y;
        }

        public decimal Divide(int x, int y)
        {
            return x / y;
        }

        public void Teste() 
        {
            X = 1;
            Y = 2;
            Z = 3;
            var resultado = Soma(X, Y, Z);
            resultado = Subtrai(X, Y);
            resultado = Multiplica(X, Y);
        }
    }
}
