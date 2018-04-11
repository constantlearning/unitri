using aula05_ex02.forms;
using System;
using System.Windows.Forms;

namespace aula05_ex02
{
    public partial class Form1 : Form
    {
        private Repositorio repositorio;

        public Form1()
        {
            InitializeComponent();
            this.repositorio = new Repositorio();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            contatoBindingSource.DataSource = repositorio.Contatos;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            contatoBindingSource.RemoveCurrent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato current = (Contato)contatoBindingSource.Current;

            EditarContato editarContato = new EditarContato();
            editarContato.Contato = current;
            editarContato.ShowDialog();
            repositorio.updateContato(editarContato.Contato);

            contatoBindingSource.DataSource = repositorio.Contatos;
            dtgContatos.Refresh();
        }

    }
}
