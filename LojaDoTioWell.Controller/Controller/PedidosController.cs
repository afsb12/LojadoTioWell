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
            return new PedidoDB().InserirPedidos(dataPedido, codCliente, valorPedido);
        }

        public List<Pedido> ConsultarPedidos()
        {
            return new PedidoDB().ConsultarPedidos();
        }
    }
}
