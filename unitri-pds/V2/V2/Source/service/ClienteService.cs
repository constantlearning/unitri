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

        internal static Cliente BuscarCliente(int idCliente)
        {
            SqlConnection conexao = null;
            Cliente cliente = new Cliente();

            try
            {
                conexao = FabricaConexao.GetConnection();
                ClienteDAO clienteDAO = new ClienteDAO(conexao);
                cliente = clienteDAO.buscarCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return cliente;
        }

        internal static void DeletarCliente(int idCliente)
        {
            SqlConnection conexao = null;
            try
            {
                conexao = FabricaConexao.GetConnection();
                ClienteDAO clienteDAO = new ClienteDAO(conexao);
                clienteDAO.deletarCliente(idCliente);
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

        internal static void AtualizarCliente(Cliente cliente)
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                ClienteDAO clienteDAO = new ClienteDAO(conexao, tx);
                clienteDAO.atualizarCliente(cliente);

                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao, tx);
                telefoneDAO.atualizarTelefoneDoCliente(cliente);

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

        internal static List<Cliente> BuscarTodosClientes()
        {
            SqlConnection conexao = null;
            List<Cliente> clientes;

            try
            {
                conexao = FabricaConexao.GetConnection();
                ClienteDAO clienteDAO = new ClienteDAO(conexao);
                clientes = clienteDAO.BuscarTodosClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return clientes;
        }

        internal static List<Cliente> obterClientesLike(string nome)
        {
            SqlConnection conexao = null;

            List<Cliente> clientes;

            try
            {
                conexao = FabricaConexao.GetConnection();
                ClienteDAO clienteDAO = new ClienteDAO(conexao);
                clientes = clienteDAO.buscarClientesLike(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return clientes;
        }

    }
}
