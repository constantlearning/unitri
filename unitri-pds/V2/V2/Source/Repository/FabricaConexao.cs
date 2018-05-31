﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2.Source.Repository
{
    class FabricaConexao
    {

        public static String strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\github\unitri\unitri-pds\V2\database.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection GetConexao()
        {
            SqlConnection con = new SqlConnection(strConexao);
            con.Open();
            return con;
        }

        public static void CloseConexao(SqlConnection con)
        {
            try
            {
                con.Close();
            }
            catch (Exception) { }
        }
    }
}
