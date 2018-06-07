using System;
using System.Data.SqlClient;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class TelefoneDAO
    {
        private SqlConnection conexao;

        public TelefoneDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        internal void salvarTelefone(Telefone telefone)
        {
            throw new NotImplementedException();
        }

        internal Telefone buscarTelefone(int id)
        {
            throw new NotImplementedException();
        }
    }
}