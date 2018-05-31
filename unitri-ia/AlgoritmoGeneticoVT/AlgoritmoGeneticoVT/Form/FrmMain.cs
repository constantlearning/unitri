using AlgoritmoGeneticoVT.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGeneticoVT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            int tamanhoPopulacao = Convert.ToInt32(txtQuantidadePopulacao.Text);
            double taxaDeMutacao = Convert.ToDouble(txtTaxaDeMutacao.Text);
            int maximoDeGeracoes = Convert.ToInt32(txtMaximoDeGeracoes.Text);

            AlgoritmoGenetico algoritmoGenetico = new AlgoritmoGenetico(tamanhoPopulacao, taxaDeMutacao, maximoDeGeracoes);
            algoritmoGenetico.Evolucao();

            txtGeracoes.Text = algoritmoGenetico.QuantidadeDeGeracoes.ToString();

            int[] populacao = algoritmoGenetico.Populacao;
            PreencheListBox(populacao);
        }

        private void PreencheListBox(int[] populacao)
        {
            lbPopulacaoMaiorAptidao.Items.Clear();

            for (int i = 0; i < populacao.Length; i++)
            {
                lbPopulacaoMaiorAptidao.Items.Add("Indivíduo[" + (i + 1) + "] -> " + populacao[i]);
            }
        }
    }
}
