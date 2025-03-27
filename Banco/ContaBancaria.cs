using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Banco
{
    public class ContaBancaria
    {

        private int _numeroConta;
        private string _titular;
        private double _saldo;
        private double _taxaSaque;
        private double _percentualBonus;
        public int NumeroConta
        {
            get { return _numeroConta; } 
            set {
                if (value > 0)
                {
                    _numeroConta = value;
                }

                else 
                {
                    throw new Exception($"O número da conta não pode ser {value} (deve ser mais que 0).");
                   
                }
            }
        }
        public string Titular 
        {
            get { return _titular; }
            set
            {
                if(value != null && value.Length >= 2)
                {
                    _titular = value;
                }
                else if (value == "")
                {
                    throw new Exception($"O nome não pode ser nulo.");
                    
                }
                else
                {
                    throw new Exception($"O nome não pode ter apenas {value.Length} carácter(es) (deve ser mais que 1).");
                }
            }
        }
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if(value > 0)
                {
                    _saldo = value;
                }
                else
                {
                    throw new Exception($"Saldo não pode ser {value} (deve ser maior que 0).");
                }
            }
        }
        protected double TaxaSaque
        {
            get { return _taxaSaque; }
            set { _taxaSaque = value; }
        }

        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldoInicial;
        }
        protected double PercentualBonus 
        {
            get { return _percentualBonus; }
            set { _percentualBonus= value; }
        }

        public void ExibirSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"O saldo atual é de :{Saldo}");
            Limpar();
        }
        public double InserirDeposito()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Insira o quanto você deseja depositar: ");
                double dep = double.Parse(Console.ReadLine());
                Limpar();
                if (dep > 0)
                {
                    return Saldo += dep * (1 + PercentualBonus /100);
                }
                else
                {
                    throw new Exception("O valor deve ser maior que 0.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Limpar();
                return InserirDeposito();
            }
        }
        public double InserirSaque()
        {

            Console.Clear();
            Console.WriteLine("Insira o quanto você deseja sacar: ");
            double saq = double.Parse(Console.ReadLine());
            Limpar();
            return Saldo -= saq + TaxaSaque;
        }
        public void Limpar()
        {
            Console.WriteLine("Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }








    }
}
