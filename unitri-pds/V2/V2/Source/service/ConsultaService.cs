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
    class ConsultaService
    {

        public static Atendente BuscarAtendente(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            AtendenteDAO atendenteDAO = new AtendenteDAO(conexao);

            return atendenteDAO.buscarAtendente(id);
        }

        public static Barbearia BuscarBarbearia(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);

            return barbeariaDAO.buscarBarbearia(id);
        }

        public static Cliente BuscarCliente(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ClienteDAO clienteDAO = new ClienteDAO(conexao);

            return clienteDAO.buscarCliente(id);
        }

        public static Filial BuscarFilial(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            FilialDAO filialDAO = new FilialDAO(conexao);

            return filialDAO.buscarFilial(id);
        }

        public static Produto BuscarProduto(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(conexao);

            return produtoDAO.buscarProduto(id);
        }

        public static Servico BuscarServico(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ServicoDAO servicoDAO = new ServicoDAO(conexao);

            return servicoDAO.buscarProduto(id);
        }

        public static Telefone BuscarTelefone(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);

            return telefoneDAO.buscarTelefone(id);
        }
    }
}
