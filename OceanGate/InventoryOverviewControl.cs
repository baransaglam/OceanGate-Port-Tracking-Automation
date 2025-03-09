using BLL;
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
    public partial class InventoryOverviewControl : UserControl
    {
        private LogManager _logManager;

        public InventoryOverviewControl()
        {
            InitializeComponent();
        }

        private void btn_ListCargo_Click(object sender, EventArgs e)
        {
            try
            {
                var cargoManager = new InventoryManager();
                var cargo = cargoManager.GetCargo();
                //CustomizeDataGridView();
                dgvCargo.DataSource = cargo;
                //_logManager.LogAction("Tüm Kargolar Listelendi : " , "CargoDetails");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kargoları listeleme sırasında hata oluştu: {ex.Message}");
            }
        }
    }
}
