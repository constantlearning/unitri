using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class TelefoneDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public TelefoneDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public TelefoneDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal void salvarTelefone(Telefone telefone)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO telefone(numero)");
            sql.Append("VALUES (@numero)");
            sql.Append("SELECT @@identity from telefone");
            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("@numero", telefone.Numero);

            decimal id = (decimal)command.ExecuteScalar();
            telefone.Id = Convert.ToInt32(id);
        }

        internal Telefone buscarTelefone(int id)
        {
            throw new NotImplementedException();
        }
    }
}