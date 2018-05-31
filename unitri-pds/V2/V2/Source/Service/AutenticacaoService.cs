using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Forms.Cadastro;
using V2.Source.Entity;
using V2.Source.Repository;

namespace V2.Source.Service
{
    class AutenticacaoService
    {
        internal static Funcionario RealizarLogin(string usuario, string senha)
        {
            SqlConnection conexao = FabricaConexao.GetConexao();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO(conexao);
            Funcionario funcionario = funcionarioDAO.BuscarPelaCredencial(usuario, senha);
            return funcionario;
        }
    }
}
