using System;
using System.Collections.Generic;

namespace atividade_26_10__listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar lista
            List<string> List = new List<string>();

            //adicionando elementos na lista
            List.Add("Mouse");
            List.Add("Teclado");
            List.Add("Monitor");
            List.Add("Pendrive");
            List.Add("Headsett");

            //adiciona um elemento no local designado
            List.Insert(5, "Joystick");

            //abre um loop de leitura nos elementos
            foreach (string obj in List)
            {
                //imprime os elementos na tela
                Console.WriteLine(obj);
            }

            //cona quantos elementos existem na lista
            Console.WriteLine("quantidade de elementos na lista: " + List.Count);

            //encontrar o elemento que começa com a letra M  com uma funçao lambda
            string s1 = List.Find(x => x[0] == 'M');
            Console.WriteLine("primeiro elemento que começa com a letra M: " + s1);

            //encontrar o ultimo elemento que iicia com a letra M com uma funçao lambda
            string s2 = List.FindLast(x => x[0] == 'M');
            Console.WriteLine("ultimo elemento que começa com a letra M: " + s2);

            //buscar elementos pela sua posiçao
            int pos1 = List.FindIndex(x => x[0] == 'a');
            Console.WriteLine("primeira posiçao de A: " + pos1);
            int pos2 = List.FindIndex(x => x[0] == 'a');
            Console.WriteLine("Ultima posiçao de 'A': " + pos2);

            //buscar todos os elementos com o tamanho igual a 5 caracteres
            List<string> list2 = List.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------");
            foreach (string obj in List)
            {
                Console.WriteLine(obj);
            }

            //remover elemenntos da lista
            List.Remove("mouse");
            Console.WriteLine("===================");
            foreach (string obj in List)
            {
                Console.WriteLine(obj);
            }

            

        }

    }
}
