using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Source.DAO;
using V2.Source.DTO;
using V2.Source.util;

namespace V2.Source.service
{
    class ReportService
    {
        public static List<PedidoAtendente> buscarQuantidadeDePedidoPorAtendente()
        {
            SqlConnection conexao = null;

            List<PedidoAtendente> pedidoAtendente;

            try
            {
                conexao = FabricaConexao.GetConnection();

                ReportDAO reportDAO = new ReportDAO(conexao);
                pedidoAtendente = reportDAO.buscarQuantidadeDePedidoPorAtendente();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return pedidoAtendente;
        }
    }
}
