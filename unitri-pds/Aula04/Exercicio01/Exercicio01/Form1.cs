using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Int32 firstValue = Convert.ToInt32(txtFirstValue.Text);
            Int32 secondValue = Convert.ToInt32(txtSecondValue.Text);
            txtResultado.Text = Convert.ToString(firstValue + secondValue);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Int32 firstValue = Convert.ToInt32(txtFirstValue.Text);
            Int32 secondValue = Convert.ToInt32(txtSecondValue.Text);
            txtResultado.Text = Convert.ToString(firstValue - secondValue);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Int32 firstValue = Convert.ToInt32(txtFirstValue.Text);
            Int32 secondValue = Convert.ToInt32(txtSecondValue.Text);
            txtResultado.Text = Convert.ToString(firstValue * secondValue);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Int32 firstValue = Convert.ToInt32(txtFirstValue.Text);
            Int32 secondValue = Convert.ToInt32(txtSecondValue.Text);
            Int32 result;
            try
            {
                result = firstValue / secondValue;
                txtResultado.Text = Convert.ToString(result);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero!");
            }
        }
    }
}
