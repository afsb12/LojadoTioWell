using System;
using System.Collections.Generic;
using System.Text;

namespace LojaDoTioWell.Controller.Model
{
    public class ItemPedido
    {
        private int _numPed;

        public int NumeroPedido
        {
            get { return _numPed; }
            set { _numPed = value; }
        }

        private int _cdProd;

        public int CodigoProduto
        {
            get { return _cdProd; }
            set { _cdProd = value; }
        }

        private int _quantidade;

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
    }
}
