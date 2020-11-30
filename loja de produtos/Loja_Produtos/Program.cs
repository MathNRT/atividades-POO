using System;
using System.Collections.Generic;
using System.Globalization;

namespace Loja_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contar;
            List<Produto> produtos = new List<Produto>();

            //coleta do usuario a informaçao da quantidade de produtos
            Console.WriteLine("Informe a quantidade de Produtos:");
            contar = int.Parse(Console.ReadLine());


            //inicia as perguntas, que vao obter os dados dos produtos desejados
            for(int i = 0; i<contar; i++)
            {
                Produto produto = new Produto();

                
                Console.WriteLine("Informe o nome do produto:");
                produto.Nome = Console.ReadLine();



                Console.WriteLine("Informe o valor do produto:");
                produto.Preco = double.Parse(Console.ReadLine());



                Console.WriteLine("informe se o produto é: Usado(U), Comum(C), Importado(I):");
                string tipo = Console.ReadLine();



                switch (tipo)
                {
                    case "U":
                        ProdutoUsado produtoUsado = new ProdutoUsado(produto.Nome, produto.Preco);
                        Console.WriteLine("Informe a data de fabricação (DD/MM/AAAA): ");
                        produtoUsado.Fabricacao = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
                        produtos.Add(produtoUsado);
                        break;


                    case "C":
                        produtos.Add(produto);
                        break;


                    case "I":
                        ProdutoImportado produtoImportado = new ProdutoImportado(produto.Nome, produto.Preco);
                        Console.WriteLine("Informe a Taxa: ");
                        produtoImportado.Taxa = double.Parse(Console.ReadLine());
                        produtos.Add(produtoImportado);
                        break;
                }

            }


            foreach(Produto obj in produtos)
            {
                Console.WriteLine(obj.precoTag());
            }

        }
    }
}
