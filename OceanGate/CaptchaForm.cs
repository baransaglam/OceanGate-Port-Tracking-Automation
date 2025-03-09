using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class CaptchaForm : Form
    {
        private string captchaText;
        public bool IsCaptchaVerified { get; private set; } = false; // Doğrulama durumu

        public CaptchaForm()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            Random random = new Random();
            captchaText = random.Next(1000, 9999).ToString();

            Bitmap bmp = new Bitmap(200, 50);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawString(captchaText, new Font("Arial", 24, FontStyle.Bold), Brushes.Black, new PointF(30, 10));
            }

            piCaptcha.Image = bmp;
        }

        private void recaptchaBtn_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void speechBtn_Click(object sender, EventArgs e)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.Speak(captchaText);
            }
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Text == captchaText)
            {
                MessageBox.Show("Doğru! Robot değilsiniz.");
                IsCaptchaVerified = true; // Doğrulama başarılı
                this.Close(); // Captcha Formunu kapat
            }
            else
            {
                MessageBox.Show("Yanlış! Lütfen tekrar deneyin.");
                IsCaptchaVerified = false; // Doğrulama başarısız
            }
        }
    }
}
