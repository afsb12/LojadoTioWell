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
    public partial class EditarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (txtDescricao.Value == "" && txtValorUnitario.Value == "")
            {
                int cod_cli = Convert.ToInt32(Request.QueryString["CodProd"]);

                Produto cliente = new ProdutoController().GetProduto(cod_cli);

                txtDescricao.Value = cliente.Descricao;
                txtValorUnitario.Value = cliente.ValorUnitario.ToString();
            }
        }

        protected void atualizarProduto_Click(object sender, EventArgs e)
        {
            string _descricao = txtDescricao.Value;
            decimal _valUnitario = Convert.ToDecimal(txtValorUnitario.Value);
            int cod_prod = Convert.ToInt32(Request.QueryString["CodProd"]);

            new ProdutoController().AtualizarProduto(cod_prod,_descricao, _valUnitario);
            Response.Redirect("AdicionarProduto.aspx");
            return;
        }
    }
}