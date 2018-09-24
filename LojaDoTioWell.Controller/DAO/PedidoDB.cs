using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace LojaDoTioWell.Controller.DAO
{
    internal class PedidoDB
    {
        string connect = ConfigurationManager.ConnectionStrings["ConnectDataBase"].ConnectionString;

        internal Pedido InserirPedidos( int codCliente, decimal valorPedido)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Insert into pedidos(cd_cli,valor_ped) values (@cd_cli,@valor_ped)";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@cd_cli", codCliente));
            comand.Parameters.Add(new SqlParameter("@valor_ped", valorPedido));
            try
            {
                con.Open();
                comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na gravação dos dados!" + e);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        internal List<Pedido> ConsultarPedidos()
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Select c.num_ped, c.data_ped, c.cd_cli, c.valor_ped from  pedido c";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                Pedido pedido = new Pedido();
                pedido.ID = Convert.ToInt32(reader["num_ped"].ToString());
                pedido.DataPedido = Convert.ToDateTime(reader["data_ped"]);
                pedido.CodCliente = Convert.ToInt32(reader["cd_cli"].ToString());
                pedido.ValorPedido = Convert.ToDecimal(reader["valor_ped"].ToString());

                listaPedidos.Add(pedido);
            }
            con.Close();

            return listaPedidos;
        }

        internal Pedido GetPedido(int numPed)
        {
            Pedido pedido = new Pedido();
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "select num_ped, valor_ped, data_ped, cd_cli  from pedido where num_ped=" + numPed;
            SqlCommand command = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pedido.ID = Convert.ToInt32(reader["num_ped"].ToString());
                pedido.ValorPedido = Convert.ToDecimal(reader["valor_ped"].ToString());
                pedido.CodCliente = Convert.ToInt32(reader["data_ped"].ToString());
                pedido.CodCliente = Convert.ToInt32(reader["cd_cli"].ToString());
            }

            return pedido;
        }

        internal void AtualizarPedido(int numPedido ,decimal valPedido)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Update pedido set valor_ped = @valor_ped where num_ped = @num_ped";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@num_ped", numPedido));
            comand.Parameters.Add(new SqlParameter("@valor_ped", valPedido));
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

        internal void ExcluirPedido(int numPed)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "delete  from  pedido  where num_ped =" + numPed;
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            con.Close();
        }
    }
}
