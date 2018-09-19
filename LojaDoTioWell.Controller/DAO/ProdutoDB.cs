using LojaDoTioWell.Controller.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace LojaDoTioWell.Controller.DAO
{
    internal class ProdutoDB
    {
        string connect = ConfigurationManager.ConnectionStrings["ConnectDataBase"].ConnectionString;

        internal Produto InserirProdutos(string descricao, decimal valorUnitario)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Insert into produto(desc_prod,val_unit) values (@desc_prod, @val_unit)";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@desc_prod", descricao));
            comand.Parameters.Add(new SqlParameter("@val_unit", valorUnitario));
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

        internal List<Produto> ConsultarProdutos()
        {
            List<Produto> listaprodutos = new List<Produto>();
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Select c.cod_prod, c.desc_prod, c.val_unit from  produto c";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                Produto produto = new Produto();
                produto.ID = Convert.ToInt32(reader["cod_prod"].ToString());
                produto.Descricao = reader["desc_prod"].ToString();
                produto.ValorUnitario = Convert.ToDecimal(reader["val_unit"].ToString());

                listaprodutos.Add(produto);
            }
            con.Close();

            return listaprodutos;
        }

        internal Produto GetProduto(int id)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Select cod_prod, desc_prod, val_unit from  produto  where cod_prod = " + id;
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            Produto produto = new Produto();
            while (reader.Read())
            {
                produto.ID = Convert.ToInt32(reader["cod_prod"].ToString());
                produto.Descricao = reader["desc_prod"].ToString();
                produto.ValorUnitario = Convert.ToDecimal(reader["val_unit"].ToString());
 
            }
            con.Close();

            return produto;
        }

        internal void AtualizarProduto(int id,string descricao, decimal valUnitario)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "Update produto set desc_prod = @desc_prod,val_unit = @val_unit where cod_prod = @cod_prod";
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            comand.Parameters.Add(new SqlParameter("@cod_prod", id));
            comand.Parameters.Add(new SqlParameter("@desc_prod", descricao));
            comand.Parameters.Add(new SqlParameter("@val_unit", valUnitario));

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
            return ;
        }

        internal void ExcluirProduto(int id)
        {
            SqlConnection con = new SqlConnection(connect);
            string sqlQuery = "delete  from  produto  where cod_prod =" + id;
            SqlCommand comand = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = comand.ExecuteReader();
            con.Close();
        }

    }
}
