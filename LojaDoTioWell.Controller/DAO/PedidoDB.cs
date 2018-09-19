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

        internal Pedido InserirPedidos(DateTime dataPedido,int codCliente, decimal valorPedido)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Insert into pedidos(data_ped,cd_cli,valor_ped) values (@data_ped, @cd_cli,@valor_ped)";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@data_ped", dataPedido));
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
                pedido.ValorPedido = Convert.ToDecimal(reader["val_unit"].ToString());

                listaPedidos.Add(pedido);
            }
            con.Close();

            return listaPedidos;
        }
    }
}
