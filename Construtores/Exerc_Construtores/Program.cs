using System;
using System.Globalization;

namespace Exerc_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
           //coleta os dados do usuario
            Console.WriteLine("ifnorme com os dados do produto;");           
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque:");
            int quantidade = int.Parse(Console.ReadLine());


            
            Produtos p = new Produtos(nome, preco, quantidade);

            //informa os dados coletados
            Console.WriteLine("Dados do produto: " + p);

           //adiciona produtos
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);

            //remove produtos
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
