using LojaDoTioWell.Controller.Controller;
using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LojaDoTioWell.Adm
{
    public partial class ConsultaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cliente> listaClientes = new ClienteController().ConsultarClientes();


            if (listaClientes.Count > 0)
            {
                StringBuilder gridClientes = new StringBuilder();

                foreach (var cliente in listaClientes)
                {
                    gridClientes.Append(" <tr>");
                    //rowsID.Add(cliente.ID);
                    gridClientes.Append(String.Format(" <td> {0}</td> ", cliente.Nome));
                    gridClientes.Append(String.Format(" <td> {0}</td> ", cliente.Email));
                    gridClientes.Append(String.Format(" <td> {0}</td> ", cliente.Celular));
                    gridClientes.Append(String.Format(" <td> {0}</td> ", cliente.Saldo));
                    gridClientes.Append(" <td><a href='EditarCliente.aspx?codCliente=" + cliente.ID + "'>Editar</a>  <a onclick='Confirm()' href='ExcluirCliente.aspx?codCliente="+ cliente.ID+"' >Excluir</a></td>");
                    gridClientes.Append(" <tr>");

                }
                resultadoClientes.InnerHtml = gridClientes.ToString();
            }
        }

        protected void AdcionarCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionarCliente.aspx");
        }
    }
}