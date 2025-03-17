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
            Console.Clear();
            Console.WriteLine($"Seu saldo atual é de :{_saldo}");
            Limpar();
        }
        public double InserirSaque() 
        {
            
            
            Console.WriteLine("Insira o quanto você deseja sacar: ");
            double saq = double.Parse(Console.ReadLine());
            Limpar();
            ExibirSaldo();
            
            return _saldo -= saq;
        }
        public double InserirDeposito() 
        {
            Console.Clear();
            Console.WriteLine("Insira o quanto você deseja depositar: ");
            double dep = double.Parse(Console.ReadLine());
            Limpar();
            return _saldo += dep;
        }
        public void EscolherOperacao()
        {
            int op = 1;
            while(op != 0){
            Console.Clear();
            Console.WriteLine("Insira qual operação você deseja:");
            Console.WriteLine("0 - sair");
            Console.WriteLine("1 -exibir saldo");
            Console.WriteLine("2 -sacar ");
            Console.WriteLine("3 -depositar");
            op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 0:
                Console.WriteLine("Saindo...");
                break;
                case 1:
                ExibirSaldo();
                break;
                case 2:
                InserirSaque();
                break;
                case 3:
                InserirDeposito();
                break;
            }
            }
        }
        public void Limpar() 
        {
            Console.WriteLine("Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

