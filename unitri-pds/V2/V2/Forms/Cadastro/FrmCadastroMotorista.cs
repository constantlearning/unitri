﻿using System;
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
    public partial class FrmCadastroMotorista : Form
    {
        public FrmCadastroMotorista()
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
                //String nome = txtNomeConveniada.Text;
                //String telefone = mtxtTelefone.Text;

                //try
                //{
                //    CadastroService.SalvarConveniada(nome, telefone);

                //    MessageBox.Show("Salvo com sucesso!");
                //    this.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }

        }
    }
}
