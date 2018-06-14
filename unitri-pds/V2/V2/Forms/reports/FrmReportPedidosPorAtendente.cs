using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Source.domain;
using V2.Source.DTO.report;
using V2.Source.service;

namespace V2.Forms.reports
{
    public partial class FrmReportPedidosPorAtendente : Form
    {
        public FrmReportPedidosPorAtendente()
        {
            InitializeComponent();
        }

        private void FrmReportPedidosPorAtendente_Load(object sender, EventArgs e)
        {
            List<Atendente> atendentes = AtendenteService.BuscarTodosAtendentes();
            cbAtendente.DataSource = atendentes;
            this.reportViewer1.RefreshReport();
        }

        private void cbAtendente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atendente atendenteSelecionado = (Atendente)cbAtendente.SelectedValue;
            List<PedidoReport> pedidoReports = ReportService.BuscarPedidosDoAtendente(atendenteSelecionado);
            PedidoReportBindingSource.DataSource = pedidoReports;
            this.reportViewer1.RefreshReport();
        }
    }
}
