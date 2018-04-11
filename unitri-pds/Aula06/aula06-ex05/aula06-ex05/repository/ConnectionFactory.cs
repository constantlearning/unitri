using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06_ex05.repository
{
    class ConnectionFactory
    {

        public static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\Projetos VS2017\unitri-pds\Aula06\aula06-ex05\aula06ex05.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
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
