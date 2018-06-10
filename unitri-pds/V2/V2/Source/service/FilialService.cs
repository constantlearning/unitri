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

        public static void SalvarFilial(Filial filial)
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                FilialDAO filialDAO = new FilialDAO(conexao, tx);
                filialDAO.salvarFilial(filial);
                filialDAO.salvarFilialBarbearia(filial);

                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao, tx);
                telefoneDAO.salvarTelefone(filial.Telefone);
                filialDAO.salvarFilialTelefone(filial);

                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }
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