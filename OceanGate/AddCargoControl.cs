using BLL;
using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class AddCargoControl : UserControl
    {
        private BLL.InventoryManager inventoryManager;
        private BLL.ShipManager shipManager;
        private LogManager _logManager;

        public AddCargoControl()
        {
            InitializeComponent();
            inventoryManager = new BLL.InventoryManager();
            shipManager = new BLL.ShipManager();
        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            try
            {
                // Veri doğrulama
                if (string.IsNullOrWhiteSpace(txtCargoDescription.Text) || string.IsNullOrWhiteSpace(txtCargoType.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                if (!decimal.TryParse(txtWeight.Text, out decimal weight))
                {
                    MessageBox.Show("Geçerli bir ağırlık girin.");
                    return;
                }

                if (!int.TryParse(txtUnits.Text, out int units))
                {
                    MessageBox.Show("Geçerli bir birim sayısı girin.");
                    return;
                }

                string cargoDes = txtCargoDescription.Text;
                string cargoType = txtCargoType.Text;
                string orign = txtOrigin.Text;
                string destination = txtDestination.Text;
                string status = txtStatus.Text;
                DateTime deliveryDate = dtDeliveryDate.Value;
                DateTime estimatedDeliveryDate = dtEstimatedDeliveryDate.Value;
                string customsDetails = txtCustomsDetails.Text;
                var movementID = (int)cmbMovement.SelectedValue;
                var shipID = (int)cmbShip.SelectedValue;


                // İşlem çağrısı
                InventoryManager inventoryManager = new InventoryManager();
                inventoryManager.SaveCargo(cargoDes, cargoType, weight, units, orign, destination, status, deliveryDate, estimatedDeliveryDate, customsDetails,shipID, movementID);

                MessageBox.Show("Kargo başarıyla kaydedildi!");
                //_logManager.LogAction("Bir Kargo Eklendi : " , "CargoDetails");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
        private void LoadShips()
        {
            try
            {
                var shipsList = shipManager.GetShips();
                cmbShip.DisplayMember = "ShipName";
                cmbShip.ValueMember = "ShipID";
                cmbShip.DataSource = shipsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Shipleri yükleme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }
        private void LoadMovements()
        {
            try
            {
                var movementsList = shipManager.GetShipMovements();
                cmbMovement.DisplayMember = "MovementID";
                cmbMovement.ValueMember = "MovementID";
                cmbMovement.DataSource = movementsList;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void AddCargoControl_Load(object sender, EventArgs e)
        {
            LoadMovements();
            LoadShips();
        }
    }
}
