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
    public partial class EditShipControl : UserControl
    {
        private LogManager _logManager;

        private BLL.ShipManager shipManager;
        public EditShipControl()
        {
            InitializeComponent();
            shipManager = new BLL.ShipManager();
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            int shipID = int.Parse(txtShipID.Text);
            string shipName = txtShipName.Text;
            string shipType = txtShipType.Text;
            int capacity = int.Parse(txtCapacity.Text);

            shipManager.UpdateShip(shipID, shipName,shipType,capacity);
            MessageBox.Show("Gemi başarıyla güncellendi!");
            _logManager.LogAction("Gemi güncellendi : " + shipName, "Ships");

        }

        private void btnShipNameSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string shipName = txtShipName.Text;
                var ship = shipManager.GetShipByName(shipName);

                if (ship != null)
                {
                    txtShipID.Text = ship.ShipID.ToString();
                    txtShipName.Text = ship.ShipName;
                    txtShipType.Text = ship.ShipType;
                    txtCapacity.Text = ship.Capacity.ToString();
                    _logManager.LogAction("Gemi Adıyla Aratıldı : " + shipName, "Ships");
                }
                else
                {
                    MessageBox.Show("Gemi bulunamadı!");
                    _logManager.LogAction("Gemi Adı ile bulunamadı : " + ship.ShipName, "Ships");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
                _logManager.LogAction("Gemi Adı ile bulunmada Hata alındı : ", "Ships");

            }
        }

        private void btnShipIDSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int shipID = int.Parse(txtShipID.Text);
                var ship = shipManager.GetShipByID(shipID);

                if (ship != null)
                {
                    txtShipName.Text = ship.ShipName;
                    txtShipType.Text = ship.ShipType;
                    txtCapacity.Text = ship.Capacity.ToString();

                    MessageBox.Show("Gemi bulundu!");
                    //_logManager.LogAction("Gemi ID ile Aratıldı : " + ship.ShipName, "Ships");

                }
                else
                {
                    MessageBox.Show("Gemi bulunamadı!");
                    _logManager.LogAction("Gemi ID ile bulunamadı : " + ship.ShipName, "Ships");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
                _logManager.LogAction("Gemi ID ile bulunmada Hata alındı : " , "Ships");
            }
        }
    }
}
