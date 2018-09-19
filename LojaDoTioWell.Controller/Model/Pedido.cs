using System;
using System.Collections.Generic;
using System.Text;

namespace LojaDoTioWell.Controller.Model
{
    public class Pedido
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private decimal _valorPedido;

        public decimal ValorPedido
        {
            get { return _valorPedido; }
            set { _valorPedido = value; }
        }

        private DateTime _dataPedido;

        public DateTime DataPedido
        {
            get { return _dataPedido; }
            set { _dataPedido = value; }
        }

        private int _codCliente;

        public int CodCliente
        {
            get { return _codCliente; }
            set { _codCliente = value; }
        }
    }
}
