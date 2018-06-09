using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using V2.Source.domain;
using V2.Source.service;
using V2.Source.util;

namespace V2.Forms.register
{
    internal class FilialService
    {

        public static void SalvarFilial(String nome, String endereco, String cnpj)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            FilialDAO filialDAO = new FilialDAO(conexao);

            Filial filial = new Filial(nome, endereco, cnpj);
            filialDAO.salvarFilial(filial);
        }

        public static Filial BuscarFilial(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            FilialDAO filialDAO = new FilialDAO(conexao);

            return filialDAO.buscarFilial(id);
        }

        internal static List<Filial> buscarTodasFiliais()
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            FilialDAO filialDAO = new FilialDAO(conexao);

            return filialDAO.buscarTodasFiliais();
        }
    }
}