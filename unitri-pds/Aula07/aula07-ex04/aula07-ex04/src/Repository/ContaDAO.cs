using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex04.src.Repository
{
    class ContaDAO
    {
        private SqlConnection conexao;
        private SqlTransaction transacao;

        public ContaDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public ContaDAO(SqlConnection conexao, SqlTransaction transacao)
        {
            this.conexao = conexao;
            this.transacao = transacao;
        }

        public List<Conta> obterContas()
        {
            List<Conta> contas = new List<Conta>();

            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Conta";

            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                Conta conta = new Conta();
                conta.Numero = (Int32)dataReader["id"];
                conta.Agencia = (Int32)dataReader["agencia"];
                conta.Limite = (Double)dataReader["limite"];
                conta.Saldo = (Double)dataReader["saldo"];

                contas.Add(conta);
            }

            return contas;
        }

        private Conta obterConta(Int32 id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;

            if (transacao != null)
            {
                comando.Transaction = transacao;
            }

            comando.CommandText = "SELECT * FROM Conta WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);

            SqlDataReader dataReader = comando.ExecuteReader();

            Conta conta = null;

            if (dataReader.Read())
            {
                conta = new Conta();
                conta.Numero = (Int32)dataReader["id"];
                conta.Agencia = (Int32)dataReader["agencia"];
                conta.Limite = (Double)dataReader["limite"];
                conta.Saldo = (Double)dataReader["saldo"];
                dataReader.Close();
            }

            return conta;
        }

        public Boolean Depositar(Int32 id, Double valor)
        {

            Conta conta = obterConta(id);
            conta.Depositar(valor);

            return atualizarSaldo(conta);
        }

        public Boolean Sacar(Int32 id, Double valor)
        {
            Conta conta = obterConta(id);
            conta.Sacar(valor);

            return atualizarSaldo(conta);
        }

        private bool atualizarSaldo(Conta conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.conexao;
            comando.CommandType = CommandType.Text;

            if (transacao != null)
            {
                comando.Transaction = transacao;
            }

            StringBuilder sqlData = new StringBuilder();
            sqlData.Append("UPDATE Conta ");
            sqlData.Append("SET saldo = @saldo ");
            sqlData.Append("WHERE id = @id");

            comando.CommandText = sqlData.ToString();
            comando.Parameters.AddWithValue("id", conta.Numero);
            comando.Parameters.AddWithValue("saldo", conta.Saldo);

            int result = comando.ExecuteNonQuery();

            return result >= 1;
        }

    }
}
