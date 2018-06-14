using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Forms.register;
using V2.Source.domain;
using V2.Source.DTO.report;
using V2.Source.service;

namespace V2.Forms.reports
{
    public partial class FrmReportPedidosPorFilial : Form
    {
        public FrmReportPedidosPorFilial()
        {
            InitializeComponent();
        }

        private void FrmReportPedidosPorFilial_Load(object sender, EventArgs e)
        {
            List<Filial> filiais = FilialService.buscarTodasFiliais();
            cbFilial.DataSource = filiais;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }

        private void cbFilial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filial filialSelecionada = (Filial)cbFilial.SelectedValue;
            List<PedidoReport> pedidoReports = ReportService.BuscarPedidosDaFilial(filialSelecionada);
            PedidoReportBindingSource.DataSource = pedidoReports;
            this.reportViewer1.RefreshReport();
        }
    }
}
