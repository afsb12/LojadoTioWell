using System;
using System.Collections.Generic;
using System.Text;

namespace LojaDoTioWell.Controller.Model
{
    public class Produto
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private decimal _valorUnitario;

        public decimal ValorUnitario
        {
            get { return _valorUnitario; }
            set { _valorUnitario = value; }
        }
    }
}
