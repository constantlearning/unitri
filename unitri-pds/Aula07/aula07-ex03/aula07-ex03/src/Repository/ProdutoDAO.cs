using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex03.src.Repository
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

        public List<Produto> obterProdutos()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;

            if (tx != null)
            {
                comando.Transaction = tx;
            }

            comando.CommandText = "SELECT * FROM Produto";
            SqlDataReader reader = comando.ExecuteReader();

            List<Produto> produtos = new List<Produto>();

            while (reader.Read())
            {
                Produto prod = new Produto();
                prod.Id = (Int32)reader["id"];
                prod.Codigo = (Int32)reader["codigo"];
                prod.Descricao = (String)reader["descricao"];
                prod.PrecoCusto = (Double)reader["preco_custo"];
                prod.PrecoVenda = (Double)reader["preco_venda"];
                produtos.Add(prod);
            }

            return produtos;
        }
    }
}
