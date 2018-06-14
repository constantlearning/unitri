using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V2.Source.service;

namespace V2.Forms.graphics
{
    public partial class FrmGraficoFaturamentoDasFiliais : Form
    {
        public FrmGraficoFaturamentoDasFiliais()
        {
            InitializeComponent();
        }

        private void FrmGraficoFaturamentoDasFiliais_Load(object sender, EventArgs e)
        {
            FaturamentoFilialBindingSource.DataSource= ReportService.BuscarFaturamentoDasFiliais();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }
    }
}
