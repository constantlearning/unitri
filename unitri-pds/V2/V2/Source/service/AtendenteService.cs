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
    class AtendenteService
    {
        public static Atendente BuscarAtendente(Int32 id)
        {
            SqlConnection conexao = null;
            Atendente atendente = new Atendente();

            try
            {
                conexao = FabricaConexao.GetConnection();
                AtendenteDAO atendenteDAO = new AtendenteDAO(conexao);
                atendente = atendenteDAO.buscarAtendente(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return atendente;
        }

        public static List<Atendente> BuscarTodosAtendentes()
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            AtendenteDAO atendenteDAO = new AtendenteDAO(conexao);

            return atendenteDAO.buscarTodosAtendentes();
        }

        internal static object obterClientesLike(string nome)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            AtendenteDAO atendenteDAO = new AtendenteDAO(conexao);

            return atendenteDAO.buscarAtendentesLike(nome);
        }

        public static void DeletarCliente(int idAtendente)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            AtendenteDAO atendenteDAO = new AtendenteDAO(conexao);
            atendenteDAO.deletarAtendente(idAtendente);
        }

        public static void SalvarAtendente(Atendente atendente)
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                AtendenteDAO atendenteDAO = new AtendenteDAO(conexao, tx);
                atendenteDAO.salvarAtendente(atendente);
                atendenteDAO.salvarAtendenteFilial(atendente);

                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao, tx);
                telefoneDAO.salvarTelefone(atendente.Telefone);
                atendenteDAO.salvarAtendenteTelefone(atendente);
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

        public static void AtualizarAtendente(Atendente atendente)
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                AtendenteDAO atendenteDAO = new AtendenteDAO(conexao, tx);
                atendenteDAO.atualizarAtendente(atendente);

                FilialDAO filialDAO = new FilialDAO(conexao, tx);
                filialDAO.atualizarFilialDoAtendente(atendente);

                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao, tx);
                telefoneDAO.atualizarTelefoneDoAtendente(atendente);

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
