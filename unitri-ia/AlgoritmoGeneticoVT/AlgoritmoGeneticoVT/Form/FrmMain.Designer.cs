namespace AlgoritmoGeneticoVT
{
    partial class FrmMain
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
            this.txtQuantidadePopulacao = new System.Windows.Forms.TextBox();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.lbPopulacaoMaiorAptidao = new System.Windows.Forms.ListBox();
            this.txtGeracoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaxaDeMutacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaximoDeGeracoes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "População:";
            // 
            // txtQuantidadePopulacao
            // 
            this.txtQuantidadePopulacao.Location = new System.Drawing.Point(171, 28);
            this.txtQuantidadePopulacao.Name = "txtQuantidadePopulacao";
            this.txtQuantidadePopulacao.ReadOnly = true;
            this.txtQuantidadePopulacao.Size = new System.Drawing.Size(95, 20);
            this.txtQuantidadePopulacao.TabIndex = 1;
            this.txtQuantidadePopulacao.Text = "50";
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(95, 142);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(75, 23);
            this.btnInicializar.TabIndex = 2;
            this.btnInicializar.Text = "Iniciar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // lbPopulacaoMaiorAptidao
            // 
            this.lbPopulacaoMaiorAptidao.FormattingEnabled = true;
            this.lbPopulacaoMaiorAptidao.Location = new System.Drawing.Point(12, 216);
            this.lbPopulacaoMaiorAptidao.Name = "lbPopulacaoMaiorAptidao";
            this.lbPopulacaoMaiorAptidao.Size = new System.Drawing.Size(285, 290);
            this.lbPopulacaoMaiorAptidao.TabIndex = 3;
            // 
            // txtGeracoes
            // 
            this.txtGeracoes.Location = new System.Drawing.Point(171, 106);
            this.txtGeracoes.Name = "txtGeracoes";
            this.txtGeracoes.ReadOnly = true;
            this.txtGeracoes.Size = new System.Drawing.Size(95, 20);
            this.txtGeracoes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gerações para resultado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Taxa de Mutação";
            // 
            // txtTaxaDeMutacao
            // 
            this.txtTaxaDeMutacao.Location = new System.Drawing.Point(171, 54);
            this.txtTaxaDeMutacao.Name = "txtTaxaDeMutacao";
            this.txtTaxaDeMutacao.ReadOnly = true;
            this.txtTaxaDeMutacao.Size = new System.Drawing.Size(95, 20);
            this.txtTaxaDeMutacao.TabIndex = 7;
            this.txtTaxaDeMutacao.Text = "0,002";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "População com maior aptidão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Máximo de Gerações";
            // 
            // txtMaximoDeGeracoes
            // 
            this.txtMaximoDeGeracoes.Location = new System.Drawing.Point(171, 80);
            this.txtMaximoDeGeracoes.Name = "txtMaximoDeGeracoes";
            this.txtMaximoDeGeracoes.Size = new System.Drawing.Size(95, 20);
            this.txtMaximoDeGeracoes.TabIndex = 10;
            this.txtMaximoDeGeracoes.Text = "20000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQuantidadePopulacao);
            this.groupBox1.Controls.Add(this.btnInicializar);
            this.groupBox1.Controls.Add(this.txtMaximoDeGeracoes);
            this.groupBox1.Controls.Add(this.txtGeracoes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTaxaDeMutacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evolução";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPopulacaoMaiorAptidao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo Genético";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.ListBox lbPopulacaoMaiorAptidao;
        private System.Windows.Forms.TextBox txtGeracoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadePopulacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaxaDeMutacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaximoDeGeracoes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
