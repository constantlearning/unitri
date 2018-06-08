namespace V2.Forms.register
{
    partial class FrmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Location = new System.Drawing.Point(198, 142);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(85, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNascimento.Location = new System.Drawing.Point(79, 68);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(267, 20);
            this.dtNascimento.TabIndex = 13;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbCPF.Location = new System.Drawing.Point(79, 42);
            this.mtbCPF.Mask = "000000000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(267, 20);
            this.mtbCPF.TabIndex = 12;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Location = new System.Drawing.Point(79, 12);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(267, 20);
            this.tbNome.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nascimento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome: ";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 177);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroCliente";
            this.Text = "FrmCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}