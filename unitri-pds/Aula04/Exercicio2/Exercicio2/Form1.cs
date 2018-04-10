using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {

        private Int32 firstNumber;
        private Int32 secondNumber;
        private Operation operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            setSecondNumber();

            Calculadora calculadora = new Calculadora(this.firstNumber, this.secondNumber);

            Int32 result = 0;
            try
            {
                result = calculadora.calcular(this.operation);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero!");
            }

            txtInput.Text = Convert.ToString(result);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            this.operation = Operation.DIVIDIR;
            setFirstNumber();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            this.operation = Operation.MULTIPLICAR;
            setFirstNumber();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            this.operation = Operation.SUBTRAIR;
            setFirstNumber();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            this.operation = Operation.SOMAR;
            setFirstNumber();
        }

        private void setFirstNumber()
        {
            this.firstNumber = -1;
            this.firstNumber = Convert.ToInt32(txtInput.Text);
            txtInput.Clear();
        }

        private void setSecondNumber()
        {
            this.secondNumber = -1;
            this.secondNumber = Convert.ToInt32(txtInput.Text);
            txtInput.Clear();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("0");
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("9");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstNumber = -1;
            secondNumber = -1;
        }
    }
}
