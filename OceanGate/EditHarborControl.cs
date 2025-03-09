using BLL;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanGate
{
    [ComVisible(true)] // COM ile iletişim için
    public partial class EditHarborControl : UserControl
    {
        private LogManager _logManager;

        private BLL.PortManager portManager;

        public EditHarborControl()
        {
            InitializeComponent();
            portManager = new BLL.PortManager();
        }

        // Konum bilgisini alıp TextBox'lara yerleştirme
        public void SetLocation(double lat, double lon)
        {
            txtLatitude.Text = lat.ToString();
            txtLongitude.Text = lon.ToString();
        }

        // Liman bilgilerini güncelleme
        private void btnUpdateHarbor_Click(object sender, EventArgs e)
        {
            try
            {
                int portID = int.Parse(txtHarborID.Text); // Liman ID'si
                string portName = txtHarborName.Text; // Liman adı
                string location = txtLocation.Text; // Lokasyon
                double? latitude = null;
                double? longitude = null;
                int? capacity = null;

                // Latitude ve Longitude parsing
                if (!string.IsNullOrEmpty(txtLatitude.Text) && double.TryParse(txtLatitude.Text, out double parsedLatitude))
                {
                    latitude = parsedLatitude;
                }
                else
                {
                    MessageBox.Show("Geçerli bir enlem değeri girin!");
                    return;
                }

                if (!string.IsNullOrEmpty(txtLongitude.Text) && double.TryParse(txtLongitude.Text, out double parsedLongitude))
                {
                    longitude = parsedLongitude;
                }
                else
                {
                    MessageBox.Show("Geçerli bir boylam değeri girin!");
                    return;
                }

                // Kapasite parsing
                if (!string.IsNullOrEmpty(txtCapacity.Text) && int.TryParse(txtCapacity.Text, out int parsedCapacity))
                {
                    capacity = parsedCapacity;
                }
                else
                {
                    MessageBox.Show("Geçerli bir kapasite değeri girin!");
                    return;
                }

                // Liman bilgilerini güncelleme
                portManager.UpdatePort(portID, portName, location, latitude, longitude, capacity);
                MessageBox.Show("Liman başarıyla güncellendi!");
               // _logManager.LogAction("Liman silinemedi Bulunamadı: ", "Ports");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        

        private void EditHarborControl_Load(object sender, EventArgs e)
        {
            string mapFilePath = @"C:\Users\Baran\source\repos\OceanGate\OceanGate\map.html"; // Harita dosyası
            webBrowser1.Navigate("file:///" + mapFilePath.Replace("\\", "/"));
            webBrowser1.Width = this.ClientSize.Width;
            webBrowser1.Height = this.ClientSize.Height;
            EnableBrowserEmulation();
        }

        public static void EnableBrowserEmulation()
        {
            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            using (var key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION"))
            {
                key.SetValue(appName, 11001, RegistryValueKind.DWord);
            }
        }

      

        private void btnHarborNameSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string harborName = txtHarborName.Text;
                var harbor = portManager.GetPortByName(harborName);

                if (harbor != null)
                {
                    txtHarborID.Text = harbor.PortID.ToString();
                    txtLocation.Text = harbor.Location;
                    txtLatitude.Text = harbor.Latitude.ToString();
                    txtLongitude.Text = harbor.Longitude.ToString();
                    txtCapacity.Text = harbor.Capacity.ToString();

                    // Harita konumunu güncelle ve zoom yap
                    webBrowser1.Document.InvokeScript("setMarkerAndZoom", new object[] { harbor.Latitude, harbor.Longitude });
                }
                else
                {
                    MessageBox.Show("Liman bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void btnHarborIDSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int portID = int.Parse(txtHarborID.Text);
                var harbor = portManager.GetPortByID(portID);

                if (harbor != null)
                {
                    txtHarborName.Text = harbor.PortName;
                    txtLocation.Text = harbor.Location;
                    txtLatitude.Text = harbor.Latitude.ToString();
                    txtLongitude.Text = harbor.Longitude.ToString();
                    txtCapacity.Text = harbor.Capacity.ToString();

                    // Harita konumunu güncelle
                    webBrowser1.Document.InvokeScript("setMarkerAndZoom", new object[] { harbor.Latitude, harbor.Longitude });
                }
                else
                {
                    MessageBox.Show("Liman bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}

