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

        internal static List<Pedido> BuscarTodosPedidos()
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            List<Pedido> pedidos;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                PedidoDAO pedidoDAO = new PedidoDAO(conexao, tx);
                pedidos = pedidoDAO.buscarTodosPedidos();

                foreach (Pedido pedido in pedidos)
                {
                    BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao, tx);
                    pedido.Barbearia = barbeariaDAO.buscarBarbeariaDoPedido(pedido);

                    FilialDAO filialDAO = new FilialDAO(conexao, tx);
                    pedido.Filial = filialDAO.buscarFilialDoPedido(pedido);

                    AtendenteDAO atendenteDAO = new AtendenteDAO(conexao, tx);
                    pedido.Atendente = atendenteDAO.buscalAtendenteDoPedido(pedido);

                    ClienteDAO clienteDAO = new ClienteDAO(conexao, tx);
                    pedido.Cliente = clienteDAO.buscarClienteDoPedido(pedido);

                    ProdutoDAO produtoDAO = new ProdutoDAO(conexao, tx);
                    pedido.ItemProdutos = produtoDAO.buscarItemProdutoDoPedido(pedido);

                    foreach (ItemProduto itemProduto in pedido.ItemProdutos)
                    {
                        itemProduto.Pedido = pedido;
                        itemProduto.Produto = produtoDAO.buscarProdutoDoPedido(itemProduto);
                        itemProduto.calcularValor();
                    }

                    ServicoDAO servicoDAO = new ServicoDAO(conexao, tx);
                    pedido.ItemServicos = servicoDAO.buscarItemServicoDoPedido(pedido);

                    foreach (ItemServico itemServico in pedido.ItemServicos)
                    {
                        itemServico.Pedido = pedido;
                        itemServico.Servico = servicoDAO.buscarServicoDoPedido(itemServico);
                        itemServico.calcularValor();
                    }

                    pedido.atualizaTotal();
                }
            }
            catch
            {
                tx.Rollback();
                throw;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return pedidos;
        }
    }
}
