using System;
using System.Data.SqlClient;

namespace aula06_ex03.repository
{
    class ConnectionFactory
    {
        private static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\Projetos VS2017\unitri-pds\Aula06\aula06-ex03\aula06ex03.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch(Exception ex) { }
        }
    }
}