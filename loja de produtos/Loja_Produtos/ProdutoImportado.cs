using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_Produtos
{
   
   //criaçao da classe "produto importado" 
    
    class ProdutoImportado : Produto
    {

        double taxa;

        public double Taxa
        {
            get => taxa;
            set => taxa = value;
        }

        public ProdutoImportado() { }

        public ProdutoImportado(string nome, double preco) : base(nome, preco)
        {
            
        }

        public override string precoTag()
        {
            return Nome + " - R$ " + Preco + "(Taxa: " + taxa + ")";
        }

        public double precoTotal(double precoTotal)
        {
            return precoTotal = Preco + Taxa;
        }
    }
}
