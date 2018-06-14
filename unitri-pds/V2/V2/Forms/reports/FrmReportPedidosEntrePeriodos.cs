using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Source.DTO.report;
using V2.Source.service;

namespace V2.Forms.reports
{
    public partial class FrmReportPedidosEntrePeriodos : Form
    {
        public FrmReportPedidosEntrePeriodos()
        {
            InitializeComponent();
        }

        private void FrmReportPedidosEntrePeriodos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = dateInicio.Value;
            DateTime dataFinal = dateFinal.Value;
            List<PedidoReport> pedidoReports = ReportService.BuscarPedidosEntreDuasDatas(dataInicial, dataFinal);
            PedidoReportBindingSource.DataSource = pedidoReports;
            reportViewer1.RefreshReport();
        }
    }
}
