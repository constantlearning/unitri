using System;
using V2.Source.Entity;

namespace V2.Forms.Cadastro
{
    internal class CadastroService
    {
        internal static void SalvarConveniada(string nome, string telefone)
        {
            Conveniada conveniada = new Conveniada();
            conveniada.Nome = nome;
            conveniada.Telefone = telefone;
            ConveniadaDAO.SalvarConveniada(conveniada);
        }

        internal static void SalvarMotorista(string nome, string sexo, DateTime nascimento, string telefone)
        {
            throw new NotImplementedException();
        }

        internal static void SalvarFuncionario(string nome, string sexo, DateTime nascimento, string telefone)
        {
            throw new NotImplementedException();
        }

        internal static void SalvarVeiculo(string placa, string marcaVeiculo, DateTime dataModelo, DateTime dataFabricacao)
        {
            throw new NotImplementedException();
        }

        internal static void SalvarHabilitacao(Motorista motorista, string categoria, DateTime emissao, DateTime validade)
        {
            throw new NotImplementedException();
        }

        internal static void SalvarChamado(Funcionario funcionario, string origem, string destino, double valor)
        {
            throw new NotImplementedException();
        }
    }
}