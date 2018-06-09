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
    class CadastroService
    {
        public static void SalvarBarbearia(String nome, String cnpj)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao);

            Barbearia barbearia = new Barbearia(nome, cnpj);
            barbeariaDAO.salvarBarbearia(barbearia);
        }

        public static void SalvarCliente(String nome, String cpf, DateTime nascimento)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ClienteDAO clienteDAO = new ClienteDAO(conexao);

            Cliente cliente = new Cliente(nome, cpf, nascimento);
            clienteDAO.salvarCliente(cliente);
        }


        public static void SalvarProduto(String nome, String descricao, Double valor)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(conexao);

            Produto produto = new Produto(nome, descricao, valor);
            produtoDAO.salvarProduto(produto);
        }

        public static void SalvarServico(String nome, String descricao, Double valor)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ServicoDAO servicoDAO = new ServicoDAO(conexao);

            Servico servico = new Servico(nome, descricao, valor);
            servicoDAO.salvarProduto(servico);
        }

        public static void SalvarTelefone(String numero)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);

            Telefone telefone = new Telefone(numero);
            telefoneDAO.salvarTelefone(telefone);
        }
    }
}
