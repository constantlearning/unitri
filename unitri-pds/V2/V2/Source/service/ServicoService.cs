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

        public static Servico BuscarServico(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ServicoDAO servicoDAO = new ServicoDAO(conexao);

            return servicoDAO.buscarProduto(id);
        }
    }
}
