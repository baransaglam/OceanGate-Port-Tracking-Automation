
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace OceanGate
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtKimlik.BackColor = Color.White;
            panel3.BackColor=Color.White;
            panel4.BackColor=SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel4.BackColor=Color.White;
            txtKimlik.BackColor=SystemColors.Control;
            panel3.BackColor=SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string tcNo = txtKimlik.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("TC Kimlik Numarası ve Şifre boş bırakılamaz.");
                    return;
                }

                UserManager loginUser = new UserManager();
                int userRoleID = loginUser.GetUserRole(tcNo, password);

                if (userRoleID == 1)
                {
                    MessageBox.Show("Admin giriş başarılı!");
                    AdminForm adminForm = new AdminForm(userRoleID); 
                    adminForm.Show();
                }
                else if (userRoleID == 4)
                {
                    MessageBox.Show("Analyst giriş başarılı!");
                    AdminForm adminForm = new AdminForm(userRoleID); 
                    adminForm.Show();
                }
                else if (userRoleID == 2)
                {
                    MessageBox.Show("Manager giriş başarılı!");
                    AdminForm adminForm = new AdminForm(userRoleID); 
                    adminForm.Show();
                }
                else if (userRoleID ==3)
                {
                    MessageBox.Show("Operator giriş başarılı!");
                    AdminForm adminForm = new AdminForm(userRoleID); 
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Giriş bilgileri hatalı veya yetkisiz kullanıcı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
