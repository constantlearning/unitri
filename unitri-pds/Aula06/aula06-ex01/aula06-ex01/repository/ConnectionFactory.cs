using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06_ex01.repository
{
    class ConnectionFactory
    {

        private static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\Projetos VS2017\unitri-pds\Aula06\aula06-ex01\aula06-ex01\banco.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection getConexao()
        {
            SqlConnection conexao = new SqlConnection(conString);
            conexao.Open();
            return conexao;
        }

        public static void closeConnection(SqlConnection conexao)
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex){}
        }
    }
}
