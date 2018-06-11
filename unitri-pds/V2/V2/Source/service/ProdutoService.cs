using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    class ProdutoService
    {

        public static void SalvarProduto(Produto produto)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(conexao);
            produtoDAO.salvarProduto(produto);
        }


        public static Produto BuscarProduto(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(conexao);
            return produtoDAO.buscarProduto(id);
        }

        internal static List<Produto> ObterProdutosLike(string filtro)
        {
            SqlConnection conexao = null;
            List<Produto> filiais;

            try
            {
                conexao = FabricaConexao.GetConnection();
                ProdutoDAO produtoDAO = new ProdutoDAO(conexao);
                filiais = produtoDAO.obterProdutosLike(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return filiais;
        }

        internal static void DeletarProduto(int idProduto)
        {
            SqlConnection conexao = null;
            try
            {
                conexao = FabricaConexao.GetConnection();
                ProdutoDAO produtoDAO = new ProdutoDAO(conexao);
                produtoDAO.deletarProduto(idProduto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }
        }

        internal static void AtualizarProduto(Produto produto)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = FabricaConexao.GetConnection();

                ProdutoDAO produtoDAO = new ProdutoDAO(conexao);
                produtoDAO.atualizarProduto(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }
        }

        internal static object BuscarTodosProdutos()
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(conexao);

            return produtoDAO.buscarTodosProdutos();
        }
    }
}
