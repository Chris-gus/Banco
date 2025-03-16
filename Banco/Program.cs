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
            EscolherConta();

            
            

            
        }
        static void EscolherConta()
        {
            Console.WriteLine("Qual o tipo de conta que você possui?");
            Console.WriteLine("0 - Conta Comum");
            Console.WriteLine("1- Conta Corrente");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 0:
                break;
                case 1:
                Interacaocc();
                break;
            }
        }
        static void Interacaocc ()
        {
            Console.Clear();
            Console.WriteLine("Insira o número da sua conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do titular: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Insira o seu saldo inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());
            ContaCorrente cc = new ContaCorrente(numeroConta, titular, saldoInicial);

            cc.EscolherOperacao();
        }
  


    }
}