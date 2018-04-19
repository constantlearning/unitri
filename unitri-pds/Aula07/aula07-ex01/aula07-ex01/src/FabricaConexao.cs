using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_ex01.src
{
    class FabricaConexao
    {
        private static String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas Gontijo\Documents\github\unitri\unitri-pds\Aula07\aula07-ex01\banco.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection obterConexao()
        {
            SqlConnection conexao = new SqlConnection(connString);
            conexao.Open();
            return conexao;
        }

        public static void fecharConexao(SqlConnection conexao)
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex) { }
        }
    }
}
