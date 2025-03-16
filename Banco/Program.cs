namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ContaBancaria cb = new ContaBancaria(123, "Mars", 1500);
            cb.InserirSaque();
            cb.InserirDeposito();
            cb.ExibirSaldo();*/

            Console.WriteLine("Insira o número da sua conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do titular: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Insira o seu saldo inicial: ");
            int saldoInicial = int.Parse(Console.ReadLine());
            ContaCorrente cc = new ContaCorrente(numeroConta, titular, saldoInicial);

            cc.EscolherOperacao();
            
            

            
        }
  


    }
}