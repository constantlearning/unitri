using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V2.Source.domain;
using V2.Source.util;

namespace V2.Source.service
{
    class TelefoneService
    {

        public static Telefone BuscarTelefoneDoAtendente(Atendente atendente)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            TelefoneDAO telefoneDAO = new TelefoneDAO(conexao);

            return telefoneDAO.buscarTelefoneDoAtendente(atendente);
        }
    }
}
