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
    public partial class DeleteUserControl1 : UserControl
    {
        private LogManager _logManager;

        public DeleteUserControl1()
        {
            InitializeComponent();
        }

        private void btn_getUserByID_Click(object sender, EventArgs e)
        {
            int userID;
            if (int.TryParse(txt_userID.Text, out userID)) // txt_userID: Kullanıcı ID'sini gireceğimiz TextBox
            {
                UserManager userManager = new UserManager();
                var user = userManager.GetUserByID(userID);

                if (user != null)
                {
                    // Kullanıcı bulunduğunda, ilgili bilgilere ulaşarak TextBox'lara yazdırıyoruz
                    txtFirstName.Text = user.FirstName; // txtUserFullName: Ad bilgisi için TextBox
                    txtLastName.Text = user.LastName;
                    txtUserIdentity.Text = user.TCNumber; // txtUserIdentity: TC numarası bilgisi için TextBox
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir ID giriniz.");
            }
        }

        private void userDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(txt_userID.Text); // ID alınıyor

                // Kullanıcıyı silmeden önce onay alın
                var result = MessageBox.Show("Bu kullanıcıyı silmek istediğinizden emin misiniz?",
                                             "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    UserManager userManager = new UserManager();
                    bool isDeleted = userManager.DeleteUserById(userId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //_logManager.LogAction("Kullanıcı silindi : " , "Users");

                        txt_userID.Clear();
                       txtFirstName.Clear();
                        txtLastName.Clear();
                        txtUserIdentity.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinemedi. Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_getUserByIdentity_Click(object sender, EventArgs e)
        {
            string identity = txtUserIdentity.Text.Trim(); // Kimlik numarasını txt_userIdentity TextBox'ından alıyoruz
            if (!string.IsNullOrEmpty(identity)) // Kimlik numarasının boş olmadığını kontrol ediyoruz
            {
                try
                {
                    UserManager userManager = new UserManager(); // UserManager sınıfından bir nesne oluşturuyoruz
                    var user = userManager.GetUserByIdentity(identity); // Kimlik numarasına göre kullanıcıyı alıyoruz

                    if (user != null) // Kullanıcı bulunduysa
                    {
                        // Kullanıcıyı bulduğumuzda bilgileri ilgili TextBox'lara yerleştiriyoruz
                        txtFirstName.Text = user.FirstName; // Kullanıcının adını txtUserFullName TextBox'ına yazdırıyoruz
                        txtLastName.Text = user.LastName;
                        txt_userID.Text = user.UserID.ToString(); // Kullanıcı ID'sini txt_userID TextBox'ına yazdırıyoruz
                        txtUserIdentity.Text = user.TCNumber; // Kimlik numarasını txt_userIdentity TextBox'ına yazdırıyoruz
                    }
                    else // Kullanıcı bulunamadığında
                    {
                        MessageBox.Show("Kimlik numarasına ait kullanıcı bulunamadı.");
                    }
                }
                catch (Exception ex) // Herhangi bir hata durumunda
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}"); // Hata mesajını ekranda gösteriyoruz
                }
            }
            else
            {
                // Kimlik numarası boşsa kullanıcıyı uyarıyoruz
                MessageBox.Show("Kimlik numarasını girmeniz gerekmektedir.");
            }
        }

    }
}
