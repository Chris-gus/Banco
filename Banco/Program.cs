namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscolherConta();
        }
        static void EscolherOperacao(ContaBancaria conta)
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Insira qual operação você deseja:");
                Console.WriteLine("0 - sair");
                Console.WriteLine("1 -exibir saldo");
                Console.WriteLine("2 -sacar ");
                Console.WriteLine("3 -depositar");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        ExibirSaldo(conta);
                        break;
                    case 2:
                        InserirSaque(conta);
                        break;
                    case 3:
                        InserirDeposito(conta);
                        break;
                }
            }
        }
        static void ExibirSaldo(ContaBancaria conta)
        {
            Console.Clear();
            Console.WriteLine($"Seu saldo atual é de :{conta.Saldo}");
            Limpar();
        }
        static double InserirDeposito(ContaBancaria conta)
        {
            Console.Clear();
            try{
            Console.WriteLine("Insira o quanto você deseja depositar: ");
            double dep = double.Parse(Console.ReadLine());
            Limpar();
            if(dep > 0){
            return conta.Saldo += dep;
            }
            else {throw new Exception("O valor deve ser maior que 0.");}
            }
            catch(Exception ex)
            {
                    Console.WriteLine(ex.Message);
                Limpar();
                return InserirDeposito(conta);
            }
        }
        static double InserirSaque(ContaBancaria conta)
        {

            Console.Clear();
            Console.WriteLine("Insira o quanto você deseja sacar: ");
            double saq = double.Parse(Console.ReadLine());
            Limpar();
            return conta.Saldo -= saq;
        }
        static void Interacao(ContaBancaria conta)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Insira o número da sua conta: ");
                conta.NumeroConta = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o nome do titular: ");
                conta.Titular = Console.ReadLine();

                Console.WriteLine("Insira o seu saldo inicial: ");
                conta.Saldo = double.Parse(Console.ReadLine());


                EscolherOperacao(conta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Limpar();
                Interacao(conta);
            }
        }
        static void EscolherConta()
        {
            Console.WriteLine("Qual o tipo de conta que você possui?");
            Console.WriteLine("0 - Conta Comum");
            Console.WriteLine("1- Conta Corrente");
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
            }
        }
        static void Limpar()
        {
            Console.WriteLine("Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }


    }
}