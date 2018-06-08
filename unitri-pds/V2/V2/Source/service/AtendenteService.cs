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
            SqlConnection conexao = FabricaConexao.GetConnection();
            AtendenteDAO atendenteDAO = new AtendenteDAO(conexao);

            return atendenteDAO.buscarAtendente(id);
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

        public static void SalvarAtendente(String nome, String cpf, DateTime nascimento)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            AtendenteDAO atendenteDAO = new AtendenteDAO(conexao);

            Atendente atendente = new Atendente(nome, cpf, nascimento);
            atendenteDAO.salvarAtendente(atendente);
        }
    }
}
