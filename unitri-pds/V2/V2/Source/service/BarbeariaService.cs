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

<<<<<<< HEAD
        public static List<Barbearia> BuscarTodasBarbearias()
=======
        public static List<Barbearia> BuscarTodosBarbearias()
>>>>>>> d70c839188ce89b46505b8e562dfb62a43c4fa66
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

    }
}
