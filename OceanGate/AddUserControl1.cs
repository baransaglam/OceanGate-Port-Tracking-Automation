using System;
using System.Windows.Forms;
using BLL;

namespace OceanGate
{
    public partial class AddUserControl1 : UserControl
    {
        private LogManager _logManager = new LogManager();
        public AddUserControl1()
        {
            InitializeComponent();
        }

        private void btnUserAdder_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string tcNumber = txtUserIdentity.Text;
                string email = txtUserEmail.Text;
                string password = txtUserPassword.Text;
                string selectedRole = cbRoles.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedRole))
                {
                    MessageBox.Show("Lütfen bir rol seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UserManager userManager = new UserManager();
                int roleId = userManager.GetRoleIdByRoleName(selectedRole);

                if (roleId == 0)
                {
                    MessageBox.Show("Geçersiz rol seçildi.");
                    return;
                }

                if (userManager.AddUser(firstName, lastName,tcNumber, email, password, roleId))
                {
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                    _logManager.LogAction("Kullanıcı eklendi : "  , "Users");
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenirken bir hata oluştu.");
                }
            }
            catch (ArgumentException argEx)
            {
                // Kullanıcı hataları için
                MessageBox.Show($"Hata: {argEx.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Genel hata yönetimi
                string errorMessage = $"Hata: {ex.Message} | {ex.StackTrace}";
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AddUserControl1_Load(object sender, EventArgs e)
        {
            // Load olayında yapılacak işlemler buraya eklenebilir
        }
    }
}

