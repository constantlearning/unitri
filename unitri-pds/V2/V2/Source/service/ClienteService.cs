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
    class ClienteService
    {

        public static void SalvarCliente(Cliente cliente)
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                ClienteDAO clienteDAO = new ClienteDAO(conexao, tx);
                clienteDAO.salvarCliente(cliente);

                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao, tx);
                telefoneDAO.salvarTelefone(cliente.Telefone);
                clienteDAO.salvarClienteTelefone(cliente);
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
