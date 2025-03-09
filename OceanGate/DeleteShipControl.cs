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
    public partial class DeleteShipControl : UserControl
    {
        private LogManager _logManager;

        public DeleteShipControl()
        {
            InitializeComponent();
        }

        public void btnDeleteShip_Click(object sender, EventArgs e)
        {
            try
            {
                int shipId = Convert.ToInt32(txtShipID.Text); // ID alınıyor

                // Kullanıcıyı silmeden önce onay alın
                var result = MessageBox.Show("Bu gemiyi silmek istediğinizden emin misiniz?",
                                             "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ShipManager shipManager = new ShipManager();
                    bool isDeleted = shipManager.DeleteShipById(shipId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Gemi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //_logManager.LogAction("Bir Gemi Silindi : ", "Ships");

                        txtShipID.Clear();
                        txtShipName.Clear();
                        txtShipType.Clear();
                        txtCapacity.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Gemi silinemedi. Gemi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //_logManager.LogAction("Bir Gemi Bulunamadığı için Silinemedi  : ", "Ships");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //_logManager.LogAction("Bir Gemi Silme işleminde hata oluştu : ", "Ships");

            }
        }

        public void btnShipIDSearch_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtShipID.Text))
            {
                MessageBox.Show("Gemi ID girmeniz gerekmektedir.");
               // _logManager.LogAction("Gemi Silme işleminde ID ile Gemi arama sırasında geçersiz bir gemi ID girildi  : ", "Ships");

                return;
            }

            try
            {
                
                int shipID = int.Parse(txtShipID.Text);

                
                ShipManager shipManager = new ShipManager();
                var ship = shipManager.GetShipByID(shipID);

                if (ship != null)
                {
                  
                    txtShipName.Text = ship.ShipName;
                    txtShipType.Text = ship.ShipType;
                    txtCapacity.Text = ship.Capacity.ToString(); 
                }
                else
                {
                    MessageBox.Show("Gemi ID numarasına göre gemi bulunamadı.");
                   // _logManager.LogAction("ID Numarasına göre gemi bulunamadı geçersiz gemi IDsi girildi : ", "Ships");

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir Gemi ID numarası giriniz. Sadece sayısal değer kabul edilir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        public void btnShipNameSearch_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtShipName.Text))
            {
                MessageBox.Show("Gemi adını girmeniz gerekmektedir.");
                return;
            }

            try
            {
                
                string shipName = txtShipName.Text;

                // ShipManager ile gemiyi arayın.
                ShipManager shipManager = new ShipManager();
                var ship = shipManager.GetShipByName(shipName);

                if (ship != null)
                {
                    // Gemi bilgilerini doldurun.
                    txtShipID.Text = ship.ShipID.ToString(); 
                    txtShipType.Text = ship.ShipType;
                    txtCapacity.Text = ship.Capacity.ToString(); 
                }
                else
                {
                    MessageBox.Show("Gemi adına göre gemi bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
