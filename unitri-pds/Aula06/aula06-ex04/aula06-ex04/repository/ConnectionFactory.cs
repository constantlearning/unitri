using System;
using System.Data.SqlClient;

namespace aula06_ex04.repository
{
    class ConnectionFactory
    {
        private static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aula06ex04.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex) { }
        }
    }
}