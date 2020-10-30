using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Encap_properties
{
    class Produto
    {
        /* Variáveis Utilizadas (construtores)
        public string Nome;
        public double Preco;
        public int Qtde;
        */

        //Declaração de Váriaveis metodo GET - SET 
        string _nome;
        double _preco;
        int _qtde;

        //Construtor
        public Produto()
        {
        }

        //Construtor personalizado 
        public Produto(string nome, double preco, int qtde)
        {
            _nome = nome;
            _preco = preco;
            _qtde = qtde;
        }

        /* 
         * Método Get - SET 
         * 
         * if(verifica se nome está na conformidade solicitada)
         * 
         * --Inicio-- 
         */
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            
        }
        /* 
         * --Fim--
         */

        /*------------------------------------------*/
        /*------------------------------------------*/

        /* 
         * -- Utilizando PROPERTIES --
         * -- Início-- 
         */
        public double Preco
        {
            get{ return _preco; }
        }

        public int Qtde
        {
            get { return _qtde; }
        }
        /*
         * -- Fim -- 
         */

        public double ValorTotalEstoque()
        {
            return _preco * _qtde;
        }

        public void AdicionaProduto(int qtde)
        {
            _qtde += qtde;
        }

        public void RemoveProduto(int qtde)
        {
            _qtde -= qtde;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _qtde
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
