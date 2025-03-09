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
    public partial class DeleteHarborControl : UserControl
    {
        private LogManager _logManager;

        public DeleteHarborControl()
        {
            InitializeComponent();
        }

        private void btnDeleteHarbor_Click(object sender, EventArgs e)
        {
            try
            {
                int portID = Convert.ToInt32(txt_HarborID.Text); // ID alınıyor

               
                var result = MessageBox.Show("Bu limanı silmek istediğinizden emin misiniz?",
                                             "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    PortManager portManager = new PortManager();
                    bool isDeleted = portManager.DeletePortById(portID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Liman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _logManager.LogAction("Bir Liman Silindi: " , "Ports");

                        txt_HarborID.Clear();
                        txt_HarborName.Clear();
                        txt_Location.Clear();
                        txt_Longitude.Clear();
                        txt_Latiude.Clear();
                        txt_Capacity.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Liman silinemedi. Liman bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchByHarborID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_HarborID.Text))
            {
                MessageBox.Show("Liman ID girmeniz gerekmektedir.");
                return;
            }

            try
            {

                int portID = int.Parse(txt_HarborID.Text);


                PortManager portManager = new PortManager();
                var port = portManager.GetPortByID(portID);

                if (port != null)
                {

                    txt_HarborName.Text = port.PortName;
                    txt_Location.Text = port.Location;
                    txt_Capacity.Text = port.Capacity.ToString();
                    txt_Longitude.Text = port.Longitude.ToString();
                    txt_Latiude.Text = port.Latitude.ToString();
                }
                else
                {
                    MessageBox.Show("Liman ID numarasına göre gemi bulunamadı.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir Liman ID numarası giriniz. Sadece sayısal değer kabul edilir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnSearchByHarborName_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_HarborName.Text))
            {
                MessageBox.Show("Liman adını girmeniz gerekmektedir.");
                return;
            }

            try
            {

                string portName = txt_HarborName.Text;

                // ShipManager ile gemiyi arayın.
                PortManager portManager = new PortManager();
                var port = portManager.GetPortByName(portName);

                if (port != null)
                {
                    txt_HarborName.Text = port.PortName;
                    txt_Location.Text = port.Location;
                    txt_Capacity.Text = port.Capacity.ToString();
                    txt_Longitude.Text = port.Longitude.ToString();
                    txt_Latiude.Text = port.Latitude.ToString();
                }
                else
                {
                    MessageBox.Show("Liman adına göre liman bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
 }

