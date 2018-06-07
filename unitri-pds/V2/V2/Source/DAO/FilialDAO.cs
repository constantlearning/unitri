using System;
using System.Data.SqlClient;
using V2.Source.domain;

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
    }
}