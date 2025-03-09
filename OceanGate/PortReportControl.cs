using BLL;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class PortReportControl : UserControl
    {
        public PortReportControl()
        {
            InitializeComponent();
        }

        private void btn_ListPorts_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();



            List<Ports> categoryStockList = PortManager.ListAllPorts();

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OceanGate.PortReport.rdlc";
            ReportDataSource datasource = new ReportDataSource("DataSet1", categoryStockList);
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
