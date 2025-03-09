using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class ViewShipsControl : UserControl
    {
        private LogManager _logManager;

        public ViewShipsControl()
        {
            InitializeComponent();
        }

        private void btn_ListShips_Click(object sender, EventArgs e)
        {
            try
            {
                var shipManager = new ShipManager();
                var ports = shipManager.GetShips();
                dgvShips.DataSource = ports;
                _logManager.LogAction("Tüm Gemiler Listelendi : " , "Ships");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Limanları listeleme sırasında hata oluştu: {ex.Message}");
                _logManager.LogAction("Tüm Gemileri Listeleme Sırasında bir hata alındı: " , "Ships");

            }
        }
    }
}
