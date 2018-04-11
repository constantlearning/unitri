using IAv1.form;
using IAv1.neural_network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //teste();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treinamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTreinamento frmTreinamento = new FrmTreinamento();
            frmTreinamento.ShowDialog();
        }

        private void testarRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTesteRede frmTesteRede = new FrmTesteRede();
            frmTesteRede.ShowDialog();
        }

        private void teste()
        {
            // Initialize with default Bias.
            Network network = new Network(1);

            // Add inputs to make a training.
            network.addInput(1, 1, 1, 1, 1);
            network.addInput(-1, 1, -1, -1, 1);
            network.addInput(1, 1, 1, -1, -1);
            network.addInput(1, -1, -1, 1, -1);

            // Train network.
            network.trainNetwork();

            // Get adjusted weight.
            List<Double> pesos = network.getAdjustedWeights(); // -2, 2, 0, 2, 0

            // Test network with new wights.
            Double s1 = network.calculate(1, 1, 1, 1);    //  1
            Double s2 = network.calculate(-1, 1, -1, -1); //  1
            Double s3 = network.calculate(1, 1, 1, -1);   // -1
            Double s4 = network.calculate(1, -1, -1, 1);  // -1

            int i = 0; // DEBUG HERE
        }
    }
}
