using System;
using System.Data.SqlClient;
using V2.Source.Entity;
using V2.Source.Repository;

namespace V2.Forms.Cadastro
{
    internal class FuncionarioDAO
    {

        private SqlConnection conexao;
        private SqlTransaction tx;

        public FuncionarioDAO(SqlConnection con)
        {
            this.conexao = con;
        }

        public FuncionarioDAO(SqlConnection con, SqlTransaction tx)
        {
            this.conexao = con;
            this.tx = tx;
        }

        internal void salvarFuncionario(Funcionario funcionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;

            if (tx != null)
            {
                comando.Transaction = tx;
            }

            comando.CommandText = "INSERT INTO funcionario (nome, sexo, nascimento, telefone, login, senha)" +
                                  "VALUES (@nome, @sexo, @nascimento, @telefone, @usuario, @senha)";

            comando.Parameters.AddWithValue("@nome", funcionario.Nome);
            comando.Parameters.AddWithValue("@sexo", funcionario.Sexo);
            comando.Parameters.AddWithValue("@nascimento", funcionario.Nascimento);
            comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
            comando.Parameters.AddWithValue("@usuario", funcionario.Usuario);
            comando.Parameters.AddWithValue("@senha", funcionario.Senha);

            comando.ExecuteNonQuery();
    }

        internal Funcionario BuscarPelaCredencial(string usuario, string senha)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;

            if (tx != null)
            {
                comando.Transaction = tx;
            }

            comando.CommandText = "select * from funcionario where login = @login and senha = @senha";
            comando.Parameters.AddWithValue("@login", usuario);
            comando.Parameters.AddWithValue("@senha", senha);

            SqlDataReader reader = comando.ExecuteReader();
            Funcionario funcionario = null;

            if (reader.Read())
            {
                funcionario = new Funcionario();
                funcionario.Id = (Int32)reader["id"];
                funcionario.Nome = (String)reader["nome"];
                funcionario.Sexo = (String)reader["sexo"];
            }
            reader.Close();
            return funcionario;

        }

    }
}