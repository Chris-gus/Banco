namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();
            EscolherConta(contas);
            
        }
        
        static void EscolherConta(List<ContaBancaria> contas)
        {
            Console.Clear();
            
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
                        contas.Add(cb);
                        Interacao(cb, contas);
                        
                        break;
                    case 1:

                        ContaCorrente cc = new ContaCorrente(0, "", 0);
                        contas.Add(cc);
                        Interacao(cc, contas);
                        
                        break;
                    case 2:
                        ContaPoupanca cp = new ContaPoupanca(0, "", 0);
                        contas.Add(cp);
                        Interacao(cp, contas);
                        
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
                EscolherConta(contas);
            }
        }
        static void Interacao(ContaBancaria conta, List<ContaBancaria> contas)
        {

            InserirNum(conta);
            InserirTitular(conta);
            InserirSaldo(conta);
            EscolherOperacao(conta, contas);
        }
        static void EscolherOperacao(ContaBancaria conta, List<ContaBancaria> contas)
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
                Console.WriteLine("4- criar nova conta");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        EscolhaExibicao(conta, contas);
                        break;
                    case 2:
                        conta.InserirSaque();
                        break;
                    case 3:
                        conta.InserirDeposito();
                        break;
                    case 4:
                        EscolherConta(contas);
                        break;
                    default:
                        throw new Exception("Favor inserir um valor válido.");
                        
                }
            }
        }
        static void EscolhaExibicao(ContaBancaria conta, List<ContaBancaria> contas)
        {
            Console.Clear();
            Console.WriteLine("Escolha sua operação: ");
            Console.WriteLine("1- exibir apenas o saldo dessa conta.");
            Console.WriteLine("2- exibir todas as contas.");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1: 
                conta.ExibirSaldo();
                break;
                case 2:
                foreach(ContaBancaria cb in contas)
                {
                    cb.ExibirSaldo();
                }
                break;
                default:
                    throw new Exception("Insira uma operação válida.");
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