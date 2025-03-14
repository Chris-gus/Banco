namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb = new ContaBancaria(123, "Mars", 1500);
            cb.InserirSaque();
            cb.InserirDeposito();
            cb.ExibirSaldo();
        }


    }
}