using aula05_ex03.agenda;
using aula05_ex03.forms;
using System;
using System.Windows.Forms;

namespace aula05_ex03
{
    public partial class Form1 : Form
    {
        private Agenda agenda;

        public Form1()
        {
            InitializeComponent();
            this.agenda = new Agenda();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contatoBindingSource.DataSource = agenda.Contatos;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmContato frmContato = new FrmContato();
            frmContato.ShowDialog();

            Contato novoContato = frmContato.Contato;
            agenda.Contatos.Add(novoContato);

            contatoBindingSource.DataSource = agenda.Contatos;

            dtgvContato.Refresh();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                this.contatoBindingSource.RemoveCurrent();
            }
            catch (Exception ex){ }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato current = (Contato)contatoBindingSource.Current;
            FrmContato frmContato = new FrmContato();
            frmContato.Contato = current;
            frmContato.ShowDialog();
            dtgvContato.Refresh();
        }
    }
}
