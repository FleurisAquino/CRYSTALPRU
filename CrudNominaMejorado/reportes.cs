using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrudNominaMejorado
{
    public partial class reportes : Form
    {
        public reportes(string nombre_reporte)
        {
           InitializeComponent();
           CrystalReport2 cryRpt = new CrystalReport2();
           cryRpt.Load(nombre_reporte);
            

           crystalReportViewer1.ReportSource = cryRpt;
           crystalReportViewer1.Refresh();
        }

        private void reportes_Load(object sender, EventArgs e)
        {
          

        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void reportDocument1_InitReport_1(object sender, EventArgs e)
        {

        }
    }
}
