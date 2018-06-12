using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Source.domain;

namespace V2.Source.DAO
{
    class PedidoDAO
    {
        private SqlConnection conexao;
        private SqlTransaction tx;

        public PedidoDAO()
        {
        }

        public PedidoDAO(SqlConnection conexao, SqlTransaction tx)
        {
            this.conexao = conexao;
            this.tx = tx;
        }

        internal void salvarPedido(Pedido pedidoAtual)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = this.conexao;
            if (tx != null)
            {
                command.Transaction = tx;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO pedido(id_barbearia, id_filial, id_atendente, id_cliente)");
            sql.Append("VALUES(@idbarbearia, @idfilial, @idatendente, @idcliente)");
            sql.Append("SELECT @@identity from filial");
            command.CommandText = sql.ToString();
            command.Parameters.AddWithValue("@idbarbearia", pedidoAtual.Barbearia.Id);
            command.Parameters.AddWithValue("@idfilial", pedidoAtual.Filial.Id);
            command.Parameters.AddWithValue("@idatendente", pedidoAtual.Atendente.Id);
            command.Parameters.AddWithValue("@idcliente", pedidoAtual.Cliente.Id);

            decimal id = (decimal)command.ExecuteScalar();
            pedidoAtual.Id = Convert.ToInt32(id);
        }

        internal void salvarItemServicoPedido(ItemServico itemServico)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.Transaction = this.tx;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO pedido_itemservico(id_pedido, id_servico, quantidade) values(@idpedido, @idservico, @quantidade)";
            command.Parameters.AddWithValue("@idpedido", itemServico.Pedido.Id);
            command.Parameters.AddWithValue("@idservico", itemServico.Servico.Id);
            command.Parameters.AddWithValue("@quantidade", itemServico.Quantidade);

            command.ExecuteNonQuery();
        }

        internal void salvarItemProdutoPedido(ItemProduto itemProduto)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = this.conexao;
            command.Transaction = this.tx;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO pedido_itemproduto(id_pedido, id_produto, quantidade) values(@idpedido, @idproduto, @quantidade)";
            command.Parameters.AddWithValue("@idpedido", itemProduto.Pedido.Id);
            command.Parameters.AddWithValue("@idproduto", itemProduto.Produto.Id);
            command.Parameters.AddWithValue("@quantidade", itemProduto.Quantidade);

            command.ExecuteNonQuery();
        }
    }
}
