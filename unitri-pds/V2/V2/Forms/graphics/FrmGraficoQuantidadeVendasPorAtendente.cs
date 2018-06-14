using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Source.DTO;
using V2.Source.service;

namespace V2.Forms.graphics
{
    public partial class FrmGraficoQuantidadeVendasPorAtendente : Form
    {
        public FrmGraficoQuantidadeVendasPorAtendente()
        {
            InitializeComponent();
        }

        private void FrmGraficoQuantidadeVendasPorAtendente_Load(object sender, EventArgs e)
        {
            PedidoAtendenteBindingSource.DataSource = ReportService.buscarQuantidadeDePedidoPorAtendente();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }
    }
}
