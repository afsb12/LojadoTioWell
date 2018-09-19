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
    public partial class AdicionarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InserirCliente_Click(object sender, EventArgs e)
        {
            string _nome = txtNome.Value;
            string _email = txtEmail.Value;
            string _celular = txtCelular.Value;
            decimal _saldo = Convert.ToDecimal(txtSaldo.Value);

            Cliente adicionarCliente = new ClienteController().InserirClientes(_nome, _email, _celular, _saldo);

            //Response.Write("<script>alert('Cadastro feito com sucesso');</script>");

            Response.Redirect("ConsultarCliente.aspx");
        }
    }
}