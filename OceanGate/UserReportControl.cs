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
    public partial class UserReportControl : UserControl
    {
        public UserReportControl()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void btn_ListUsers_Click(object sender, EventArgs e)
        {

            reportViewer1.RefreshReport();



            List<Users> categoryStockList = UserManager.ListAllUsers();

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OceanGate.UsersReport.rdlc";
            ReportDataSource datasource = new ReportDataSource("DataSet1", categoryStockList);
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

        }
    }
}
