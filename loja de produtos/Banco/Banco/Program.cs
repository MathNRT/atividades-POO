using System;
using System.Collections.Generic;
using System.Globalization;

namespace Banco.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista de contas
            List<Conta> list = new List<Conta>();

            

            list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
            list.Add(new Contajuridica(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
            list.Add(new Contajuridica(1004, "Mae", 500.0, 400.0));


            double soma = 0.0;


            
            foreach(Conta conta in list)
            {
                //soma o valor das contas 
                soma += conta.Saldo;
            }

           
            
            //mostra na tela o resultado
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            
            //saque do valor determinado nas contas da lista
            foreach(Conta acc in list)
            {
                acc.Saque(10.0);
            }

            //mostra na tela o novo valor do saldo das contas 
            foreach(Conta acc in list)
            {
                Console.WriteLine("Atualização do valor das contas: " + acc.Numero + ": " + acc.Saldo.ToString("F2",CultureInfo.InvariantCulture));
            }
                        
            Contajuridica bacc = new Contajuridica(1002, "mario", 0.0, 500.0);

            

            Conta conta1 = bacc;
            Conta conta2 = new Contajuridica(1003, "jose", 0.0, 500.0);
            Conta conta3 = new ContaPoupanca(1004, "vitor", 0.0, 0.01);

            

            Contajuridica conta4 = (Contajuridica)conta2;
            conta4.Emprestimo(100);



            if(conta3 is Contajuridica)
            {
                Contajuridica conta5 = (Contajuridica)conta3;
                conta5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }



            if(conta3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = conta3 as ContaPoupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}
