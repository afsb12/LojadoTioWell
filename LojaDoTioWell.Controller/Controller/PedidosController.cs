using LojaDoTioWell.Controller.DAO;
using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaDoTioWell.Controller.Controller
{
    public class PedidosController
    {
        public PedidosController()
        {

        }

        public Pedido InserirPedidos(DateTime dataPedido, int codCliente, decimal valorPedido)
        {
            return new PedidoDB().InserirPedidos(codCliente, valorPedido);
        }

        public List<Pedido> ConsultarPedidos()
        {
            return new PedidoDB().ConsultarPedidos();
        }

        public Pedido GetPedido(int numPed)
        {
            return new PedidoDB().GetPedido(numPed);
        }

        public void ExcluirPedido(int numPed)
        {
            new PedidoDB().ExcluirPedido(numPed);
            return;
        }
    }
}
