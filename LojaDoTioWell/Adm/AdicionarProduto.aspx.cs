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
    public partial class AdicionarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = new ProdutoController().ConsultarProdutos();


            if (listaProdutos.Count > 0)
            {
                StringBuilder gridProdutos = new StringBuilder();

                foreach (var produto in listaProdutos)
                {
                    gridProdutos.Append(" <tr>");
                    //rowsID.Add(cliente.ID);
                    gridProdutos.Append(String.Format(" <td> {0}</td> ", produto.ID));
                    gridProdutos.Append(String.Format(" <td> {0}</td> ", produto.Descricao));
                    gridProdutos.Append(String.Format(" <td> {0}</td> ", produto.ValorUnitario));
                    gridProdutos.Append(" <td><a href='EditarProduto.aspx?codProd=" + produto.ID + "'>Editar</a>  <a onclick='Confirm()' href='ExcluirProduto.aspx?codProduto=" + produto.ID + "' >Excluir</a></td>");
                    gridProdutos.Append(" <tr>");

                }
                resultadoProdutos.InnerHtml = gridProdutos.ToString();
            }
        }

        protected void InserirProduto_Click(object sender, EventArgs e)
        {
            string _descricao = txtDescricao.Value;
            decimal _valorUnitario = Convert.ToDecimal(txtValorUnitario.Value);
            if ((null == _descricao) || (_valorUnitario == null))
            {
                Response.Write("<script>alert('Por favor preencha o campo descricao');</script>");
                return;
            }
            else
            {
                Produto adicionarProduto = new ProdutoController().InserirProdutos(_descricao, _valorUnitario);
                Response.Redirect("AdicionarProduto.aspx");
            }          
        }
    }
}