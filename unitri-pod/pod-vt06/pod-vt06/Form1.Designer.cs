namespace pod_vt06
{
    partial class Form1
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
            this.gbAlgoritmo = new System.Windows.Forms.GroupBox();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.rbMergeSort = new System.Windows.Forms.RadioButton();
            this.rbInsertionSort = new System.Windows.Forms.RadioButton();
            this.rbSelectionSort = new System.Windows.Forms.RadioButton();
            this.rbBubbleSort = new System.Windows.Forms.RadioButton();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbNota = new System.Windows.Forms.RadioButton();
            this.rbInscricao = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.labelquantidade = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtInvervaloFinal = new System.Windows.Forms.TextBox();
            this.txtInvervaloInicio = new System.Windows.Forms.TextBox();
            this.txtNotaAbaixo = new System.Windows.Forms.TextBox();
            this.txtNotaAcima = new System.Windows.Forms.TextBox();
            this.rbIntervaloInscricao = new System.Windows.Forms.RadioButton();
            this.rbNotaAbaixo = new System.Windows.Forms.RadioButton();
            this.rbNotaAcima = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSequencial = new System.Windows.Forms.RadioButton();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.rbHashing = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTipoInscricao = new System.Windows.Forms.RadioButton();
            this.rbTipoNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIndiceEncontrado = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdComparacoes = new System.Windows.Forms.Label();
            this.gbAlgoritmo.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlgoritmo
            // 
            this.gbAlgoritmo.Controls.Add(this.rbQuickSort);
            this.gbAlgoritmo.Controls.Add(this.rbMergeSort);
            this.gbAlgoritmo.Controls.Add(this.rbInsertionSort);
            this.gbAlgoritmo.Controls.Add(this.rbSelectionSort);
            this.gbAlgoritmo.Controls.Add(this.rbBubbleSort);
            this.gbAlgoritmo.Location = new System.Drawing.Point(7, 13);
            this.gbAlgoritmo.Name = "gbAlgoritmo";
            this.gbAlgoritmo.Size = new System.Drawing.Size(115, 140);
            this.gbAlgoritmo.TabIndex = 0;
            this.gbAlgoritmo.TabStop = false;
            this.gbAlgoritmo.Text = "Algoritmo";
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(7, 112);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(75, 17);
            this.rbQuickSort.TabIndex = 4;
            this.rbQuickSort.Text = "Quick Sort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // rbMergeSort
            // 
            this.rbMergeSort.AutoSize = true;
            this.rbMergeSort.Location = new System.Drawing.Point(7, 89);
            this.rbMergeSort.Name = "rbMergeSort";
            this.rbMergeSort.Size = new System.Drawing.Size(77, 17);
            this.rbMergeSort.TabIndex = 3;
            this.rbMergeSort.Text = "Merge Sort";
            this.rbMergeSort.UseVisualStyleBackColor = true;
            // 
            // rbInsertionSort
            // 
            this.rbInsertionSort.AutoSize = true;
            this.rbInsertionSort.Location = new System.Drawing.Point(7, 66);
            this.rbInsertionSort.Name = "rbInsertionSort";
            this.rbInsertionSort.Size = new System.Drawing.Size(87, 17);
            this.rbInsertionSort.TabIndex = 2;
            this.rbInsertionSort.Text = "Insertion Sort";
            this.rbInsertionSort.UseVisualStyleBackColor = true;
            // 
            // rbSelectionSort
            // 
            this.rbSelectionSort.AutoSize = true;
            this.rbSelectionSort.Location = new System.Drawing.Point(7, 43);
            this.rbSelectionSort.Name = "rbSelectionSort";
            this.rbSelectionSort.Size = new System.Drawing.Size(91, 17);
            this.rbSelectionSort.TabIndex = 1;
            this.rbSelectionSort.Text = "Selection Sort";
            this.rbSelectionSort.UseVisualStyleBackColor = true;
            // 
            // rbBubbleSort
            // 
            this.rbBubbleSort.AutoSize = true;
            this.rbBubbleSort.Checked = true;
            this.rbBubbleSort.Location = new System.Drawing.Point(7, 20);
            this.rbBubbleSort.Name = "rbBubbleSort";
            this.rbBubbleSort.Size = new System.Drawing.Size(80, 17);
            this.rbBubbleSort.TabIndex = 0;
            this.rbBubbleSort.TabStop = true;
            this.rbBubbleSort.Text = "Bubble Sort";
            this.rbBubbleSort.UseVisualStyleBackColor = true;
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbNota);
            this.gbOrdenar.Controls.Add(this.rbInscricao);
            this.gbOrdenar.Controls.Add(this.rbNome);
            this.gbOrdenar.Location = new System.Drawing.Point(128, 10);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(88, 96);
            this.gbOrdenar.TabIndex = 1;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar";
            // 
            // rbNota
            // 
            this.rbNota.AutoSize = true;
            this.rbNota.Location = new System.Drawing.Point(6, 66);
            this.rbNota.Name = "rbNota";
            this.rbNota.Size = new System.Drawing.Size(48, 17);
            this.rbNota.TabIndex = 3;
            this.rbNota.Text = "Nota";
            this.rbNota.UseVisualStyleBackColor = true;
            // 
            // rbInscricao
            // 
            this.rbInscricao.AutoSize = true;
            this.rbInscricao.Location = new System.Drawing.Point(6, 43);
            this.rbInscricao.Name = "rbInscricao";
            this.rbInscricao.Size = new System.Drawing.Size(68, 17);
            this.rbInscricao.TabIndex = 2;
            this.rbInscricao.Text = "Inscrição";
            this.rbInscricao.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(6, 20);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 1;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.lblTempo);
            this.gbFiltro.Controls.Add(this.labelquantidade);
            this.gbFiltro.Controls.Add(this.lblQuantidade);
            this.gbFiltro.Controls.Add(this.lblTotal);
            this.gbFiltro.Controls.Add(this.btnCarregar);
            this.gbFiltro.Controls.Add(this.txtInvervaloFinal);
            this.gbFiltro.Controls.Add(this.txtInvervaloInicio);
            this.gbFiltro.Controls.Add(this.txtNotaAbaixo);
            this.gbFiltro.Controls.Add(this.txtNotaAcima);
            this.gbFiltro.Controls.Add(this.rbIntervaloInscricao);
            this.gbFiltro.Controls.Add(this.rbNotaAbaixo);
            this.gbFiltro.Controls.Add(this.rbNotaAcima);
            this.gbFiltro.Location = new System.Drawing.Point(222, 10);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(313, 149);
            this.gbFiltro.TabIndex = 2;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(183, 129);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(16, 13);
            this.lblTempo.TabIndex = 12;
            this.lblTempo.Text = " - ";
            // 
            // labelquantidade
            // 
            this.labelquantidade.AutoSize = true;
            this.labelquantidade.Location = new System.Drawing.Point(115, 129);
            this.labelquantidade.Name = "labelquantidade";
            this.labelquantidade.Size = new System.Drawing.Size(46, 13);
            this.labelquantidade.TabIndex = 11;
            this.labelquantidade.Text = "Tempo: ";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(115, 106);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(68, 13);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(183, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = " - ";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(6, 116);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // txtInvervaloFinal
            // 
            this.txtInvervaloFinal.Location = new System.Drawing.Point(224, 70);
            this.txtInvervaloFinal.Name = "txtInvervaloFinal";
            this.txtInvervaloFinal.Size = new System.Drawing.Size(84, 20);
            this.txtInvervaloFinal.TabIndex = 8;
            this.txtInvervaloFinal.Text = "999999999999";
            // 
            // txtInvervaloInicio
            // 
            this.txtInvervaloInicio.Location = new System.Drawing.Point(118, 70);
            this.txtInvervaloInicio.Name = "txtInvervaloInicio";
            this.txtInvervaloInicio.Size = new System.Drawing.Size(93, 20);
            this.txtInvervaloInicio.TabIndex = 7;
            this.txtInvervaloInicio.Text = "0";
            // 
            // txtNotaAbaixo
            // 
            this.txtNotaAbaixo.Location = new System.Drawing.Point(118, 44);
            this.txtNotaAbaixo.Name = "txtNotaAbaixo";
            this.txtNotaAbaixo.Size = new System.Drawing.Size(189, 20);
            this.txtNotaAbaixo.TabIndex = 6;
            this.txtNotaAbaixo.Text = "500";
            // 
            // txtNotaAcima
            // 
            this.txtNotaAcima.Location = new System.Drawing.Point(118, 18);
            this.txtNotaAcima.Name = "txtNotaAcima";
            this.txtNotaAcima.Size = new System.Drawing.Size(189, 20);
            this.txtNotaAcima.TabIndex = 5;
            this.txtNotaAcima.Text = "0";
            // 
            // rbIntervaloInscricao
            // 
            this.rbIntervaloInscricao.AutoSize = true;
            this.rbIntervaloInscricao.Location = new System.Drawing.Point(6, 70);
            this.rbIntervaloInscricao.Name = "rbIntervaloInscricao";
            this.rbIntervaloInscricao.Size = new System.Drawing.Size(118, 17);
            this.rbIntervaloInscricao.TabIndex = 4;
            this.rbIntervaloInscricao.Text = "Intervalo Inscrição: ";
            this.rbIntervaloInscricao.UseVisualStyleBackColor = true;
            // 
            // rbNotaAbaixo
            // 
            this.rbNotaAbaixo.AutoSize = true;
            this.rbNotaAbaixo.Location = new System.Drawing.Point(6, 44);
            this.rbNotaAbaixo.Name = "rbNotaAbaixo";
            this.rbNotaAbaixo.Size = new System.Drawing.Size(100, 17);
            this.rbNotaAbaixo.TabIndex = 3;
            this.rbNotaAbaixo.Text = "Nota abaixo de:";
            this.rbNotaAbaixo.UseVisualStyleBackColor = true;
            // 
            // rbNotaAcima
            // 
            this.rbNotaAcima.AutoSize = true;
            this.rbNotaAcima.Checked = true;
            this.rbNotaAcima.Location = new System.Drawing.Point(6, 19);
            this.rbNotaAcima.Name = "rbNotaAcima";
            this.rbNotaAcima.Size = new System.Drawing.Size(100, 17);
            this.rbNotaAcima.TabIndex = 2;
            this.rbNotaAcima.TabStop = true;
            this.rbNotaAcima.Text = "Nota acima de :";
            this.rbNotaAcima.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(134, 127);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOrdenar);
            this.groupBox4.Controls.Add(this.gbFiltro);
            this.groupBox4.Controls.Add(this.gbOrdenar);
            this.groupBox4.Controls.Add(this.gbAlgoritmo);
            this.groupBox4.Location = new System.Drawing.Point(3, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 159);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.candidatoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 246);
            this.dataGridView1.TabIndex = 6;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // candidatoBindingSource
            // 
            this.candidatoBindingSource.DataSource = typeof(pod_v1.sort.entity.Candidato);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 446);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.gpbPesquisa);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSequencial);
            this.groupBox2.Controls.Add(this.rbBinaria);
            this.groupBox2.Controls.Add(this.rbHashing);
            this.groupBox2.Location = new System.Drawing.Point(6, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algoritmo";
            // 
            // rbSequencial
            // 
            this.rbSequencial.AutoSize = true;
            this.rbSequencial.Checked = true;
            this.rbSequencial.Location = new System.Drawing.Point(6, 19);
            this.rbSequencial.Name = "rbSequencial";
            this.rbSequencial.Size = new System.Drawing.Size(124, 17);
            this.rbSequencial.TabIndex = 2;
            this.rbSequencial.TabStop = true;
            this.rbSequencial.Text = "Pesquisa Sequencial";
            this.rbSequencial.UseVisualStyleBackColor = true;
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.Location = new System.Drawing.Point(6, 46);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(103, 17);
            this.rbBinaria.TabIndex = 3;
            this.rbBinaria.Text = "Pesquisa Binária";
            this.rbBinaria.UseVisualStyleBackColor = true;
            // 
            // rbHashing
            // 
            this.rbHashing.AutoSize = true;
            this.rbHashing.Location = new System.Drawing.Point(6, 73);
            this.rbHashing.Name = "rbHashing";
            this.rbHashing.Size = new System.Drawing.Size(110, 17);
            this.rbHashing.TabIndex = 4;
            this.rbHashing.Text = "Pesquisa Hashing";
            this.rbHashing.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblQtdComparacoes);
            this.gpbPesquisa.Controls.Add(this.label2);
            this.gpbPesquisa.Controls.Add(this.groupBox1);
            this.gpbPesquisa.Controls.Add(this.label1);
            this.gpbPesquisa.Controls.Add(this.btnPesquisar);
            this.gpbPesquisa.Controls.Add(this.label3);
            this.gpbPesquisa.Controls.Add(this.lblIndiceEncontrado);
            this.gpbPesquisa.Controls.Add(this.txtChave);
            this.gpbPesquisa.Location = new System.Drawing.Point(6, 255);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(532, 159);
            this.gpbPesquisa.TabIndex = 8;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTipoInscricao);
            this.groupBox1.Controls.Add(this.rbTipoNome);
            this.groupBox1.Location = new System.Drawing.Point(206, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 97);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbTipoInscricao
            // 
            this.rbTipoInscricao.AutoSize = true;
            this.rbTipoInscricao.Location = new System.Drawing.Point(6, 61);
            this.rbTipoInscricao.Name = "rbTipoInscricao";
            this.rbTipoInscricao.Size = new System.Drawing.Size(68, 17);
            this.rbTipoInscricao.TabIndex = 2;
            this.rbTipoInscricao.Text = "Inscrição";
            this.rbTipoInscricao.UseVisualStyleBackColor = true;
            // 
            // rbTipoNome
            // 
            this.rbTipoNome.AutoSize = true;
            this.rbTipoNome.Checked = true;
            this.rbTipoNome.Location = new System.Drawing.Point(6, 20);
            this.rbTipoNome.Name = "rbTipoNome";
            this.rbTipoNome.Size = new System.Drawing.Size(53, 17);
            this.rbTipoNome.TabIndex = 1;
            this.rbTipoNome.TabStop = true;
            this.rbTipoNome.Text = "Nome";
            this.rbTipoNome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chave: ";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(263, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade: ";
            // 
            // lblIndiceEncontrado
            // 
            this.lblIndiceEncontrado.AutoSize = true;
            this.lblIndiceEncontrado.Location = new System.Drawing.Point(431, 103);
            this.lblIndiceEncontrado.Name = "lblIndiceEncontrado";
            this.lblIndiceEncontrado.Size = new System.Drawing.Size(16, 13);
            this.lblIndiceEncontrado.TabIndex = 9;
            this.lblIndiceEncontrado.Text = " - ";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(56, 21);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(193, 20);
            this.txtChave.TabIndex = 5;
            this.txtChave.Text = "0";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.DataSource = this.candidatoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(535, 246);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nota";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Índice valor encontrado: ";
            // 
            // lblQtdComparacoes
            // 
            this.lblQtdComparacoes.AutoSize = true;
            this.lblQtdComparacoes.Location = new System.Drawing.Point(431, 131);
            this.lblQtdComparacoes.Name = "lblQtdComparacoes";
            this.lblQtdComparacoes.Size = new System.Drawing.Size(16, 13);
            this.lblQtdComparacoes.TabIndex = 14;
            this.lblQtdComparacoes.Text = " - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 443);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAlgoritmo.ResumeLayout(false);
            this.gbAlgoritmo.PerformLayout();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox gbAlgoritmo;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbMergeSort;
        private System.Windows.Forms.RadioButton rbInsertionSort;
        private System.Windows.Forms.RadioButton rbSelectionSort;
        private System.Windows.Forms.RadioButton rbBubbleSort;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbNota;
        private System.Windows.Forms.RadioButton rbInscricao;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.TextBox txtInvervaloFinal;
        private System.Windows.Forms.TextBox txtInvervaloInicio;
        private System.Windows.Forms.TextBox txtNotaAbaixo;
        private System.Windows.Forms.TextBox txtNotaAcima;
        private System.Windows.Forms.RadioButton rbIntervaloInscricao;
        private System.Windows.Forms.RadioButton rbNotaAbaixo;
        private System.Windows.Forms.RadioButton rbNotaAcima;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource candidatoBindingSource;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label labelquantidade;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSequencial;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIndiceEncontrado;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.RadioButton rbHashing;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTipoInscricao;
        private System.Windows.Forms.RadioButton rbTipoNome;
        private System.Windows.Forms.Label lblQtdComparacoes;
        private System.Windows.Forms.Label label2;
    }
}

