using AdalineV1.Adaline.Network;
using AdalineV1.Network;
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
    public partial class FrmTreinamento : Form
    {
        public FrmTreinamento()
        {
            InitializeComponent();
        }

        internal List<Neuron> neuronios;

        private void btnTreinar_Click(object sender, EventArgs e)
        {
            List<Double[]> vetoresTreinamento = Fontes.obterVetoresTreinamento();

            Neuron redeA = new Neuron("A", vetoresTreinamento, Fontes.SaidasA);
            Neuron redeB = new Neuron("B", vetoresTreinamento, Fontes.SaidasB);
            Neuron redeC = new Neuron("C", vetoresTreinamento, Fontes.SaidasC);
            Neuron redeD = new Neuron("D", vetoresTreinamento, Fontes.SaidasD);
            Neuron redeE = new Neuron("E", vetoresTreinamento, Fontes.SaidasE);
            Neuron redeJ = new Neuron("J", vetoresTreinamento, Fontes.SaidasJ);
            Neuron redeK = new Neuron("K", vetoresTreinamento, Fontes.SaidasK);

            lblErroMinimo.Text = Convert.ToString(redeA.Precisao);
            lblAprendizagem.Text = Convert.ToString(redeA.TaxaAprendizagem);

            redeA.treino();
            redeB.treino();
            redeC.treino();
            redeD.treino();
            redeE.treino();
            redeJ.treino();
            redeK.treino();

            Console.WriteLine("---------- RECONHECENDO A -----------");
            Console.Write("Primeiro Input: {");
            Console.Write("A1: " +   redeA.calcular(Fontes.A1));
            Console.Write(", B1: " + redeA.calcular(Fontes.B1));
            Console.Write(", C1: " + redeA.calcular(Fontes.C1));
            Console.Write(", D1: " + redeA.calcular(Fontes.D1));
            Console.Write(", E1: " + redeA.calcular(Fontes.E1));
            Console.Write(", J1: " + redeA.calcular(Fontes.J1));
            Console.Write(", K1: " + redeA.calcular(Fontes.K1));
            Console.WriteLine("}");

            Console.Write("Primeiro Input: {");
            Console.Write("A2: " +   redeA.calcular(Fontes.A2));
            Console.Write(", B2: " + redeA.calcular(Fontes.B2));
            Console.Write(", C2: " + redeA.calcular(Fontes.C2));
            Console.Write(", D2: " + redeA.calcular(Fontes.D2));
            Console.Write(", E2: " + redeA.calcular(Fontes.E2));
            Console.Write(", J2: " + redeA.calcular(Fontes.J2));
            Console.Write(", K2: " + redeA.calcular(Fontes.K2));
            Console.WriteLine("}");

            Console.Write("Terceiro Input: {");
            Console.Write("A3: " +   redeA.calcular(Fontes.A3));
            Console.Write(", B3: " + redeA.calcular(Fontes.B3));
            Console.Write(", C3: " + redeA.calcular(Fontes.C3));
            Console.Write(", D3: " + redeA.calcular(Fontes.D3));
            Console.Write(", E3: " + redeA.calcular(Fontes.E3));
            Console.Write(", J3: " + redeA.calcular(Fontes.J3));
            Console.Write(", K3: " + redeA.calcular(Fontes.K3));
            Console.WriteLine("}");
            Console.WriteLine("---------- FIM A -----------");

            Console.WriteLine("\n---------- RECONHECENDO B -----------");
            Console.Write("Primeiro Input: {");
            Console.Write("A1: "   + redeB.calcular(Fontes.A1));
            Console.Write(", B1: " + redeB.calcular(Fontes.B1));
            Console.Write(", C1: " + redeB.calcular(Fontes.C1));
            Console.Write(", D1: " + redeB.calcular(Fontes.D1));
            Console.Write(", E1: " + redeB.calcular(Fontes.E1));
            Console.Write(", J1: " + redeB.calcular(Fontes.J1));
            Console.Write(", K1: " + redeB.calcular(Fontes.K1));
            Console.WriteLine("}");

            Console.Write("Primeiro Input: {");
            Console.Write("A2: "   + redeB.calcular(Fontes.A2));
            Console.Write(", B2: " + redeB.calcular(Fontes.B2));
            Console.Write(", C2: " + redeB.calcular(Fontes.C2));
            Console.Write(", D2: " + redeB.calcular(Fontes.D2));
            Console.Write(", E2: " + redeB.calcular(Fontes.E2));
            Console.Write(", J2: " + redeB.calcular(Fontes.J2));
            Console.Write(", K2: " + redeB.calcular(Fontes.K2));
            Console.WriteLine("}");

            Console.Write("Terceiro Input: {");
            Console.Write("A3: "   + redeB.calcular(Fontes.A3));
            Console.Write(", B3: " + redeB.calcular(Fontes.B3));
            Console.Write(", C3: " + redeB.calcular(Fontes.C3));
            Console.Write(", D3: " + redeB.calcular(Fontes.D3));
            Console.Write(", E3: " + redeB.calcular(Fontes.E3));
            Console.Write(", J3: " + redeB.calcular(Fontes.J3));
            Console.Write(", K3: " + redeB.calcular(Fontes.K3));
            Console.WriteLine("}");

            Console.WriteLine("---------- FIM B -----------");

            Console.WriteLine("\n---------- RECONHECENDO C -----------");
            Console.Write("Primeiro Input: {");
            Console.Write("A1: "   + redeC.calcular(Fontes.A1));
            Console.Write(", B1: " + redeC.calcular(Fontes.B1));
            Console.Write(", C1: " + redeC.calcular(Fontes.C1));
            Console.Write(", D1: " + redeC.calcular(Fontes.D1));
            Console.Write(", E1: " + redeC.calcular(Fontes.E1));
            Console.Write(", J1: " + redeC.calcular(Fontes.J1));
            Console.Write(", K1: " + redeC.calcular(Fontes.K1));
            Console.WriteLine("}");

            Console.Write("Primeiro Input: {");
            Console.Write("A2: "   + redeC.calcular(Fontes.A2));
            Console.Write(", B2: " + redeC.calcular(Fontes.B2));
            Console.Write(", C2: " + redeC.calcular(Fontes.C2));
            Console.Write(", D2: " + redeC.calcular(Fontes.D2));
            Console.Write(", E2: " + redeC.calcular(Fontes.E2));
            Console.Write(", J2: " + redeC.calcular(Fontes.J2));
            Console.Write(", K2: " + redeC.calcular(Fontes.K2));
            Console.WriteLine("}");

            Console.Write("Terceiro Input: {");
            Console.Write("A3: "   + redeC.calcular(Fontes.A3));
            Console.Write(", B3: " + redeC.calcular(Fontes.B3));
            Console.Write(", C3: " + redeC.calcular(Fontes.C3));
            Console.Write(", D3: " + redeC.calcular(Fontes.D3));
            Console.Write(", E3: " + redeC.calcular(Fontes.E3));
            Console.Write(", J3: " + redeC.calcular(Fontes.J3));
            Console.Write(", K3: " + redeC.calcular(Fontes.K3));
            Console.WriteLine("}");

            Console.WriteLine("---------- FIM C -----------");

            Console.WriteLine("\n---------- RECONHECENDO D -----------");
            Console.Write("Primeiro Input: {");
            Console.Write("A1: "   + redeD.calcular(Fontes.A1));
            Console.Write(", B1: " + redeD.calcular(Fontes.B1));
            Console.Write(", C1: " + redeD.calcular(Fontes.C1));
            Console.Write(", D1: " + redeD.calcular(Fontes.D1));
            Console.Write(", E1: " + redeD.calcular(Fontes.E1));
            Console.Write(", J1: " + redeD.calcular(Fontes.J1));
            Console.Write(", K1: " + redeD.calcular(Fontes.K1));
            Console.WriteLine("}");

            Console.Write("Primeiro Input: {");
            Console.Write("A2: "   + redeD.calcular(Fontes.A2));
            Console.Write(", B2: " + redeD.calcular(Fontes.B2));
            Console.Write(", C2: " + redeD.calcular(Fontes.C2));
            Console.Write(", D2: " + redeD.calcular(Fontes.D2));
            Console.Write(", E2: " + redeD.calcular(Fontes.E2));
            Console.Write(", J2: " + redeD.calcular(Fontes.J2));
            Console.Write(", K2: " + redeD.calcular(Fontes.K2));
            Console.WriteLine("}");

            Console.Write("Terceiro Input: {");
            Console.Write("A3: "   + redeD.calcular(Fontes.A3));
            Console.Write(", B3: " + redeD.calcular(Fontes.B3));
            Console.Write(", C3: " + redeD.calcular(Fontes.C3));
            Console.Write(", D3: " + redeD.calcular(Fontes.D3));
            Console.Write(", E3: " + redeD.calcular(Fontes.E3));
            Console.Write(", J3: " + redeD.calcular(Fontes.J3));
            Console.Write(", K3: " + redeD.calcular(Fontes.K3));
            Console.WriteLine("}");

            Console.WriteLine("---------- FIM D -----------");

            Console.WriteLine("\n---------- RECONHECENDO E -----------");
            Console.Write("Primeiro Input: {");
            Console.Write("A1: "   + redeE.calcular(Fontes.A1));
            Console.Write(", B1: " + redeE.calcular(Fontes.B1));
            Console.Write(", C1: " + redeE.calcular(Fontes.C1));
            Console.Write(", D1: " + redeE.calcular(Fontes.D1));
            Console.Write(", E1: " + redeE.calcular(Fontes.E1));
            Console.Write(", J1: " + redeE.calcular(Fontes.J1));
            Console.Write(", K1: " + redeE.calcular(Fontes.K1));
            Console.WriteLine("}");

            Console.Write("Primeiro Input: {");
            Console.Write("A2: "   + redeE.calcular(Fontes.A2));
            Console.Write(", B2: " + redeE.calcular(Fontes.B2));
            Console.Write(", C2: " + redeE.calcular(Fontes.C2));
            Console.Write(", D2: " + redeE.calcular(Fontes.D2));
            Console.Write(", E2: " + redeE.calcular(Fontes.E2));
            Console.Write(", J2: " + redeE.calcular(Fontes.J2));
            Console.Write(", K2: " + redeE.calcular(Fontes.K2));
            Console.WriteLine("}");

            Console.Write("Terceiro Input: {");
            Console.Write("A3: "   + redeE.calcular(Fontes.A3));
            Console.Write(", B3: " + redeE.calcular(Fontes.B3));
            Console.Write(", C3: " + redeE.calcular(Fontes.C3));
            Console.Write(", D3: " + redeE.calcular(Fontes.D3));
            Console.Write(", E3: " + redeE.calcular(Fontes.E3));
            Console.Write(", J3: " + redeE.calcular(Fontes.J3));
            Console.Write(", K3: " + redeE.calcular(Fontes.K3));
            Console.WriteLine("}");

            Console.WriteLine("---------- FIM E -----------");

            Console.WriteLine("\n---------- RECONHECENDO J -----------");
            Console.Write("Primeiro Input: {");
            Console.Write("A1: " +   redeJ.calcular(Fontes.A1));
            Console.Write(", B1: " + redeJ.calcular(Fontes.B1));
            Console.Write(", C1: " + redeJ.calcular(Fontes.C1));
            Console.Write(", D1: " + redeJ.calcular(Fontes.D1));
            Console.Write(", E1: " + redeJ.calcular(Fontes.E1));
            Console.Write(", J1: " + redeJ.calcular(Fontes.J1));
            Console.Write(", K1: " + redeJ.calcular(Fontes.K1));
            Console.WriteLine("}");

            Console.Write("Primeiro Input: {");
            Console.Write("A2: " +   redeJ.calcular(Fontes.A2));
            Console.Write(", B2: " + redeJ.calcular(Fontes.B2));
            Console.Write(", C2: " + redeJ.calcular(Fontes.C2));
            Console.Write(", D2: " + redeJ.calcular(Fontes.D2));
            Console.Write(", E2: " + redeJ.calcular(Fontes.E2));
            Console.Write(", J2: " + redeJ.calcular(Fontes.J2));
            Console.Write(", K2: " + redeJ.calcular(Fontes.K2));
            Console.WriteLine("}");

            Console.Write("Terceiro Input: {");
            Console.Write("A3: "   + redeJ.calcular(Fontes.A3));
            Console.Write(", B3: " + redeJ.calcular(Fontes.B3));
            Console.Write(", C3: " + redeJ.calcular(Fontes.C3));
            Console.Write(", D3: " + redeJ.calcular(Fontes.D3));
            Console.Write(", E3: " + redeJ.calcular(Fontes.E3));
            Console.Write(", J3: " + redeJ.calcular(Fontes.J3));
            Console.Write(", K3: " + redeJ.calcular(Fontes.K3));
            Console.WriteLine("}");

            Console.WriteLine("---------- FIM J -----------");

            Console.WriteLine("\n---------- RECONHECENDO K -----------");
            Console.Write("Primeiro Input: {");
            Console.Write("A1: "   + redeK.calcular(Fontes.A1));
            Console.Write(", B1: " + redeK.calcular(Fontes.B1));
            Console.Write(", C1: " + redeK.calcular(Fontes.C1));
            Console.Write(", D1: " + redeK.calcular(Fontes.D1));
            Console.Write(", E1: " + redeK.calcular(Fontes.E1));
            Console.Write(", J1: " + redeK.calcular(Fontes.J1));
            Console.Write(", K1: " + redeK.calcular(Fontes.K1));
            Console.WriteLine("}");

            Console.Write("Primeiro Input: {");
            Console.Write("A2: "   + redeK.calcular(Fontes.A2));
            Console.Write(", B2: " + redeK.calcular(Fontes.B2));
            Console.Write(", C2: " + redeK.calcular(Fontes.C2));
            Console.Write(", D2: " + redeK.calcular(Fontes.D2));
            Console.Write(", E2: " + redeK.calcular(Fontes.E2));
            Console.Write(", J2: " + redeK.calcular(Fontes.J2));
            Console.Write(", K2: " + redeK.calcular(Fontes.K2));
            Console.WriteLine("}");

            Console.Write("Terceiro Input: {");
            Console.Write("A3: "   + redeK.calcular(Fontes.A3));
            Console.Write(", B3: " + redeK.calcular(Fontes.B3));
            Console.Write(", C3: " + redeK.calcular(Fontes.C3));
            Console.Write(", D3: " + redeK.calcular(Fontes.D3));
            Console.Write(", E3: " + redeK.calcular(Fontes.E3));
            Console.Write(", J3: " + redeK.calcular(Fontes.J3));
            Console.Write(", K3: " + redeK.calcular(Fontes.K3));
            Console.WriteLine("}");

            Console.WriteLine("---------- FIM K -----------");

            if (MessageBox.Show("Deseja Sair ?", "Treinamento Concluido!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

            neuronios = new List<Neuron>();
            neuronios.Add(redeA);
            neuronios.Add(redeB);
            neuronios.Add(redeC);
            neuronios.Add(redeD);
            neuronios.Add(redeE);
            neuronios.Add(redeJ);
            neuronios.Add(redeK);
        }
    }
}
