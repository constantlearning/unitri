using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Source.domain;
using V2.Source.DTO;
using V2.Source.DTO.graphic;
using V2.Source.DTO.report;

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

        internal List<PedidoReport> BuscarPedidosEntreDuasDatas(DateTime dataInicial, DateTime dataFinal)
        {
            List<PedidoReport> pedidoReports = new List<PedidoReport>();
            String inicio = dataInicial.ToString("yyyy-MM-dd");
            String final = dataFinal.ToString("yyyy-MM-dd");

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT pedido.Id, atendente.nome AS atendente, filial.nome AS filial, cliente.nome AS cliente, barbearia.name AS barbearia, pedido.data_pedido ");
            sql.Append("FROM atendente ");
            sql.Append("INNER JOIN pedido ON atendente.Id = pedido.id_atendente ");
            sql.Append("INNER JOIN pedido_itemproduto ON pedido_itemproduto.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN produto ON pedido_itemproduto.id_produto = produto.Id ");
            sql.Append("INNER JOIN pedido_itemservico ON pedido_itemservico.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN servico ON pedido_itemservico.id_servico = servico.Id ");
            sql.Append("INNER JOIN cliente ON cliente.Id = pedido.id_cliente ");
            sql.Append("INNER JOIN barbearia ON barbearia.Id = pedido.id_barbearia ");
            sql.Append("INNER JOIN filial ON filial.Id = pedido.id_filial ");
            sql.Append("WHERE pedido.data_pedido BETWEEN '" + inicio + "' AND '" + final + "' ");

            command.CommandText = sql.ToString();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PedidoReport pedidoReport = new PedidoReport();
                pedidoReport.Id = (Int32)reader["Id"];
                pedidoReport.Cliente = (String)reader["cliente"];
                pedidoReport.Barbearia = (String)reader["barbearia"];
                pedidoReport.Filial = (String)reader["filial"];
                pedidoReport.Data = (DateTime)reader["data_pedido"];
                pedidoReport.Atendente = (String)reader["atendente"];

                pedidoReports.Add(pedidoReport);
            }

            return pedidoReports;
        }

        internal List<PedidoReport> buscarPedidosDoAtendente(Atendente atendenteSelecionado)
        {
            List<PedidoReport> pedidoReports = new List<PedidoReport>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT pedido.Id, atendente.nome AS atendente, filial.nome AS filial, cliente.nome AS cliente, barbearia.name AS barbearia, filial.nome AS filial, pedido.data_pedido ");
            sql.Append("FROM atendente ");
            sql.Append("INNER JOIN pedido ON atendente.Id = pedido.id_atendente ");
            sql.Append("INNER JOIN pedido_itemproduto ON pedido_itemproduto.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN produto ON pedido_itemproduto.id_produto = produto.Id ");
            sql.Append("INNER JOIN pedido_itemservico ON pedido_itemservico.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN servico ON pedido_itemservico.id_servico = servico.Id ");
            sql.Append("INNER JOIN cliente ON cliente.Id = pedido.id_cliente ");
            sql.Append("INNER JOIN barbearia ON barbearia.Id = pedido.id_barbearia ");
            sql.Append("INNER JOIN filial ON filial.Id = pedido.id_filial ");
            sql.Append("WHERE atendente.Id = @id ");

            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("id", atendenteSelecionado.Id);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PedidoReport pedidoReport = new PedidoReport();
                pedidoReport.Id = (Int32)reader["Id"];
                pedidoReport.Cliente = (String)reader["cliente"];
                pedidoReport.Barbearia = (String)reader["barbearia"];
                pedidoReport.Filial = (String)reader["filial"];
                pedidoReport.Data = (DateTime)reader["data_pedido"];
                pedidoReport.Atendente = (String)reader["atendente"];

                pedidoReports.Add(pedidoReport);
            }

            return pedidoReports;
        }

        internal List<FaturamentoBarbearia> buscarFaturamentoDasBarbearias()
        {
            List<FaturamentoBarbearia> faturamentoBarbearia = new List<FaturamentoBarbearia>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT barbearia.name AS nome, SUM((pedido_itemproduto.quantidade * produto.valor) + (pedido_itemservico.quantidade * servico.valor)) AS total ");
            sql.Append("FROM barbearia ");
            sql.Append("INNER JOIN pedido ON barbearia.Id = pedido.id_barbearia ");
            sql.Append("INNER JOIN pedido_itemproduto ON pedido_itemproduto.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN produto ON pedido_itemproduto.id_produto = produto.Id ");
            sql.Append("INNER JOIN pedido_itemservico ON pedido_itemservico.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN servico ON pedido_itemservico.id_servico = servico.Id ");
            sql.Append("GROUP BY barbearia.name ");

            command.CommandText = sql.ToString();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FaturamentoBarbearia barbeariaFaturamento = new FaturamentoBarbearia();
                barbeariaFaturamento.NomeBarbearia = (String)reader["nome"];
                barbeariaFaturamento.Faturamento = (Double)reader["total"];

                faturamentoBarbearia.Add(barbeariaFaturamento);
            }

            return faturamentoBarbearia;
        }

        internal List<PedidoReport> buscarPedidosDaFilial(Filial filialSelecionada)
        {
            List<PedidoReport> pedidoReports = new List<PedidoReport>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT pedido.Id, atendente.nome AS atendente, filial.nome AS filial, cliente.nome AS cliente, barbearia.name AS barbearia, filial.nome AS filial, pedido.data_pedido ");
            sql.Append("FROM pedido ");
            sql.Append("INNER JOIN pedido_itemproduto ON pedido_itemproduto.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN produto ON pedido_itemproduto.id_produto = produto.Id ");
            sql.Append("INNER JOIN pedido_itemservico ON pedido_itemservico.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN servico ON pedido_itemservico.id_servico = servico.Id ");
            sql.Append("INNER JOIN cliente ON cliente.Id = pedido.id_cliente ");
            sql.Append("INNER JOIN barbearia ON barbearia.Id = pedido.id_barbearia ");
            sql.Append("INNER JOIN filial ON filial.Id = pedido.id_filial ");
            sql.Append("INNER JOIN atendente ON atendente.Id = pedido.id_atendente ");
            sql.Append("WHERE filial.Id = @id ");

            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("id", filialSelecionada.Id);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PedidoReport pedidoReport = new PedidoReport();
                pedidoReport.Id = (Int32)reader["Id"];
                pedidoReport.Cliente = (String)reader["cliente"];
                pedidoReport.Barbearia = (String)reader["barbearia"];
                pedidoReport.Filial = (String)reader["filial"];
                pedidoReport.Data = (DateTime)reader["data_pedido"];
                pedidoReport.Atendente = (String)reader["atendente"];

                pedidoReports.Add(pedidoReport);
            }

            return pedidoReports;
        }

        internal List<FaturamentoFilial> buscarFaturamentoDasFiliais()
        {
            List<FaturamentoFilial> faturamentoFilial = new List<FaturamentoFilial>();

            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.CommandType = CommandType.Text;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT filial.nome AS nome, SUM((pedido_itemproduto.quantidade * produto.valor) + (pedido_itemservico.quantidade * servico.valor)) AS total ");
            sql.Append("FROM filial ");
            sql.Append("INNER JOIN pedido ON filial.Id = pedido.id_filial ");
            sql.Append("INNER JOIN pedido_itemproduto ON pedido_itemproduto.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN produto ON pedido_itemproduto.id_produto = produto.Id ");
            sql.Append("INNER JOIN pedido_itemservico ON pedido_itemservico.id_pedido = pedido.Id ");
            sql.Append("INNER JOIN servico ON pedido_itemservico.id_servico = servico.Id ");
            sql.Append("GROUP BY filial.nome");

            command.CommandText = sql.ToString();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FaturamentoFilial filialFaturamento = new FaturamentoFilial();
                filialFaturamento.NomeFilial = (String)reader["nome"];
                filialFaturamento.Faturamento = (Double)reader["total"];

                faturamentoFilial.Add(filialFaturamento);
            }

            return faturamentoFilial;
        }
    }
}
