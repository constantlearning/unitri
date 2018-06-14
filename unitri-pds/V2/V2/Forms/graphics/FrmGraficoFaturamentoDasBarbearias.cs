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
    public partial class FrmGraficoFaturamentoDasBarbearias : Form
    {
        public FrmGraficoFaturamentoDasBarbearias()
        {
            InitializeComponent();
        }

        private void FrmGraficoFaturamentoDasBarbearias_Load(object sender, EventArgs e)
        {
            FaturamentoBarbeariaBindingSource.DataSource = ReportService.BuscarFaturamentoDasBarbearias();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }
    }
}
