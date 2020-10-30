using System;
using System.Globalization;

namespace Encap_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleta os dados fornecidos pelo usuario
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("nome");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Quantidade: ");
            int qtde = int.Parse(Console.ReadLine());           
            Produto produto = new Produto(nome, preco, qtde);

            //mostra na tela as informaçoes
            Console.WriteLine("Dados do produto: " + produto + "\n");

            //adiciona a quantidade de produtos informadas pelo usuario
            Console.WriteLine("Digite o número de produtos a serem adicionados: ");
            int _qtde = int.Parse(Console.ReadLine());
            produto.AdicionaProduto(_qtde);
            Console.WriteLine("Produto atualizado: " + produto + "\n");

            //remove a quantidade de produtos informada pelo usuario
            Console.WriteLine("Informe o número de produtos a serem removidos: ");
            _qtde = int.Parse(Console.ReadLine());
            produto.RemoveProduto(_qtde);
            Console.WriteLine("Produtos atualizados: " + produto + "\n");

        }
    }
}
