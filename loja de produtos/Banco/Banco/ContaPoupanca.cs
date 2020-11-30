using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entities
{

    //classe conta poupança
    class ContaPoupanca : Conta
    {

        public double TaxaJuros { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}
