using LojaDoTioWell.Controller.DAO;
using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaDoTioWell.Controller.Controller
{
    public class ClienteController
    {
        public ClienteController()
        {

        }
        public Cliente InserirClientes(string name, string email, string celular,decimal saldo)
        {
            return new ClienteDB().InserirClientes(name, email, celular, saldo);
        }

        public List<Cliente> ConsultarClientes()
        {
            return new ClienteDB().ConsultarClientes();
        }

        public Cliente AtualizarCliente(int id,string name, string email, string celular, decimal saldo)
        {
            return new ClienteDB().AtualizarClientes(id,name, email, celular, saldo);
        }

        public Cliente GetCliente(int id)
        {
            return new ClienteDB().GetCliente(id);
        }

        public void ExcluirCliente(int id)
        {
            new ClienteDB().ExcluirCliente(id);
        }
    }
}
