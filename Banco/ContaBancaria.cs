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

        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldoInicial;
        }
       

  



      
        


    }
}
