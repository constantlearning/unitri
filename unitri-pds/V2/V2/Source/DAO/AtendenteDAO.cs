using System;
using System.Data.SqlClient;
using V2.Source.domain;

namespace V2.Source.service
{
    internal class AtendenteDAO
    {
        private SqlConnection conexao;

        public AtendenteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        internal void salvarAtendente(Atendente atendente)
        {
            throw new NotImplementedException();
        }

        internal Atendente buscarAtendente(int id)
        {
            throw new NotImplementedException();
        }
    }
}