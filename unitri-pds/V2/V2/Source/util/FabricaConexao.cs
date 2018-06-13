using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace V2.Source.util
{
    class FabricaConexao
    {
        //private static String connectionString = Properties.Settings.Default.databaseConnectionString;

        private static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\github\unitri\unitri-pds\V2\V2\database.mdf;Integrated Security=True;Connect Timeout=30; MultipleActiveResultSets=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public static void CloseConnection(SqlConnection con) {
            try
            {
                con.Close();
            }
            catch (Exception) { }
        }
    }
}
