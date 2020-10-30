using System;
using System.Globalization;

namespace Exec_Array_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            int pessoa;

            Console.WriteLine("digite a quantidade de pessoas: ");            //informa a quantidade de pessoas
            pessoa = int.Parse(Console.ReadLine());                          
            double[] vect = new double[pessoa];                               //Tamanho do vetor definido pelo usuário.

           
            Console.WriteLine("Informe a altura da pessoa: ");



            for (int i = 0; i < pessoa; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Altura da pessoa " + "(" + i + "): " + vect[i]);
            }

            double sum = 0.0;             //soma

            
            for(int i = 0; i < pessoa; i++)             //Utilização do for para percorrer o vetor.
            {
                sum += vect[i];
            }



            Console.WriteLine("A média de altura das pessoas é = " + sum/pessoa);
        }
    }
}
