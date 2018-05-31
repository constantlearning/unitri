using System;
using System.Data.SqlClient;
using V2.Source.Entity;
using V2.Source.Repository;

namespace V2.Forms.Cadastro
{
    internal class CadastroService
    {
        internal static void SalvarConveniada(string nome, string telefone)
        {
            Conveniada conveniada = new Conveniada(nome, telefone);
            ConveniadaDAO.SalvarConveniada(conveniada);
        }

        internal static void SalvarMotorista(string nome, string sexo, DateTime nascimento, string telefone)
        {
            Motorista motorista = new Motorista(nome, sexo, nascimento, telefone);
            MotoristaDAO.SalvarMotorista(motorista);
        }

        internal static void SalvarFuncionario(string nome, string sexo, DateTime nascimento, string telefone, string usuario, string senha)
        {
            SqlConnection conexao = FabricaConexao.GetConexao();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO(conexao);
            Funcionario funcionario = new Funcionario(nome, sexo, nascimento, telefone, usuario, senha);
            funcionarioDAO.salvarFuncionario(funcionario);
        }

        internal static void SalvarVeiculo(string placa, string marcaVeiculo, DateTime dataModelo, DateTime dataFabricacao)
        {
            Veiculo veiculo = new Veiculo(placa, marcaVeiculo, dataModelo, dataFabricacao);
            VeiculoDAO.salvarVeiculo(veiculo);

        }

        internal static void SalvarHabilitacao(Motorista motorista, string categoria, DateTime emissao, DateTime validade)
        {
            Habilitacao habilitacao = new Habilitacao(motorista, categoria, emissao, validade);
            HabilitacaoDAO.salvarHabilitacao(habilitacao);
        }

        internal static void SalvarChamado(Funcionario funcionario, string origem, string destino, double valor)
        {
            Chamado chamado = new Chamado(funcionario, origem, destino, valor);
            ChamadoDAO.salvarChamado(chamado);
        }
    }
}