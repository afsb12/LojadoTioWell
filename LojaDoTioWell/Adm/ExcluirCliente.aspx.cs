using LojaDoTioWell.Controller.Controller;
using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LojaDoTioWell.Adm
{
    public partial class ExcluirCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cod_cli = Convert.ToInt32(Request.QueryString["CodCliente"]);

            Cliente cliente = new ClienteController().GetCliente(cod_cli);

            txtexcluir.Text = "Deseja mesmo excluir Cliente " + cliente.Nome;
        }

        protected void btnSim_Click(object sender, EventArgs e)
        {
            int cod_cli = Convert.ToInt32(Request.QueryString["CodCliente"]);
            new ClienteController().ExcluirCliente(cod_cli);
            Response.Write("alert('Cliente excluído com sucesso!')");
            Response.Redirect("ConsultarCliente.aspx");
        }

        protected void btnNao_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarCliente.aspx");
        }
    }
}