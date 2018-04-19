using aula07_ex01.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula07_ex01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = FabricaConexao.obterConexao();
            Produto prod = new Produto(2, "macarrão", 12.34);
            ProdutoDAO produtoDao = new ProdutoDAO(con);
            produtoDao.Insert(prod);
            MessageBox.Show("Inserido: " + prod.ToString());
            dgvProdutos.DataSource = produtoDao.getAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = FabricaConexao.obterConexao();
            Produto prod = new Produto(2, "macarrão editado", 33.55);
            ProdutoDAO produtoDao = new ProdutoDAO(con);
            produtoDao.Update(prod);
            MessageBox.Show("Atualizado: " + prod.ToString());
            dgvProdutos.DataSource = produtoDao.getAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = FabricaConexao.obterConexao();
            Produto prod = new Produto(2, "não importa", 0.0);
            ProdutoDAO produtoDao = new ProdutoDAO(con);
            produtoDao.Delete(prod);
            MessageBox.Show("Deletado: " + prod.ToString());
            dgvProdutos.DataSource = produtoDao.getAll();
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            SqlConnection con = FabricaConexao.obterConexao();
            ProdutoDAO produtoDao = new ProdutoDAO(con);
            List<Produto> produtos = produtoDao.ListAll(null);
            dgvProdutos.DataSource = produtos;
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            SqlConnection con = FabricaConexao.obterConexao();
            ProdutoDAO produtoDao = new ProdutoDAO(con);
            Dictionary<String, Object> parametros = new Dictionary<string, object>();
            parametros.Add("descricao", "batata");
            List<Produto> produtos = produtoDao.ListAll(parametros);
            dgvProdutos.DataSource = produtos;
        }

        private void btnSelect3_Click(object sender, EventArgs e)
        {
            SqlConnection con = FabricaConexao.obterConexao();
            ProdutoDAO produtoDao = new ProdutoDAO(con);
            List<Produto> produtos = produtoDao.ListAllByDescricao("ma");
            dgvProdutos.DataSource = produtos;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SqlConnection con = FabricaConexao.obterConexao();
            ProdutoDAO produtoDAO = new ProdutoDAO(con);
            List<Produto> produtos = produtoDAO.getAll();
            dgvProdutos.DataSource = produtos;
        }
    }
}
