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
    class ProdutoService
    {

        public static void SalvarProduto(Produto produto)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(conexao);
            produtoDAO.salvarProduto(produto);
        }


        public static Produto BuscarProduto(Int32 id)
        {
            SqlConnection conexao = FabricaConexao.GetConnection();
            ProdutoDAO produtoDAO = new ProdutoDAO(conexao);
            return produtoDAO.buscarProduto(id);
        }

    }
}
