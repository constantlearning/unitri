using aula05_ex03.agenda;
using aula05_ex03.agenda.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05_ex03.forms
{
    public partial class FrmTelefone : Form
    {

        public FrmTelefone()
        {
            InitializeComponent();
            cbTipoTelefone.Items.Add(TELEFONETIPO.COMERCIAL);
            cbTipoTelefone.Items.Add(TELEFONETIPO.RESIDENCIAL);
        }

        internal Telefone Telefone { get; set; }

        private void Telefone_Load(object sender, EventArgs e)
        {
            txtTelefone.Text = Telefone.Numero;
            cbTipoTelefone.Text = Telefone.TipoTelefone.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Telefone.Numero = txtTelefone.Text;
            Telefone.Id = random.Next();
            this.Close();
        }
    }
}
