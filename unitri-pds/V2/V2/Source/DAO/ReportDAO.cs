using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Source.DTO;

namespace V2.Source.DAO
{
    class ReportDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public ReportDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public ReportDAO(SqlConnection conexao, SqlTransaction tx) : this(conexao)
        {
            this.tx = tx;
        }

        internal List<PedidoAtendente> buscarQuantidadeDePedidoPorAtendente()
        {
            List<PedidoAtendente> pedidoAtendentes = new List<PedidoAtendente>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT atendente.nome AS nome, COUNT(id_atendente) AS quantidade FROM pedido ");
            sql.Append("INNER JOIN atendente ON atendente.Id = pedido.id_atendente ");
            sql.Append("GROUP BY id_atendente, atendente.nome ");

            command.CommandText = sql.ToString();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PedidoAtendente pedidoAtendente = new PedidoAtendente();
                pedidoAtendente.NomeAtendente = (String)reader["nome"];
                pedidoAtendente.Quantidade = (Int32)reader["quantidade"];

                pedidoAtendentes.Add(pedidoAtendente);
            }

            return pedidoAtendentes;
        }
    }
}
