using aula07_ex04.src;
using aula07_ex04.src.Repository;
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

namespace aula07_ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContaDAO contaDAO = new ContaDAO(FabricaConexao.ObterConexao());
            List<Conta> contas = contaDAO.obterContas();

            bindingSourceOrigem.DataSource = contas;
            bindingSourceDestino.DataSource = new List<Conta>(contas);

            cbOrigem.DataSource = bindingSourceOrigem.DataSource;
            cbDestino.DataSource = bindingSourceDestino.DataSource;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Conta origem = (Conta)cbOrigem.SelectedItem;
            Conta destino = (Conta)cbDestino.SelectedItem;

            if (origem.Numero == destino.Numero)
            {
                MessageBox.Show("Origem e destino são iguais.");
                return;
            }

            Double valor = Convert.ToDouble(txtValor.Text);

            SqlConnection conexao = FabricaConexao.ObterConexao();
            SqlTransaction tx = conexao.BeginTransaction();
            try
            {
                ContaDAO contaDAO = new ContaDAO(conexao, tx);
                contaDAO.Sacar(origem.Numero, valor);
                contaDAO.Depositar(destino.Numero, valor);
                tx.Commit();

                MessageBox.Show("Transferência feita com sucesso!");
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Falha na transferência!");
            }
            finally
            {
                FabricaConexao.FecharConexao(conexao);
            }

            // Não sacar e transferir para a mesma conta.
            // Abrir uma conexao e repassar para o DAO junto com a transação.
        }
    }
}
