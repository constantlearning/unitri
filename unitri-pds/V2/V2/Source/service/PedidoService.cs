using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Source.DAO;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    class PedidoService
    {
        internal static void SalvarPedido(Pedido pedidoAtual)
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                PedidoDAO pedidoDAO = new PedidoDAO(conexao, tx);
                pedidoDAO.salvarPedido(pedidoAtual);

                foreach (ItemProduto produto in pedidoAtual.ItemProdutos)
                {
                    pedidoDAO.salvarItemProdutoPedido(produto);
                }

                foreach (ItemServico servico in pedidoAtual.ItemServicos)
                {
                    pedidoDAO.salvarItemServicoPedido(servico);
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }
        }
    }
}
