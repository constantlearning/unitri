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
    class BarbeariaService
    {

        public static Barbearia BuscarBarbearia(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);

            return barbeariaDAO.buscarBarbearia(id);
        }

        public static List<Barbearia> BuscarTodasBarbearias()
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);

            return barbeariaDAO.buscarTodosBarbearias();
        }

        internal static object obterBarbeariasLike(string nome)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);

            return barbeariaDAO.buscarBarbeariasLike(nome);
        }

        internal static Barbearia BuscarBarbeariaDaFilial(Filial filial)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);

            return barbeariaDAO.buscarBarbeariaDaFilial(filial);
        }

        public static void DeletarBarbearia(int idBarbearia)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);
            barbeariaDAO.deletarBarbearia(idBarbearia);
        }

        public static void SalvarBarbearia(String nome, String cnpj)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);

            Barbearia barbearia = new Barbearia(nome, cnpj);
            barbeariaDAO.salvarBarbearia(barbearia);
        }

        internal static void AtualizarBarbearia(Barbearia barbearia)
        {
            SqlConnection conexao = null;

            try
            {
                conexao = FabricaConexao.GetConnection();

                BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);
                barbeariaDAO.atualizarBarbearia(barbearia);
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
