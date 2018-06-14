namespace V2.Forms.reports
{
    partial class FrmReportPedidosPorAtendente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbAtendente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PedidoReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPedidosPorFilial";
            reportDataSource1.Value = this.PedidoReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "V2.Forms.reports.ReportPedidosPorAtendente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(687, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbAtendente
            // 
            this.cbAtendente.FormattingEnabled = true;
            this.cbAtendente.Location = new System.Drawing.Point(68, 12);
            this.cbAtendente.Name = "cbAtendente";
            this.cbAtendente.Size = new System.Drawing.Size(628, 21);
            this.cbAtendente.TabIndex = 27;
            this.cbAtendente.SelectedIndexChanged += new System.EventHandler(this.cbAtendente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Atendente: ";
            // 
            // PedidoReportBindingSource
            // 
            this.PedidoReportBindingSource.DataSource = typeof(V2.Source.DTO.report.PedidoReport);
            // 
            // FrmReportPedidosPorAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.cbAtendente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportPedidosPorAtendente";
            this.Text = "FrmPedidosPorAtendente";
            this.Load += new System.EventHandler(this.FrmReportPedidosPorAtendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PedidoReportBindingSource;
        private System.Windows.Forms.ComboBox cbAtendente;
        private System.Windows.Forms.Label label2;
    }
}