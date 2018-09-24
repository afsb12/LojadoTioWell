using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace LojaDoTioWell.Controller.DAO
{
    public class ItemPedidoDB
    {
        string connect = ConfigurationManager.ConnectionStrings["ConnectDataBase"].ConnectionString;

        internal ItemPedido InserirItemPedido(int codProduto, int quantidadeProduto)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Insert into item_pedido(cd_prod,qtd_ped) values (@cd_prod,@qtd_ped)";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@cd_prod", codProduto));
            comand.Parameters.Add(new SqlParameter("@qtd_ped", quantidadeProduto));
            try
            {
                con.Open();
                comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema para inserir o Item Pedido!" + e);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        internal List<ItemPedido> ConsultarItemsPedidos()
        {
            List<ItemPedido> listaItemsPedidos = new List<ItemPedido>();
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Select num_ped, cd_prod, qtd_ped from  item_pedido";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                ItemPedido itempedido = new ItemPedido();
                itempedido.NumeroPedido = Convert.ToInt32(reader["cd_cli"].ToString());
                itempedido.CodigoProduto = Convert.ToInt32(reader["data_ped"]);               
                itempedido.Quantidade = Convert.ToInt32(reader["valor_ped"].ToString());

                listaItemsPedidos.Add(itempedido);
            }
            con.Close();

            return listaItemsPedidos;
        }

        internal ItemPedido GetItemPedido(int numPed)
        {
            ItemPedido itemPedido = new ItemPedido();
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "select num_ped, valor_ped, data_ped, cd_cli  from pedido where num_ped=" + numPed;
            SqlCommand command = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                itemPedido.NumeroPedido = Convert.ToInt32(reader["num_ped"].ToString());
                itemPedido.CodigoProduto = Convert.ToInt32(reader["valor_ped"].ToString());
                itemPedido.Quantidade = Convert.ToInt32(reader["data_ped"].ToString());
            }

            return itemPedido;
        }

        internal void AtualizarItemPedido(int numPedido, int cdProduto, int qtdProduto)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Update item_pedido set cd_prod = @cd_prod, qtd_ped = @qtd_ped where num_ped = @num_ped";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@num_ped", numPedido));
            comand.Parameters.Add(new SqlParameter("@cd_prod", cdProduto));
            comand.Parameters.Add(new SqlParameter("@qtd_ped", qtdProduto));
            try
            {
                con.Open();
                comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na Atualização dos dados!" + e);
            }
            finally
            {
                con.Close();
            }
            return;
        }

        internal void ExcluirItemPedido(int numPed)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "delete  from  item_pedido  where num_ped =" + numPed;
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            con.Close();
        }
    }
}
