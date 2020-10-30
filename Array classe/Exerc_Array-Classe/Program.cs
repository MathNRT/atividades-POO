using System;
using System.Globalization;
using System.Linq;

namespace Exerc_Array_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe a qantidade de produtos: ");   //o usuario informa a quantidade de produtos
            int n = int.Parse(Console.ReadLine()); 



            Produto[] prod = new Produto[n]; // cria o vetor com a informação imputada.

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("digite o nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("diga o valor do produto:");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                prod[i] = new Produto { Nome = nome, Valor = valor };
            }


            double sum = 0.0; //variável soma
            for(int i = 0; i < n; i++)
            {
                sum += prod[i].Valor;
            }



            Console.WriteLine("Preço médio: " + sum / prod.Length);
        }
    }
}
