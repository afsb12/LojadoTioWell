using LojaDoTioWell.Controller.DAO;
using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaDoTioWell.Controller.Controller
{
    class ItemPedidoController
    {
        public ItemPedido InserirItemPedido(int codProduto, int quantidadeProduto)
        {
            return new ItemPedidoDB().InserirItemPedido(codProduto, quantidadeProduto);
        }

        public List<ItemPedido> ConsultarItemPedido()
        {
            return new ItemPedidoDB().ConsultarItemsPedidos();
        }

        public ItemPedido GetItemPedido(int numPed)
        {
            return new ItemPedidoDB().GetItemPedido(numPed);
        }

        public void AtualizarItemPedido(int numPed, int codProd, int qtdPed)
        {
            new ItemPedidoDB().AtualizarItemPedido(numPed, codProd, qtdPed);
            return;
        }

        public void ExcluirItemPedido(int numPed)
        {
            new ItemPedidoDB().ExcluirItemPedido(numPed);
            return;
        }
    }
}
