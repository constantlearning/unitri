namespace V2.Forms.register
{
    partial class FrmCadastroPedido
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
            this.cbBarbearias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFiliais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAtendente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dgvCarrinhoProdutos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCarrinhoServicos = new System.Windows.Forms.DataGridView();
            this.carrinhoServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnRemoverServico = new System.Windows.Forms.Button();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrinhoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBarbearias
            // 
            this.cbBarbearias.FormattingEnabled = true;
            this.cbBarbearias.Location = new System.Drawing.Point(65, 12);
            this.cbBarbearias.Name = "cbBarbearias";
            this.cbBarbearias.Size = new System.Drawing.Size(222, 21);
            this.cbBarbearias.TabIndex = 21;
            this.cbBarbearias.SelectedIndexChanged += new System.EventHandler(this.cbBarbearias_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Barbearia: ";
            // 
            // cbFiliais
            // 
            this.cbFiliais.FormattingEnabled = true;
            this.cbFiliais.Location = new System.Drawing.Point(65, 39);
            this.cbFiliais.Name = "cbFiliais";
            this.cbFiliais.Size = new System.Drawing.Size(222, 21);
            this.cbFiliais.TabIndex = 23;
            this.cbFiliais.SelectedIndexChanged += new System.EventHandler(this.cbFiliais_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filial: ";
            // 
            // cbAtendente
            // 
            this.cbAtendente.FormattingEnabled = true;
            this.cbAtendente.Location = new System.Drawing.Point(65, 66);
            this.cbAtendente.Name = "cbAtendente";
            this.cbAtendente.Size = new System.Drawing.Size(222, 21);
            this.cbAtendente.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Atendente: ";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(65, 93);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(222, 21);
            this.cbClientes.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cliente: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Produtos: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Serviços: ";
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.AutoGenerateColumns = false;
            this.dgvServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.valorDataGridViewTextBoxColumn1});
            this.dgvServicos.DataSource = this.servicoBindingSource;
            this.dgvServicos.Location = new System.Drawing.Point(16, 399);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.Size = new System.Drawing.Size(298, 197);
            this.dgvServicos.TabIndex = 31;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtoBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(16, 171);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(298, 197);
            this.dgvProdutos.TabIndex = 29;
            // 
            // dgvCarrinhoProdutos
            // 
            this.dgvCarrinhoProdutos.AllowUserToAddRows = false;
            this.dgvCarrinhoProdutos.AllowUserToDeleteRows = false;
            this.dgvCarrinhoProdutos.AutoGenerateColumns = false;
            this.dgvCarrinhoProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrinhoProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinhoProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn2});
            this.dgvCarrinhoProdutos.DataSource = this.carrinhoProdutoBindingSource;
            this.dgvCarrinhoProdutos.Location = new System.Drawing.Point(401, 171);
            this.dgvCarrinhoProdutos.Name = "dgvCarrinhoProdutos";
            this.dgvCarrinhoProdutos.ReadOnly = true;
            this.dgvCarrinhoProdutos.Size = new System.Drawing.Size(298, 197);
            this.dgvCarrinhoProdutos.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Carrinho: ";
            // 
            // dgvCarrinhoServicos
            // 
            this.dgvCarrinhoServicos.AllowUserToAddRows = false;
            this.dgvCarrinhoServicos.AllowUserToDeleteRows = false;
            this.dgvCarrinhoServicos.AutoGenerateColumns = false;
            this.dgvCarrinhoServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrinhoServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinhoServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.quantidadeDataGridViewTextBoxColumn1,
            this.valorDataGridViewTextBoxColumn3});
            this.dgvCarrinhoServicos.DataSource = this.carrinhoServicoBindingSource;
            this.dgvCarrinhoServicos.Location = new System.Drawing.Point(401, 399);
            this.dgvCarrinhoServicos.Name = "dgvCarrinhoServicos";
            this.dgvCarrinhoServicos.ReadOnly = true;
            this.dgvCarrinhoServicos.Size = new System.Drawing.Size(298, 197);
            this.dgvCarrinhoServicos.TabIndex = 35;
            // 
            // carrinhoServicoBindingSource
            // 
            this.carrinhoServicoBindingSource.DataSource = typeof(V2.Source.domain.ItemServico);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(320, 247);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarProduto.TabIndex = 36;
            this.btnAdicionarProduto.Text = ">>>";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(320, 276);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverProduto.TabIndex = 37;
            this.btnRemoverProduto.Text = "<<<";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnRemoverServico
            // 
            this.btnRemoverServico.Location = new System.Drawing.Point(320, 501);
            this.btnRemoverServico.Name = "btnRemoverServico";
            this.btnRemoverServico.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverServico.TabIndex = 39;
            this.btnRemoverServico.Text = "<<<";
            this.btnRemoverServico.UseVisualStyleBackColor = true;
            this.btnRemoverServico.Click += new System.EventHandler(this.btnRemoverServico_Click);
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.Location = new System.Drawing.Point(320, 472);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarServico.TabIndex = 38;
            this.btnAdicionarServico.Text = ">>>";
            this.btnAdicionarServico.UseVisualStyleBackColor = true;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Total: R$: ";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(401, 637);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 41;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 637);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(495, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 18);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "-";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn2
            // 
            this.valorDataGridViewTextBoxColumn2.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn2.Name = "valorDataGridViewTextBoxColumn2";
            this.valorDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // carrinhoProdutoBindingSource
            // 
            this.carrinhoProdutoBindingSource.DataSource = typeof(V2.Source.domain.ItemProduto);
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn1
            // 
            this.valorDataGridViewTextBoxColumn1.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn1.Name = "valorDataGridViewTextBoxColumn1";
            this.valorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(V2.Source.domain.Servico);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(V2.Source.domain.Produto);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn1
            // 
            this.quantidadeDataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn1.Name = "quantidadeDataGridViewTextBoxColumn1";
            this.quantidadeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn3
            // 
            this.valorDataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn3.Name = "valorDataGridViewTextBoxColumn3";
            this.valorDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FrmCadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 686);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRemoverServico);
            this.Controls.Add(this.btnAdicionarServico);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.dgvCarrinhoServicos);
            this.Controls.Add(this.dgvCarrinhoProdutos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvServicos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAtendente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiliais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBarbearias);
            this.Controls.Add(this.label4);
            this.Name = "FrmCadastroPedido";
            this.Text = "FrmCadastroPedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastroPedido_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadastroPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrinhoProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBarbearias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiliais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAtendente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridView dgvCarrinhoProdutos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCarrinhoServicos;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnRemoverServico;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.BindingSource carrinhoProdutoBindingSource;
        private System.Windows.Forms.BindingSource carrinhoServicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn3;
    }
}