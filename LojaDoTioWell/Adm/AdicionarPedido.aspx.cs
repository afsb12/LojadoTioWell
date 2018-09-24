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
    public partial class AdicionarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Cliente> listaClientes = new ClienteController().ConsultarClientes();
            List<Produto> listaProduto = new ProdutoController().ConsultarProdutos();

            if (listaClientes.Count > 0)
            {      
                foreach (var cliente in listaClientes)
                {
                    this.dpCliente.Items.Add(cliente.Nome.ToString());
                }
            }
            if (listaProduto.Count > 0)
            {
                foreach (var produto in listaProduto)
                {
                    this.dpProduto.Items.Add(produto.Descricao.ToString());
                }
            }

        }

        protected void inserirPedido_Click(object sender, EventArgs e)
        {
            string nomeCliente = this.dpCliente.Text;
            Cliente cliente = new ClienteController().GetClienteByName(nomeCliente);

            string descrocaoProduto = this.dpProduto.Text;
            Produto produto = new ProdutoController().GetProdutoByDescricao(descrocaoProduto);


            
        }
    }
}