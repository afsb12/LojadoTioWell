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
    public partial class EditaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (txtNome.Value == "" && txtEmail.Value == "")
            {
                int cod_cli = Convert.ToInt32(Request.QueryString["CodCliente"]);

                Cliente cliente = new ClienteController().GetCliente(cod_cli);

                txtNome.Value = cliente.Nome;
                txtEmail.Value = cliente.Email;
                txtCelular.Value = cliente.Celular;
                txtSaldo.Value = cliente.Saldo.ToString();
            }
        }

        protected void AtualizarCliente_Click(object sender, EventArgs e)
        {
            string _nome = txtNome.Value;
            string _email = txtEmail.Value;
            string _celular = txtCelular.Value;
            decimal _saldo = Convert.ToDecimal(txtSaldo.Value);
            int _id = Convert.ToInt32(Request.QueryString["CodCliente"]); 

            Cliente cliente = new ClienteController().AtualizarCliente(_id, _nome, _email, _celular, _saldo);
            Response.Redirect("ConsultarCliente.aspx");
        }
    }
}