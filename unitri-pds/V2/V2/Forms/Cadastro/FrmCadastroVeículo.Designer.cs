namespace V2.Forms.Cadastro
{
    partial class FrmCadastroVeículo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataModelo = new System.Windows.Forms.DateTimePicker();
            this.dataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.txtMarcaVeiculo = new System.Windows.Forms.TextBox();
            this.mtxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fabricação: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataModelo);
            this.groupBox1.Controls.Add(this.dataFabricacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ano:";
            // 
            // dataModelo
            // 
            this.dataModelo.Location = new System.Drawing.Point(78, 27);
            this.dataModelo.Name = "dataModelo";
            this.dataModelo.Size = new System.Drawing.Size(200, 20);
            this.dataModelo.TabIndex = 2;
            this.dataModelo.Value = new System.DateTime(2018, 5, 31, 0, 0, 0, 0);
            // 
            // dataFabricacao
            // 
            this.dataFabricacao.Location = new System.Drawing.Point(78, 57);
            this.dataFabricacao.Name = "dataFabricacao";
            this.dataFabricacao.Size = new System.Drawing.Size(200, 20);
            this.dataFabricacao.TabIndex = 3;
            this.dataFabricacao.Value = new System.DateTime(2018, 5, 31, 0, 0, 0, 0);
            // 
            // txtMarcaVeiculo
            // 
            this.txtMarcaVeiculo.Location = new System.Drawing.Point(59, 35);
            this.txtMarcaVeiculo.Name = "txtMarcaVeiculo";
            this.txtMarcaVeiculo.Size = new System.Drawing.Size(248, 20);
            this.txtMarcaVeiculo.TabIndex = 1;
            // 
            // mtxtPlaca
            // 
            this.mtxtPlaca.Location = new System.Drawing.Point(59, 10);
            this.mtxtPlaca.Mask = "???-0000";
            this.mtxtPlaca.Name = "mtxtPlaca";
            this.mtxtPlaca.Size = new System.Drawing.Size(100, 20);
            this.mtxtPlaca.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(178, 186);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(86, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCadastroVeículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 221);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mtxtPlaca);
            this.Controls.Add(this.txtMarcaVeiculo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadastroVeículo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Veículo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dataModelo;
        private System.Windows.Forms.DateTimePicker dataFabricacao;
        private System.Windows.Forms.TextBox txtMarcaVeiculo;
        private System.Windows.Forms.MaskedTextBox mtxtPlaca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}