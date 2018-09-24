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
    public partial class ExcluirProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cod_prod = Convert.ToInt32(Request.QueryString["CodProduto"]);

            Produto produto = new ProdutoController().GetProduto(cod_prod);
            txtexcluir.Text = "Deseja mesmo excluir o produto " + produto.Descricao+"?";
        }

        protected void btnSim_Click(object sender, EventArgs e)
        {
            int cod_prod = Convert.ToInt32(Request.QueryString["CodProduto"]);
            new ProdutoController().ExcluirProduto(cod_prod);
            Response.Redirect("AdicionarProduto.aspx");
        }

        protected void btnNao_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionarProduto.aspx");
        }
    }
}