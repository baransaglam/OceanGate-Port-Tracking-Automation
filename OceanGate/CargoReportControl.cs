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
    public partial class CargoReportControl : UserControl
    {
        public CargoReportControl()
        {
            InitializeComponent();
        }

        private void btn_ListCargos_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();



            List<CargoDetails> categoryStockList = InventoryManager.ListAllCargo();

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OceanGate.CargoReport.rdlc";
            ReportDataSource datasource = new ReportDataSource("DataSet1", categoryStockList);
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
