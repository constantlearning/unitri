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

        private void btnCarregarLetra_Click(object sender, EventArgs e)
        {
            letraBindingSource.DataSource = null;
            Double[] result = combinacoes();
            letraBindingSource.DataSource = criarLetra(result);
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {

        }

        private void FrmTeste_Load(object sender, EventArgs e)
        {
            lbLetra.SelectedIndex = 0;
            letraBindingSource.DataSource = criarLetra(Fontes.A1);
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
