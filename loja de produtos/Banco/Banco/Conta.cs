using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entities
{
    abstract class Conta
    {
        //classe conta
        public int Numero { get; private set; }
        public string dono { get; private set; }
        public double Saldo { get; protected set; }

        public Conta() { }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            dono = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }

    }
}
