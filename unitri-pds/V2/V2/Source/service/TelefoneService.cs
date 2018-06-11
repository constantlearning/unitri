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
    class TelefoneService
    {

        public static Telefone BuscarTelefoneDoAtendente(Atendente atendente)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);

            return telefoneDAO.buscarTelefoneDoAtendente(atendente);
        }

        public static void SalvarTelefone(String numero)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);

            Telefone telefone = new Telefone(numero);
            telefoneDAO.salvarTelefone(telefone);
        }

        internal static Telefone BuscarTelefoneDoCliente(Cliente cliente)
        {
            SqlConnection conexao = null;

            Telefone telefone;

            try
            {
                conexao = FabricaConexao.GetConnection();
                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);
                telefone = telefoneDAO.buscarTelefoneDoCliente(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return telefone;
        }

        internal static Telefone BuscarTelefoneDaFilial(Filial filial)
        {
            SqlConnection conexao = null;

            Telefone telefone;

            try
            {
                conexao = FabricaConexao.GetConnection();
                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);
                telefone = telefoneDAO.buscarTelefoneDaFilial(filial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return telefone;
        }

        public static Telefone BuscarTelefone(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);

            return telefoneDAO.buscarTelefone(id);
        }
    }
}
