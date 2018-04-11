using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05_ex01
{
    public partial class Form1 : Form
    {
        private Repositorio repositorio;

        public Form1()
        {
            InitializeComponent();
            repositorio = new Repositorio();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            contatoBindingSource.DataSource = repositorio.Contatos;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato current = (Contato)contatoBindingSource.Current;
            txtId.Text = Convert.ToString(current.Id);
            txtNome.Text = current.Nome;
            txtEndereco.Text = current.Endereco;
            txtTelefone.Text = current.Telefone;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            contatoBindingSource.RemoveCurrent();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtId.Text);
            String nome = txtNome.Text;
            String endereco = txtEndereco.Text;
            String telefone = txtTelefone.Text;
            Contato contato = new Contato(id, nome, endereco, telefone);

            repositorio.updateContato(contato);
            contatoBindingSource.DataSource = repositorio.Contatos;
            dataGridView1.Refresh();
        }

    }
}
