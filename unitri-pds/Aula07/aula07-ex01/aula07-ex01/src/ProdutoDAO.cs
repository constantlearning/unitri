using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex01.src
{
    class ProdutoDAO
    {

        private SqlConnection conexao;
        private SqlTransaction tx;

        public ProdutoDAO(SqlConnection con)
        {
            this.conexao = con;
        }

        public ProdutoDAO(SqlConnection con, SqlTransaction tx)
        {
            this.conexao = con;
            this.tx = tx;
        }

        public Boolean Insert(Produto produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Produto (descricao, preco) ");
            sql.Append(" values ");
            sql.Append(" (@descricao, @preco); ");
            sql.Append(" select @@identity from Produto ");
            comando.CommandText = sql.ToString();
            //comando.Parameters.AddWithValue("@id", produto.Id);
            comando.Parameters.AddWithValue("@descricao", produto.Descricao);
            comando.Parameters.AddWithValue("@preco", produto.Preco);
            decimal n = (decimal)comando.ExecuteScalar();
            produto.Id = Convert.ToInt32(n);
            return n >= 1;
        }

        public Boolean Delete(Produto produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Produto ");
            sql.Append(" where id = @id ");
            comando.CommandText = sql.ToString();
            comando.Parameters.AddWithValue("@id", produto.Id);
            int n = comando.ExecuteNonQuery();
            return n == 1;
        }

        public Boolean Delete(Int32 id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Delete from Produto ");
            sql.Append(" where id = @id ");
            comando.CommandText = sql.ToString();
            comando.Parameters.AddWithValue("@id", id);
            int n = comando.ExecuteNonQuery();
            return n == 1;
        }

        public Boolean Update(Produto produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Update Produto set ");
            sql.Append(" descricao = @descricao, ");
            sql.Append(" preco = @preco ");
            sql.Append(" where id = @id ");
            comando.CommandText = sql.ToString();
            comando.Parameters.AddWithValue("@id", produto.Id);
            comando.Parameters.AddWithValue("@descricao", produto.Descricao);
            comando.Parameters.AddWithValue("@preco", produto.Preco);
            int n = comando.ExecuteNonQuery();
            return n >= 1;
        }

        public Produto GetById(Int32 id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }

            comando.CommandText = "select * from produto where id = @id";
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = comando.ExecuteReader();
            Produto produto = null;
            if (reader.Read())
            {
                produto = new Produto();
                produto.Id = (Int32)reader["id"];
                produto.Descricao = (String)reader["descricao"];
                produto.Preco = (Double)reader["preco"];
            }
            reader.Close();
            return produto;
        }


        public List<Produto> ListAll(Dictionary<String, Object> parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from Produto where 1 = 1 ");
            if (parametros != null && parametros.Count > 0)
            {
                foreach (KeyValuePair<String, Object> par in parametros)
                {
                    sql.Append("and " + par.Key + " = @" + par.Key + " ");
                    comando.Parameters.AddWithValue("@" + par.Key, par.Value);
                }
            }
            comando.CommandText = sql.ToString();
            SqlDataReader reader = comando.ExecuteReader();
            List<Produto> produtos = new List<Produto>();
            while (reader.Read())
            {
                Produto prod = new Produto();
                prod.Id = (Int32)reader["id"];
                prod.Descricao = (String)reader["descricao"];
                prod.Preco = Convert.ToDouble(reader["preco"]);
                produtos.Add(prod);

            }
            return produtos;
        }

        public List<Produto> ListAllByDescricao(String descricao)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            if (tx != null)
            {
                comando.Transaction = tx;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from Produto where 1 = 1 ");
            sql.Append("and descricao like @descricao ");
            comando.Parameters.AddWithValue("@descricao", descricao + "%");

            comando.CommandText = sql.ToString();
            SqlDataReader reader = comando.ExecuteReader();
            List<Produto> produtos = new List<Produto>();
            while (reader.Read())
            {
                Produto prod = new Produto();
                prod.Id = (Int32)reader["id"];
                prod.Descricao = (String)reader["descricao"];
                prod.Preco = Convert.ToDouble(reader["preco"]);
                produtos.Add(prod);

            }
            return produtos;
        }

        public List<Produto> getAll()
        {
            List<Produto> produtos = new List<Produto>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sqlString = new StringBuilder();
            sqlString.Append("SELECT * FROM Produto");
            command.CommandText = sqlString.ToString();
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Produto prod = new Produto();
                prod.Id = (Int32)dataReader["id"];
                prod.Descricao = (String)dataReader["descricao"];
                prod.Preco = Convert.ToDouble(dataReader["preco"]);
                produtos.Add(prod);
            }

            return produtos;
        }
    }
}
