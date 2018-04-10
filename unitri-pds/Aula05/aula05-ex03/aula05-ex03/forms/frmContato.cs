using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aula05_ex03.agenda;

namespace aula05_ex03.forms
{
    public partial class FrmContato : Form
    {
        public FrmContato()
        {
            InitializeComponent();
        }

        internal Contato Contato { get; set; }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            lblIdinfo.Text = Convert.ToString(Contato.Id);
            txtNome.Text = Contato.Nome;
            txtCep.Text = Contato.Endereco.Cep1;
            txtComplemento.Text = Contato.Endereco.Complemento;
            txtLogradouro.Text = Contato.Endereco.Logradouro;
            txtNumero.Text = Convert.ToString(Contato.Endereco.Numero);

            lbTelefones.DisplayMember = "Numero";
            lbTelefones.ValueMember = "Id";

            lbTelefones.DataSource = Contato.Telefones;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Int32 id = Convert.ToInt32(lblIdinfo.Text);
            String nome = txtNome.Text;
            String logradouro = txtLogradouro.Text;
            Int32 numero = Convert.ToInt32(txtNumero.Text);
            String complemento = txtComplemento.Text;
            String cep = txtCep.Text;

            Endereco endereco = new Endereco(logradouro, numero, complemento, cep);

            List<Telefone> telefones = lbTelefones.Items.OfType<Telefone>().ToList();

            Contato.Nome = nome;
            Contato.Telefones = telefones;
            Contato.Id = id;
            Contato.Endereco = endereco;

            this.Close();
        }

        private void btnTelefoneAdicionar_Click(object sender, EventArgs e)
        {
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.Telefone = new Telefone();
            frmTelefone.ShowDialog();
            Telefone telefone = frmTelefone.Telefone;
            Contato.Telefones.Add(telefone);

            lbTelefones.DataSource = null;
            lbTelefones.DataSource = Contato.Telefones;

        }

        private void btnTelefoneEditar_Click(object sender, EventArgs e)
        {
            Telefone telefone = (Telefone) lbTelefones.SelectedItem;
            FrmTelefone frmTelefone = new FrmTelefone();
            frmTelefone.Telefone = telefone;
            frmTelefone.ShowDialog();

            lbTelefones.DataSource = null;
            lbTelefones.DataSource = Contato.Telefones;
        }

        private void btnTelefoneDeletar_Click(object sender, EventArgs e)
        {
            Telefone telefone = (Telefone)lbTelefones.SelectedItem;

            Contato.Telefones.Remove(telefone);

            lbTelefones.DataSource = null;
            lbTelefones.DataSource = Contato.Telefones;
        }
    }
}
