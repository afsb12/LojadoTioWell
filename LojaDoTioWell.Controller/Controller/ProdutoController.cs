using LojaDoTioWell.Controller.DAO;
using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaDoTioWell.Controller.Controller
{
    public class ProdutoController
    {
        public ProdutoController()
        {

        }

        public Produto InserirProdutos(string descricao, decimal valorUnitario)
        {
            return new ProdutoDB().InserirProdutos(descricao, valorUnitario);
        }

        public List<Produto> ConsultarProdutos()
        {
            return new ProdutoDB().ConsultarProdutos();
        }

        public Produto GetProduto(int id)
        {
            return new ProdutoDB().GetProduto(id);
        }

        public Produto GetProdutoByDescricao(string descricaoProduto)
        {
            return new ProdutoDB().GetProdutoByDescricao(descricaoProduto);
        }

        public void AtualizarProduto(int id,string descricacao, decimal valorUnitario)
        {
             new ProdutoDB().AtualizarProduto(id,descricacao, valorUnitario);

            return;
        }

        public void ExcluirProduto(int id)
        {
            new ProdutoDB().ExcluirProduto(id);
            return;
        }
    }
}
