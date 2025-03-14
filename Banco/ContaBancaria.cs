using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double Depositar
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo += value;
            }
        }
        public double Sacar
        {
            get {
                return _saldo; 
            }

            set
            {
                if(_saldo > value) 
                {
                    _saldo -= value;
                }
            }
        }
        public void ExibirSaldo() 
        {
            Console.WriteLine(_saldo);
        }
    }
}
