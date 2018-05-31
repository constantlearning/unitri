using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Source.Entity;
using V2.Source.Service;
using V2.Source.Service.util;

namespace V2.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = tbUsuario.Text;
            String senha = tbSenha.Text;

            Funcionario funcionario = AutenticacaoService.RealizarLogin(usuario, senha);

            if (funcionario != null)
            {
                MessageBox.Show("Bem vindo " + funcionario.Nome + " !");
                FrmMain frmMain = new FrmMain();
                frmMain.funcionario = funcionario;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)");
            }
        }
    }
}
