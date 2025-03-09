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
    public partial class EditCargoControl : UserControl
    {
        private LogManager _logManager;
        private BLL.InventoryManager inventoryManager;
        private BLL.ShipManager shipManager;
        public EditCargoControl()
        {
            InitializeComponent();
            inventoryManager = new BLL.InventoryManager();
            shipManager = new BLL.ShipManager();
        }

        private void btnUpdateCargo_Click(object sender, EventArgs e)
        {
           
            string cargoName = txtCargoName.Text;
            string cargoType = txtCargoType.Text;
            decimal weight = Decimal.Parse(txtWeight.Text);
            int units = Convert.ToInt32(txtUnits.Text);
            string origin = txtOrigin.Text;
            string destination = txtDestination.Text;
            string status = txtStatus.Text;
            DateTime deliveryDate = dtDeliveryDate.Value;
            DateTime estimatedDeliveryDate =dtEstimatedDeliveryDate.Value;
            string CustomsDetails = txtCustomsDetails.Text;
            int cargoID = int.Parse(txtCargoID.Text);
            int shipID = Convert.ToInt32(cmbShip.SelectedValue);
            int movementID = Convert.ToInt32(cmbMovement.Text);

            inventoryManager.UpdateCargo(cargoName,cargoType,weight,units,origin,destination,status,deliveryDate,estimatedDeliveryDate,CustomsDetails,shipID,movementID,cargoID);
            MessageBox.Show("Kargo başarıyla güncellendi!");
            //_logManager.LogAction("Kargo Güncellendi : " +cargoName, "CargoDetails");
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

        private void btnCargoNameSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string cargoName = txtCargoName.Text;
                var cargo = inventoryManager.GetCargoByName(cargoName);

                if (cargo != null)
                {
                 txtCargoType.Text = cargo.CargoType;
                 txtWeight.Text = cargo.Weight.ToString();
                 txtUnits.Text = cargo.Units.ToString();
                 txtOrigin.Text = cargo.Origin;
                 txtDestination.Text = cargo.Destination;
                 txtStatus.Text = cargo.Status;
                 dtDeliveryDate.Value = (DateTime)cargo.DeliveryDate;
                 dtEstimatedDeliveryDate.Value = (DateTime)cargo.EstimatedDeliveryDate;

                }
                else
                {
                    MessageBox.Show("Kargo bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void EditCargoControl_Load(object sender, EventArgs e)
        {
            LoadShips();
            LoadMovements();
        }
    }
}
