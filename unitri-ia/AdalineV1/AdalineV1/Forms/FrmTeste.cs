using AdalineV1.Adaline.Network;
using AdalineV1.Network;
using AdalineV1.Network.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdalineV1.Forms
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        internal List<Neuron> neuronios;
        List<Letra> letra;

        private void btnCarregarLetra_Click(object sender, EventArgs e)
        {
            letraBindingSource.DataSource = null;
            Double[] result = combinacoes();

            letra = criarLetra(result);
            letraBindingSource1.DataSource = letra;
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (this.neuronios == null)
            {
                MessageBox.Show("A rede não foi treinada !");
                this.Close();
            }

            String resultado = "";
            double[] input = criarInput();

            neuronios.ForEach(neuron =>
            {
                if (neuron.calcular(input) == 1)
                {
                    resultado += neuron.Nome;
                }
            });

            int x = 0;
            textBox1.Text = resultado;
        }

        private void FrmTeste_Load(object sender, EventArgs e)
        {
            lbLetra.SelectedIndex = 0;
            letra = criarLetra(Fontes.A1);
            letraBindingSource1.DataSource = letra;
        }

        private Double[] criarInput()
        {
            String temp = "";
            letra.ForEach(linha =>
            {
                temp += linha.C1 + ",";
                temp += linha.C2 + ",";
                temp += linha.C3 + ",";
                temp += linha.C4 + ",";
                temp += linha.C5 + ",";
                temp += linha.C6 + ",";
                temp += linha.C7 + ",";
            });

            temp = Regex.Replace(temp, @"(?s)[^-#,](.*?)", "0");
            temp = temp.Replace("-", "-1");
            temp = temp.Replace("#", "1");
            temp = temp.Remove(temp.Length - 1);

            double[] resultado = Array.ConvertAll(temp.Split(','), Double.Parse);

            return resultado;
        }

        private List<Letra> criarLetra(Double[] entrada)
        {
            List<Letra> letra = new List<Letra>();
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                Double[] temp = new Double[7];
                Array.Copy(entrada, count, temp, 0, 7);
                count += 7;

                letra.Add(new Letra(temp));
            }

            return letra;
        }

        private Double[] combinacoes()
        {
            if (rbFonte1.Checked && lbLetra.SelectedIndex == 0) { return Fontes.A1; }
            if (rbFonte1.Checked && lbLetra.SelectedIndex == 1) { return Fontes.B1; }
            if (rbFonte1.Checked && lbLetra.SelectedIndex == 2) { return Fontes.C1; }
            if (rbFonte1.Checked && lbLetra.SelectedIndex == 3) { return Fontes.D1; }
            if (rbFonte1.Checked && lbLetra.SelectedIndex == 4) { return Fontes.E1; }
            if (rbFonte1.Checked && lbLetra.SelectedIndex == 5) { return Fontes.J1; }
            if (rbFonte1.Checked && lbLetra.SelectedIndex == 6) { return Fontes.K1; }

            if (rbFonte2.Checked && lbLetra.SelectedIndex == 0) { return Fontes.A2; }
            if (rbFonte2.Checked && lbLetra.SelectedIndex == 1) { return Fontes.B2; }
            if (rbFonte2.Checked && lbLetra.SelectedIndex == 2) { return Fontes.C2; }
            if (rbFonte2.Checked && lbLetra.SelectedIndex == 3) { return Fontes.D2; }
            if (rbFonte2.Checked && lbLetra.SelectedIndex == 4) { return Fontes.E2; }
            if (rbFonte2.Checked && lbLetra.SelectedIndex == 5) { return Fontes.J2; }
            if (rbFonte2.Checked && lbLetra.SelectedIndex == 6) { return Fontes.K2; }

            if (rbFonte3.Checked && lbLetra.SelectedIndex == 0) { return Fontes.A3; }
            if (rbFonte3.Checked && lbLetra.SelectedIndex == 1) { return Fontes.B3; }
            if (rbFonte3.Checked && lbLetra.SelectedIndex == 2) { return Fontes.C3; }
            if (rbFonte3.Checked && lbLetra.SelectedIndex == 3) { return Fontes.D3; }
            if (rbFonte3.Checked && lbLetra.SelectedIndex == 4) { return Fontes.E3; }
            if (rbFonte3.Checked && lbLetra.SelectedIndex == 5) { return Fontes.J3; }
            if (rbFonte3.Checked && lbLetra.SelectedIndex == 6) { return Fontes.K3; }

            return null;
        }

    }
}
