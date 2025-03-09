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
    public partial class DeleteCargoControl : UserControl
    {
        private LogManager _logManager;

        public DeleteCargoControl()
        {
            InitializeComponent();
        }

        private void btnDeleteCargo_Click(object sender, EventArgs e)
        {
            try
            {
                int cargoId = Convert.ToInt32(txtCargoID.Text); // ID alınıyor

                // Kullanıcıyı silmeden önce onay alın
                var result = MessageBox.Show("Bu Kargoyu silmek istediğinizden emin misiniz?",
                                             "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    InventoryManager inventoryManager = new InventoryManager();
                    bool isDeleted = inventoryManager.DeleteCargoById(cargoId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Kargo başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //_logManager.LogAction("Kargo Silindi : " + txtCargoName.Text, "CargoDetails");

                        txtCargoID.Clear();
                        txtCargoName.Clear();
                        txtCargoType.Clear();
                        txtCustomsDetails.Clear();
                        txtDestination.Clear();
                        txtOrigin.Clear();
                        txtStatus.Clear();
                        txtWeight.Clear();
                        txtUnits.Clear();
                        dtDeliveryDate.Value = DateTime.Now;
                        dtEstimatedDeliveryDate.Value = DateTime.Now;

                    }
                    else
                    {
                        MessageBox.Show("Kargo silinemedi. kargo bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargoNameSearch_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryManager inventoryManager = new InventoryManager();
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
                    MessageBox.Show("Gemi bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
