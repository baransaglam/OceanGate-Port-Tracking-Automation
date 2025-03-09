using BLL;
using OceanGate.tcKimlikDogrula;
using System;

using System.Windows.Forms;

namespace OceanGate
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
            btnKullaniciKayit.Enabled = false; // Buton başlangıçta devre dışı
        }

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            long TcKimlikNo = Convert.ToInt64(txtKimlik.Text);
            string Ad = txtAd.Text.ToUpper();
            string Soyad = txtSoyad.Text.ToUpper();
            int DogumYili = Convert.ToInt32(txtYas.Text);
            string password = txtSifre.Text;
            string email = txtEposta.Text;
            KPSPublicSoapClient servis = new KPSPublicSoapClient();

            bool sonuc = servis.TCKimlikNoDogrula(TcKimlikNo, Ad, Soyad, DogumYili);
            if (sonuc == true)
            {
                UserManager userManager = new UserManager();
                MessageBox.Show("Kullanıcı gerçek kişi", "Doğrulama başarılı!! , Giriş Sayfasına Yönlendiriliyor");
                userManager.AddUser(Ad, Soyad, TcKimlikNo.ToString(), email, password, 2);
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz Kimlik Numarası", "Doğrulama başarısız!!");
                CleaneAllTextBox();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CleaneAllTextBox()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtKimlik.Clear();
            txtSifre.Clear();
            txtEposta.Clear();
        }

        private void btn_Captcha_Click(object sender, EventArgs e)
        {
            CaptchaForm captchaForm = new CaptchaForm();

            // Modal olarak Captcha formunu göster
            captchaForm.ShowDialog();

            // Captcha doğrulandıysa Kullanıcı Kayıt butonunu aktif et
            if (captchaForm.IsCaptchaVerified)
            {
                btnKullaniciKayit.Enabled = true; // Buton aktif hale gelir
            }
            else
            {
                MessageBox.Show("Captcha doğrulaması başarısız. Lütfen tekrar deneyin.");
                btnKullaniciKayit.Enabled = false; // Buton aktif edilmez
            }
        }
    }
}

