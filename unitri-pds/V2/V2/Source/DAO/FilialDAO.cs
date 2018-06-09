using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    internal class FilialDAO
    {
        private SqlConnection conexao;

        public FilialDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        internal void salvarFilial(Filial filial)
        {
            throw new NotImplementedException();
        }

        internal Filial buscarFilial(int id)
        {
            throw new NotImplementedException();
        }

        internal List<Filial> buscarTodasFiliais()
        {
            List<Filial> filiais = new List<Filial>();

            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM filial";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Filial filial = new Filial();
                filial.Id = (Int32)reader["Id"];
                filial.Cnpj = (String)reader["cnpj"];
                filial.Nome = (String)reader["nome"];
                filial.Endereco = (String) reader["endereco"];

                filiais.Add(filial);
            }

            FabricaConexao.CloseConnection(conexao);

            return filiais;
        }
    }
}