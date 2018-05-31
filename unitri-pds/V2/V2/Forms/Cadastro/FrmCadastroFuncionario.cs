using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2.Forms.Cadastro
{
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar?", "Aviso!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Aviso!", "Deseja cancelar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                String nome = txtNome.Text;
                String sexo = cbSexo.Text;
                DateTime nascimento = dateNascimento.Value;
                String telefone = mtxtTelefone.Text;
                String usuario = tbUsuario.Text;
                String senha = tbSenha.Text;

                try
                {
                    CadastroService.SalvarFuncionario(nome, sexo, nascimento, telefone, usuario, senha);
                    MessageBox.Show("Salvo com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
