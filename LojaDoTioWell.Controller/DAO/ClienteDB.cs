using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace LojaDoTioWell.Controller.DAO
{
    internal class ClienteDB
    {
        string connect = ConfigurationManager.ConnectionStrings["ConnectDataBase"].ConnectionString;

        internal Cliente InserirClientes(string name, string email, string celular, decimal saldo)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Insert into cliente(nome_cli,email_cli,celular_cli, saldo_cli) values (@nome_cli, @email_cli, @celular_cli, @saldo_cli)";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@nome_cli", name));
            comand.Parameters.Add(new SqlParameter("@email_cli", email));
            comand.Parameters.Add(new SqlParameter("@celular_cli", celular));
            comand.Parameters.Add(new SqlParameter("@saldo_cli", saldo));
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

        internal List<Cliente> ConsultarClientes()
        {
            List<Cliente> listaclientes = new List<Cliente>();
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Select c.cod_cli, c.nome_cli, email_cli, celular_cli, saldo_cli from  cliente c";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.ID = Convert.ToInt32(reader["cod_cli"].ToString());
                cliente.Nome = reader["nome_cli"].ToString();
                cliente.Email = reader["email_cli"].ToString();
                cliente.Celular = reader["celular_cli"].ToString();
                cliente.Saldo = Convert.ToDecimal(reader["saldo_cli"]);

                listaclientes.Add(cliente);
            }
            con.Close();

            return listaclientes;
        }

        internal Cliente AtualizarClientes(int id, string name, string email, string celular, decimal saldo)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Update cliente set  nome_cli = @nome_cli, email_cli = @email_cli,celular_cli = @celular_cli,saldo_cli = @saldo_cli where cod_cli = @cod_cli";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@cod_cli", id));
            comand.Parameters.Add(new SqlParameter("@nome_cli", name));
            comand.Parameters.Add(new SqlParameter("@email_cli", email));
            comand.Parameters.Add(new SqlParameter("@celular_cli", celular));
            comand.Parameters.Add(new SqlParameter("@saldo_cli", saldo));
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
            return null;
        }

        internal Cliente GetCliente(int id)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Select c.cod_cli, c.nome_cli, email_cli, celular_cli, saldo_cli from  cliente c where c.cod_cli = " + id;
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            Cliente cliente = new Cliente();
            while (reader.Read())
            {

                cliente.ID = Convert.ToInt32(reader["cod_cli"].ToString());
                cliente.Nome = reader["nome_cli"].ToString();
                cliente.Email = reader["email_cli"].ToString();
                cliente.Celular = reader["celular_cli"].ToString();
                cliente.Saldo = Convert.ToDecimal(reader["saldo_cli"]);
            }
            con.Close();

            return cliente;

        }

        internal Cliente GetClienteByName(string nome)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Select c.cod_cli, c.nome_cli, email_cli, celular_cli, saldo_cli from  cliente c where c.nome_cli = " + nome;
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            Cliente cliente = new Cliente();
            while (reader.Read())
            {

                cliente.ID = Convert.ToInt32(reader["cod_cli"].ToString());
                cliente.Nome = reader["nome_cli"].ToString();
                cliente.Email = reader["email_cli"].ToString();
                cliente.Celular = reader["celular_cli"].ToString();
                cliente.Saldo = Convert.ToDecimal(reader["saldo_cli"]);
            }
            con.Close();

            return cliente;

        }

        internal void ExcluirCliente(int id)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "delete  from  cliente  where cod_cli =" + id;
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            con.Close();
        }
    }
}
