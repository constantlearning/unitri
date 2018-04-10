namespace aula05_ex03.forms
{
    partial class FrmContato
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
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdinfo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbTelefones = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTelefoneDeletar = new System.Windows.Forms.Button();
            this.btnTelefoneEditar = new System.Windows.Forms.Button();
            this.btnTelefoneAdicionar = new System.Windows.Forms.Button();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // lblIdinfo
            // 
            this.lblIdinfo.AutoSize = true;
            this.lblIdinfo.Location = new System.Drawing.Point(53, 18);
            this.lblIdinfo.Name = "lblIdinfo";
            this.lblIdinfo.Size = new System.Drawing.Size(10, 13);
            this.lblIdinfo.TabIndex = 2;
            this.lblIdinfo.Text = "-";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço: ";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(211, 55);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(50, 20);
            this.txtCep.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CEP: ";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(82, 55);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(83, 20);
            this.txtComplemento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(330, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(50, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(82, 28);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(186, 20);
            this.txtLogradouro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logradouro: ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(164, 297);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbTelefones
            // 
            this.lbTelefones.FormattingEnabled = true;
            this.lbTelefones.Location = new System.Drawing.Point(9, 18);
            this.lbTelefones.Name = "lbTelefones";
            this.lbTelefones.Size = new System.Drawing.Size(289, 95);
            this.lbTelefones.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTelefoneDeletar);
            this.groupBox2.Controls.Add(this.btnTelefoneEditar);
            this.groupBox2.Controls.Add(this.btnTelefoneAdicionar);
            this.groupBox2.Controls.Add(this.lbTelefones);
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telefones: ";
            // 
            // btnTelefoneDeletar
            // 
            this.btnTelefoneDeletar.Location = new System.Drawing.Point(304, 89);
            this.btnTelefoneDeletar.Name = "btnTelefoneDeletar";
            this.btnTelefoneDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnTelefoneDeletar.TabIndex = 10;
            this.btnTelefoneDeletar.Text = "Deletar";
            this.btnTelefoneDeletar.UseVisualStyleBackColor = true;
            this.btnTelefoneDeletar.Click += new System.EventHandler(this.btnTelefoneDeletar_Click);
            // 
            // btnTelefoneEditar
            // 
            this.btnTelefoneEditar.Location = new System.Drawing.Point(304, 54);
            this.btnTelefoneEditar.Name = "btnTelefoneEditar";
            this.btnTelefoneEditar.Size = new System.Drawing.Size(75, 23);
            this.btnTelefoneEditar.TabIndex = 9;
            this.btnTelefoneEditar.Text = "Editar";
            this.btnTelefoneEditar.UseVisualStyleBackColor = true;
            this.btnTelefoneEditar.Click += new System.EventHandler(this.btnTelefoneEditar_Click);
            // 
            // btnTelefoneAdicionar
            // 
            this.btnTelefoneAdicionar.Location = new System.Drawing.Point(304, 19);
            this.btnTelefoneAdicionar.Name = "btnTelefoneAdicionar";
            this.btnTelefoneAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnTelefoneAdicionar.TabIndex = 8;
            this.btnTelefoneAdicionar.Text = "Adicionar";
            this.btnTelefoneAdicionar.UseVisualStyleBackColor = true;
            this.btnTelefoneAdicionar.Click += new System.EventHandler(this.btnTelefoneAdicionar_Click);
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(aula05_ex03.agenda.Contato);
            // 
            // FrmContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmContato";
            this.Text = "Contato";
            this.Load += new System.EventHandler(this.FrmContato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdinfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lbTelefones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private System.Windows.Forms.Button btnTelefoneDeletar;
        private System.Windows.Forms.Button btnTelefoneEditar;
        private System.Windows.Forms.Button btnTelefoneAdicionar;
    }
}