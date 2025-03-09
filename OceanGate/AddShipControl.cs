using BLL;
using System;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class AddShipControl : UserControl
    {
        private LogManager _logManager;

        private BLL.ShipManager shipManager;
        public AddShipControl()
        {
            InitializeComponent();
            shipManager = new BLL.ShipManager();
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            string shipName = txtShipName.Text;
            string shipType = txtShipType.Text;
            int shipCapacity = int.Parse(txtCapacity.Text);
            ShipManager shipManager = new ShipManager();
            shipManager.SaveShip(shipName,shipType,shipCapacity);

            // Başarı mesajı
            MessageBox.Show("Gemi başarıyla kaydedildi!");
            //_logManager.LogAction("Gemi eklendi : " , "Ships");

        }
    }
}
