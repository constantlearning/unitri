using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex04.src.Repository
{
    class FabricaConexao
    {
        private static String stringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\github\unitri\unitri-pds\Aula07\aula07-ex04\bancoex04.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection ObterConexao()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public static void FecharConexao(SqlConnection con)
        {
            try
            {
                con.Close();
            }
            catch (Exception ex) {}
        }

    }
}
