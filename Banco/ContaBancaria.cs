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


        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldoInicial;
        }
       
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de :{_saldo}");
        }
        public double InserirSaque() 
        {
            Console.WriteLine("Insira o quanto você deseja sacar: ");
            double saq = double.Parse(Console.ReadLine());
            return _saldo -= saq;
        }
        public double InserirDeposito() 
        {
            Console.WriteLine("Insira o quanto você deseja depositar: ");
            double dep = double.Parse(Console.ReadLine());
            return _saldo += dep;
        }
    }
}

