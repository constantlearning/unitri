using IAv1.neural_network.file;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAv1.form
{
    public partial class FrmTesteRede : Form
    {
        public FrmTesteRede()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            List<String> input;

            ReadFile readFile = new ReadFile();

            if (rbFonte1.Checked)
            {
                input = readFile.getInput1();
                dataGridView1.DataSource = input[1];
                
            }

            if (rbFonte2.Checked)
            {

            }

            if (rbFonte3.Checked)
            {

            }
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {

        }
    }
}
