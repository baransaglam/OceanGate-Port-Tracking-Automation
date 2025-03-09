using BLL;
using System;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class ViewUserControl1 : UserControl
    {
        private LogManager _logManager;

        public ViewUserControl1()
        {
            InitializeComponent();
        }

        private void btn_ListUsers_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text; // TextBox kontrolünden veri al
                string lastName = txtFirstName.Text;
                string tcNumber = txtUserIdentity.Text;
                string email = txtUserEmail.Text;

                UserManager userManager = new UserManager();
                var users = userManager.GetUsersByFilter(firstName, lastName,tcNumber, email);

                dgvUsers.DataSource = users;

                //_logManager.LogAction("Tüm Kullanıcılar Listelendi: ","Users");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void btn_GetUser_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(txtUserID.Text);
            string userFullName = txtFirstName.Text;
            string email = txtUserEmail.Text;
            string tcNumber = txtUserIdentity.Text;
            string selectedRole = cbRoles.SelectedItem?.ToString();

        }
    }
}
