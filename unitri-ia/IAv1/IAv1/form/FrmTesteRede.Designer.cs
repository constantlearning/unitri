namespace IAv1.form
{
    partial class FrmTesteRede
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFonte1 = new System.Windows.Forms.RadioButton();
            this.rbFonte2 = new System.Windows.Forms.RadioButton();
            this.rbFonte3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtReconhecido = new System.Windows.Forms.TextBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFonte3);
            this.groupBox1.Controls.Add(this.rbFonte2);
            this.groupBox1.Controls.Add(this.rbFonte1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonte";
            // 
            // rbFonte1
            // 
            this.rbFonte1.AutoSize = true;
            this.rbFonte1.Location = new System.Drawing.Point(7, 20);
            this.rbFonte1.Name = "rbFonte1";
            this.rbFonte1.Size = new System.Drawing.Size(61, 17);
            this.rbFonte1.TabIndex = 0;
            this.rbFonte1.TabStop = true;
            this.rbFonte1.Text = "Fonte 1";
            this.rbFonte1.UseVisualStyleBackColor = true;
            // 
            // rbFonte2
            // 
            this.rbFonte2.AutoSize = true;
            this.rbFonte2.Location = new System.Drawing.Point(6, 53);
            this.rbFonte2.Name = "rbFonte2";
            this.rbFonte2.Size = new System.Drawing.Size(61, 17);
            this.rbFonte2.TabIndex = 1;
            this.rbFonte2.TabStop = true;
            this.rbFonte2.Text = "Fonte 2";
            this.rbFonte2.UseVisualStyleBackColor = true;
            // 
            // rbFonte3
            // 
            this.rbFonte3.AutoSize = true;
            this.rbFonte3.Location = new System.Drawing.Point(6, 86);
            this.rbFonte3.Name = "rbFonte3";
            this.rbFonte3.Size = new System.Drawing.Size(61, 17);
            this.rbFonte3.TabIndex = 2;
            this.rbFonte3.TabStop = true;
            this.rbFonte3.Text = "Fonte 3";
            this.rbFonte3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 323);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 317);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // txtReconhecido
            // 
            this.txtReconhecido.Location = new System.Drawing.Point(112, 378);
            this.txtReconhecido.Name = "txtReconhecido";
            this.txtReconhecido.Size = new System.Drawing.Size(348, 20);
            this.txtReconhecido.TabIndex = 3;
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(12, 376);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(75, 23);
            this.btnTestar.TabIndex = 4;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caractere Reconhecido: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "J",
            "K"});
            this.listBox1.Location = new System.Drawing.Point(12, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(82, 121);
            this.listBox1.TabIndex = 6;
            // 
            // FrmTesteRede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 411);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.txtReconhecido);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTesteRede";
            this.Text = "FrmTesteRede";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFonte3;
        private System.Windows.Forms.RadioButton rbFonte2;
        private System.Windows.Forms.RadioButton rbFonte1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtReconhecido;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}