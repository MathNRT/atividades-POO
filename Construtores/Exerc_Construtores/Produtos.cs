using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exerc_Construtores
{
    class Produtos
    {

        public string Nome;
        public double Preco;
        public int quantidade;

        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            quantidade = quantidadee;
        }

        public double ValorTotalEstoque()
        {
            return Preco * quantidade;
        }

        public void AdicionarProduto(int _quantidade)
        {
            quantidade += _quantidade;
        }

        public void RemoverProduto(int _quantidade)
        {
            quantidade -= _quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
