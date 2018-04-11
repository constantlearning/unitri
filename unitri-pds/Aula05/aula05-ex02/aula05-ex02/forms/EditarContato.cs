using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05_ex02.forms
{
    public partial class EditarContato : Form
    {

        Contato contato;

        internal Contato Contato { get => contato; set => contato = value; }

        public EditarContato()
        {
            InitializeComponent();
        }

        private void EditarContato_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(Contato.Id);
            txtNome.Text = Contato.Nome;
            txtEndereco.Text = Contato.Endereco;
            txtTelefone.Text = Contato.Telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato.Nome = txtNome.Text;
            Contato.Endereco = txtEndereco.Text;
            Contato.Telefone = txtTelefone.Text;
            this.Close();
        }
    }
}
