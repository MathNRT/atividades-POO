using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entities
{
    class Contajuridica : Conta
    {
        //classe conta juridica
        public double EmprestimoLimite { get; set; }

        public Contajuridica() { }

        public Contajuridica(int numero, string titular, double saldo, double emprestimoLimite):base(numero,titular,saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double saldoTotal)
        {
            if(saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }

    }
}
