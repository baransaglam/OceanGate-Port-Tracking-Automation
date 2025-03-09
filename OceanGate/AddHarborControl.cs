using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;
using BLL;
using Microsoft.Win32;

namespace OceanGate
{
    [ComVisible(true)] // COM ile iletişim kurabilmek için
    public partial class AddHarborControl : UserControl
    {
        private BLL.PortManager portManager;
        private LogManager _logManager;


        public AddHarborControl()
        {
            InitializeComponent();
            webBrowser1.ObjectForScripting = this; // JavaScript ile iletişim için
            portManager = new BLL.PortManager();

            // UserControl'ün Load olayına AddHarborControl_Load metodunu bağla
            this.Load += new EventHandler(AddHarborControl_Load);
        }

        private void btn_savePort_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan veriler
            string harborName = txtHarborName.Text;
            string location = txtLocation.Text;
            double? latitude = double.TryParse(txtLatitude.Text, out double lat) ? lat : (double?)null;
            double? longitude = double.TryParse(txtLongitude.Text, out double lon) ? lon : (double?)null;
            int? capacity = int.TryParse(txtCapacity.Text, out int cap) ? cap : (int?)null;

            // Liman kaydını veritabanına kaydet
            portManager.SavePort(harborName, location, latitude, longitude, capacity);
            _logManager.LogAction("Liman Kaydedildi: " + harborName, "Ports");

            MessageBox.Show("Liman kaydedildi!");
        }

        // JavaScript'ten çağrılacak metod
        public void SetLocation(double lat, double lon)
        {
            // Seçilen konum bilgilerini TextBox'lara yazdır
            txtLatitude.Text = lat.ToString();
            txtLongitude.Text = lon.ToString();
        }

        private void btn_setLocation_Click(object sender, EventArgs e)
        {
            // JavaScript ile seçilen konumu al
            webBrowser1.Document.InvokeScript("getSelectedLocation");
        }

        private void AddHarborControl_Load(object sender, EventArgs e)
        {
            string mapFilePath = @"C:\Users\Baran\source\repos\OceanGate\OceanGate\map.html"; // Harita dosyası
            webBrowser1.Navigate("file:///" + mapFilePath.Replace("\\", "/")); // Haritayı yükle

            webBrowser1.Width = this.ClientSize.Width;  // WebBrowser genişliği
            webBrowser1.Height = this.ClientSize.Height; // WebBrowser yüksekliği
            EnableBrowserEmulation();
        }

        public static void EnableBrowserEmulation()
        {
            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            using (var key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION"))
            {
                key.SetValue(appName, 11001, RegistryValueKind.DWord); // IE11 modu
            }
        }

        private void btnAddHarbor_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan bilgileri alıyoruz
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

                // BLL katmanını çağırıyoruz
                PortManager portManager = new PortManager();
                portManager.SavePort(portName, location, latitude, longitude, capacity);

                // Başarı mesajı
                MessageBox.Show("Liman başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösteriliyor
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}





