namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscolherConta();
        }
        static void EscolherConta()
        {
            try
            {
                Console.WriteLine("Qual o tipo de conta que você possui?");
                Console.WriteLine("0 - Conta Comum");
                Console.WriteLine("1- Conta Corrente");
                Console.WriteLine("2- Conta Poupança");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        ContaBancaria cb = new ContaBancaria(0, "", 0);
                        Interacao(cb);
                        break;
                    case 1:

                        ContaCorrente cc = new ContaCorrente(0, "", 0);
                        Interacao(cc);
                        break;
                    case 2:
                        ContaPoupanca cp = new ContaPoupanca(0, "", 0);
                        Interacao(cp);
                        break;
                    default:
                        throw new Exception("Insira um valor válido.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                EscolherConta();
            }
        }
        static void Interacao(ContaBancaria conta)
        {

            InserirNum(conta);
            InserirTitular(conta);
            InserirSaldo(conta);
            EscolherOperacao(conta);
        }
        static void EscolherOperacao(ContaBancaria conta)
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Insira qual operação você deseja:");
                Console.WriteLine("0- sair");
                Console.WriteLine("1- exibir saldo");
                Console.WriteLine("2- sacar ");
                Console.WriteLine("3- depositar");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        conta.ExibirSaldo();
                        break;
                    case 2:
                        conta.InserirSaque();
                        break;
                    case 3:
                        conta.InserirDeposito();
                        break;
                }
            }
        }



        static void InserirNum(ContaBancaria conta)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Insira o número da sua conta: ");
                conta.NumeroConta = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conta.Limpar();
                InserirNum(conta);
            }
        }
        static void InserirTitular(ContaBancaria conta)
        {
            try
            {
                Console.WriteLine("Insira o nome do titular: ");
                conta.Titular = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conta.Limpar();
                InserirTitular(conta);
            }
        }
        static void InserirSaldo(ContaBancaria conta)
        {
            try
            {
                Console.WriteLine("Insira o seu saldo inicial: ");
                conta.Saldo = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conta.Limpar();
                InserirSaldo(conta);
            }
        }





    }
}