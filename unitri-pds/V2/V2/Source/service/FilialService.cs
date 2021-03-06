﻿using System;
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

        internal static List<Filial> obterFiliaisLike(string nome)
        {
            SqlConnection conexao = null;
            List<Filial> filiais;

            try
            {
                conexao = FabricaConexao.GetConnection();
                FilialDAO filialDAO = new FilialDAO(conexao);
                filiais = filialDAO.buscarFiliaisLike(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return filiais;
        }

        internal static List<Filial> BuscarFiliaisDaBarbearia(Barbearia barbearia)
        {
            SqlConnection conexao = null;
            List<Filial> filiais;

            try
            {
                conexao = FabricaConexao.GetConnection();
                FilialDAO filialDAO = new FilialDAO(conexao);
                filiais = filialDAO.buscarFiliaisDaBarbearia(barbearia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

            return filiais;
        }

        internal static void DeletarFilial(int idFilial)
        {
            SqlConnection conexao = null;
            try
            {
                conexao = FabricaConexao.GetConnection();
                FilialDAO filialDAO = new FilialDAO(conexao);
                filialDAO.deletarFilial(idFilial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FabricaConexao.CloseConnection(conexao);
            }

        }

        internal static void AtualizarFilial(Filial filial)
        {
            SqlConnection conexao = null;
            SqlTransaction tx = null;

            try
            {
                conexao = FabricaConexao.GetConnection();
                tx = conexao.BeginTransaction();

                FilialDAO filialDAO = new FilialDAO(conexao, tx);
                filialDAO.atualizarFilial(filial);

                BarbeariaDAO barbeariaDAO = new BarbeariaDAO(conexao, tx);
                barbeariaDAO.atualizarBarbeariaDaFilial(filial);

                TelefoneDAO telefoneDAO = new TelefoneDAO(conexao, tx);
                telefoneDAO.atualizarTelefoneDaFilial(filial);

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

        public static Filial BuscarFilialDoAtendente(Atendente atendente)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            FilialDAO filialDAO = new FilialDAO(conexao);

            return filialDAO.buscarFilialDoAtendente(atendente);
        }

        internal static List<Filial> buscarTodasFiliais()
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            FilialDAO filialDAO = new FilialDAO(conexao);

            return filialDAO.buscarTodasFiliais();
        }


    }
}