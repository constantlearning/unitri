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
    class ServicoService
    {
        internal static void SalvarServico(Servico servico)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                ServicoDAO servicoDAO = new ServicoDAO(conexao);
                servicoDAO.SalvarServico(servico);
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

        internal static List<Servico> ObterServicosLike(string filtro)
        {
            List<Servico> servicos;
            SqlConnection conexao = null;
            try
            {
                conexao = FabricaConexao.GetConnection();
                ServicoDAO servicoDAO = new ServicoDAO(conexao);
                servicos = servicoDAO.obterServicosLike(filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return servicos;
        }

        public static Servico BuscarServico(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ServicoDAO servicoDAO = new ServicoDAO(conexao);

            return servicoDAO.buscarProduto(id);
        }

        internal static void DeletarServico(int idServico)
        {
            SqlConnection conexao = null;
            try
            {
                conexao = FabricaConexao.GetConnection();
                ServicoDAO servicoDAO = new ServicoDAO(conexao);
                servicoDAO.deletarServico(idServico);
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

        internal static List<Servico> BuscarTodosServicos()
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ServicoDAO servicoDAO = new ServicoDAO(conexao);

            return servicoDAO.buscarTodosServicos();
        }

        internal static void AtualizarServico(Servico servico)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = FabricaConexao.GetConnection();

                ServicoDAO servicoDAO = new ServicoDAO(conexao);
                servicoDAO.atualizarProduto(servico);
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
    }
}
