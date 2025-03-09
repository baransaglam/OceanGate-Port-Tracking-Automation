using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class ViewHarborControl : UserControl
    {
        private LogManager _logManager;

        public ViewHarborControl()
        {
            InitializeComponent();
        }

        private void btn_ListPorts_Click(object sender, EventArgs e)
        {
            try
            {
                var portManager = new PortManager();
                var ports = portManager.GetPorts();
                CustomizeDataGridView();
                dgvPorts.DataSource = ports;
                //_logManager.LogAction("Tüm Limanlar Listelendi : " , "Ports");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Limanları listeleme sırasında hata oluştu: {ex.Message}");
            }
        }

        private void CustomizeDataGridView()
        {
            if (dgvPorts.Columns.Count > 0)
            {
                dgvPorts.Columns["PortID"].HeaderText = "Liman ID";
                dgvPorts.Columns["PortName"].HeaderText = "Liman Adı";
                dgvPorts.Columns["Location"].HeaderText = "Konum";
            }
        }
    }
}
