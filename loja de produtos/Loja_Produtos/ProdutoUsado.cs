using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_Produtos
{
   
    //criaçao da classe "produto usado"
    class ProdutoUsado : Produto
    {

        DateTime fabricacao;

        public DateTime Fabricacao 
        {
            get => fabricacao;
            set => fabricacao = value;
        }

        public ProdutoUsado() { }

        public ProdutoUsado(string nome, double preco) : base(nome, preco) { }

        public override string precoTag()
        {
            return Nome + " (usado) - R$ " + Preco + "(fabricação: " + fabricacao + ")";
        }

    }
}
