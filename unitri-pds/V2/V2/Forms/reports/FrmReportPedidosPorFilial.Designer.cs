namespace V2.Forms.reports
{
    partial class FrmReportPedidosPorFilial
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
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PedidoReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilial
            // 
            this.cbFilial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilial.FormattingEnabled = true;
            this.cbFilial.Location = new System.Drawing.Point(44, 12);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(744, 21);
            this.cbFilial.TabIndex = 11;
            this.cbFilial.SelectedIndexChanged += new System.EventHandler(this.cbFilial_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filial: ";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPedidosPorFilial";
            reportDataSource1.Value = this.PedidoReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "V2.Forms.reports.ReportPedidosPorFilial.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 399);
            this.reportViewer1.TabIndex = 12;
            // 
            // PedidoReportBindingSource
            // 
            this.PedidoReportBindingSource.DataSource = typeof(V2.Source.DTO.report.PedidoReport);
            // 
            // FrmReportPedidosPorFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbFilial);
            this.Controls.Add(this.label4);
            this.Name = "FrmReportPedidosPorFilial";
            this.Text = "FrmReportPedidosPorFilial";
            this.Load += new System.EventHandler(this.FrmReportPedidosPorFilial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilial;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PedidoReportBindingSource;
    }
}