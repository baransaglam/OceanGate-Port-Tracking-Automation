using BLL;
using System;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class EditUserControl1 : UserControl
    {
        private LogManager _logManager;

        public EditUserControl1()
        {
            InitializeComponent();
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox'lardan kullanıcı bilgilerini alıyoruz
                int userId;
                if (!int.TryParse(txt_userID.Text, out userId))
                {
                    MessageBox.Show("Geçerli bir kullanıcı ID'si giriniz.");
                    return;
                }

                string firstName = txtFirstName.Text.Trim(); // FullName
                string lastName = txtLastName.Text.Trim();
                string tcNumber = txtUserIdentity.Text.Trim(); // TCNumber
                string email = txtUserEmail.Text.Trim(); // Email
                string passwordHash = txtUserPassword.Text.Trim(); // PasswordHash

                // ComboBox'tan RoleName'i alıyoruz
                string roleName = cbRoles.SelectedItem?.ToString(); // ComboBox'tan seçilen rol adını alıyoruz
                if (string.IsNullOrEmpty(roleName))
                {
                    MessageBox.Show("Lütfen bir rol seçin.");
                    return;
                }

                int roleId = GetRoleIdByRoleName(roleName); // Rol adını RoleID'ye çeviriyoruz

                // Tüm alanların dolu olup olmadığını kontrol ediyoruz
                if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(tcNumber) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(passwordHash) && !string.IsNullOrEmpty(lastName))
                {
                    UserManager userManager = new UserManager(); // UserManager sınıfından bir nesne oluşturuyoruz
                    bool result = userManager.UpdateUser(userId, firstName, lastName ,tcNumber, email, passwordHash, roleId);

                    if (result)
                    {
                        MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
                        //_logManager.LogAction("Kullanıcı güncellendi : " , "Users");

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Tüm alanları doldurduğunuzdan emin olun.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        // RoleName'den RoleID'yi döndüren metod
        public int GetRoleIdByRoleName(string roleName)
        {
            if (string.IsNullOrEmpty(roleName)) return 0;

            switch (roleName.ToLower())
            {
                case "admin": return 1;
                case "analyst": return 2;
                case "manager": return 3;
                case "operator": return 4;
                case "user": return 5;
                default: return 0;
            }
        }

        private void btn_getByUserID_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı ID'sini txt_userID TextBox'ından alıyoruz
                int userId;
                if (!int.TryParse(txt_userID.Text, out userId))
                {
                    MessageBox.Show("Geçerli bir kullanıcı ID'si giriniz.");
                    return;
                }

                // UserManager sınıfından bir nesne oluşturuyoruz
                UserManager userManager = new UserManager();

                // Kullanıcı bilgilerini alıyoruz
                var user = userManager.GetUserByID(userId);

                // Eğer kullanıcı bulunduysa, TextBox'lara bilgileri yerleştiriyoruz
                if (user != null)
                {
                    txtFirstName.Text = user.FirstName; // Kullanıcının adını txtUserFullName TextBox'ına yazdırıyoruz
                    txtLastName.Text = user.LastName;
                    txtUserIdentity.Text = user.TCNumber; // Kullanıcının TC numarasını txtUserIdentity TextBox'ına yazdırıyoruz
                    txtUserEmail.Text = user.Email; // Kullanıcının e-posta adresini txtUserEmail TextBox'ına yazdırıyoruz
                    txtUserPassword.Text = user.PasswordHash; // Kullanıcının şifresini txtUserPassword TextBox'ına yazdırıyoruz
                    cbRoles.SelectedItem = GetRoleNameById(user.RoleID); // Kullanıcının rolünü combobox'a yazdırıyoruz
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        // RoleID'ye göre rol adı döndüren metod
        private string GetRoleNameById(int roleId)
        {
            switch (roleId)
            {
                case 1: return "Admin";
                case 2: return "Manager";
                case 3: return "Operator";
                case 4: return "Analyst";
                case 5: return "User";
                default: return "Bilinmeyen";
            }
        }
    }
}
