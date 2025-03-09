using System;
using System.Drawing;
using System.Windows.Forms;

namespace OceanGate
{
    public partial class AdminForm : Form
    {
        private int roleID;
        bool sidebarExpand;
        bool userCollapse;
        bool harborCollapse;
        bool shipCollapse;
        bool reportCollapse;
        

        public AdminForm(int userRoleID)
        {
            InitializeComponent();
            roleID = userRoleID;

        }

        private void AdjustPanelsForRole()
        {
            if (roleID == 4) // Analyst rolü
            {
                
                panel15.Visible = false;
                panel7.Visible = false;
                panel6.Visible = false;
                panel3.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
            }

            else if(roleID == 3) // OPERATOR
            {
                panel3.Visible=false;
                panel12.Visible=false;
                panel10.Visible=false;
            }
            
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            AdjustPanelsForRole(); // Panelleri ayarla fonksiyonu burada çağrılır.
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            userTimer.Start();
        }

        private void userTimer_Tick(object sender, EventArgs e)
        {
            int step = 16;
            if (userCollapse)
            {
                UserManagementContainer.Height += step;
                if (UserManagementContainer.Height >= UserManagementContainer.MaximumSize.Height)
                {
                    UserManagementContainer.Height = UserManagementContainer.MaximumSize.Height;
                    userCollapse = false;
                    userTimer.Stop();
                }
            }
            else
            {
                UserManagementContainer.Height -= step;
                if (UserManagementContainer.Height <= UserManagementContainer.MinimumSize.Height)
                {
                    UserManagementContainer.Height = UserManagementContainer.MinimumSize.Height;
                    userCollapse = true;
                    userTimer.Stop();
                }
            }
        }

        private void harborTimer_Tick(object sender, EventArgs e)
        {
            int step = 16;
            if (harborCollapse)
            {
                harborContainer.Height += step;
                if (harborContainer.Height >= harborContainer.MaximumSize.Height)
                {
                    harborContainer.Height = harborContainer.MaximumSize.Height;
                    harborCollapse = false;
                    harborTimer.Stop();
                }
            }
            else
            {
                harborContainer.Height -= step;
                if (harborContainer.Height <= harborContainer.MinimumSize.Height)
                {
                    harborContainer.Height = harborContainer.MinimumSize.Height;
                    harborCollapse = true;
                    harborTimer.Stop();
                }
            }
        }

        private void btnHarborManagement_Click(object sender, EventArgs e)
        {
            harborTimer.Start();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shipTimer_Tick(object sender, EventArgs e)
        {
            int step = 16;
            if (shipCollapse)
            {
                shipContainer.Height += step;
                if (shipContainer.Height >= shipContainer.MaximumSize.Height)
                {
                    shipContainer.Height = shipContainer.MaximumSize.Height;
                    shipCollapse = false;
                    shipTimer.Stop();
                }
            }
            else
            {
                shipContainer.Height -= step;
                if (shipContainer.Height <= shipContainer.MinimumSize.Height)
                {
                    shipContainer.Height = shipContainer.MinimumSize.Height;
                    shipCollapse = true;
                    shipTimer.Stop();
                }
            }
        }

        private void btnShipManagement_Click(object sender, EventArgs e)
        {
            shipTimer.Start();
        }

        private void inventoryTimer_Tick(object sender, EventArgs e)
        {
            int step = 16;
            if (reportCollapse)
            {
                inventoryContainer.Height += step;
                if (inventoryContainer.Height >= inventoryContainer.MaximumSize.Height)
                {
                    inventoryContainer.Height = inventoryContainer.MaximumSize.Height;
                    reportCollapse = false;
                    inventoryTimer.Stop();
                }
            }
            else
            {
                inventoryContainer.Height -= step;
                if (inventoryContainer.Height <= inventoryContainer.MinimumSize.Height)
                {
                    inventoryContainer.Height = inventoryContainer.MinimumSize.Height;
                    reportCollapse = true;
                    inventoryTimer.Stop();
                }
            }
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            inventoryTimer.Start();
        }

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            int step = 16;
            if (reportCollapse)
            {
                reportContainer.Height += step;
                if (reportContainer.Height >= reportContainer.MaximumSize.Height)
                {
                    reportContainer.Height = reportContainer.MaximumSize.Height;
                    reportCollapse = false;
                    reportTimer.Stop();
                }
            }
            else
            {
                reportContainer.Height -= step;
                if (reportContainer.Height <= reportContainer.MinimumSize.Height)
                {
                    reportContainer.Height = reportContainer.MinimumSize.Height;
                    reportCollapse = true;
                    reportTimer.Stop();
                }
            }
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            reportTimer.Start();
        }

        private void LoadPanel(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni kontrolü oluştur
                AddUserControl1 addUserControl = new AddUserControl1();

                // Null veya geçersiz kontrol durumunu kontrol et
                if (addUserControl == null)
                {
                    MessageBox.Show("Kullanıcı ekleme ekranı yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kontrolü panele yükle
                LoadPanel(addUserControl);
            }
            catch (Exception ex)
            {
                // Olası bir hata durumunda kullanıcıya bilgi ver ve hata kaydı al
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Loglama sistemi varsa, hata detaylarını loglayabilirsiniz
                // örn: Logger.LogError(ex);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUserControl1 editUserControl = new EditUserControl1();
            LoadPanel(editUserControl);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUserControl1 deleteUserControl = new DeleteUserControl1();
            LoadPanel(deleteUserControl);
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            ViewUserControl1 viewUserControl = new ViewUserControl1();
            LoadPanel(viewUserControl);
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {
            AddHarborControl addHarborControl = new AddHarborControl();
            LoadPanel(addHarborControl);
        }

        private void btnEditPort_Click(object sender, EventArgs e)
        {
            EditHarborControl editHarborControl = new EditHarborControl();
            LoadPanel(editHarborControl);
        }

        private void btnDeletePort_Click(object sender, EventArgs e)
        {
            DeleteHarborControl deleteHarborControl = new DeleteHarborControl(); 
            LoadPanel(deleteHarborControl);
        }

        private void btnViewPorts_Click(object sender, EventArgs e)
        {
            ViewHarborControl viewHarborControl1 = new ViewHarborControl();
            LoadPanel(viewHarborControl1);
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            AddShipControl addShipControl1 = new AddShipControl();
            LoadPanel(addShipControl1);
        }

        private void btnEditShip_Click(object sender, EventArgs e)
        {
            EditShipControl editShipControl1 = new EditShipControl();
            LoadPanel(editShipControl1);
        }

        private void btnDeleteShip_Click(object sender, EventArgs e)
        {
            DeleteShipControl deleteShipControl1 = new DeleteShipControl();
            LoadPanel(deleteShipControl1);
        }

        private void btnViewShips_Click(object sender, EventArgs e)
        {
            ViewShipsControl viewShipsControl1 = new ViewShipsControl();
            LoadPanel(viewShipsControl1);
        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            AddCargoControl addCargoControl = new AddCargoControl();
            LoadPanel(addCargoControl);
        }

        private void btnEditCargo_Click(object sender, EventArgs e)
        {
            EditCargoControl editCargoControl = new EditCargoControl();
            LoadPanel(editCargoControl);
        }

        private void btnDeleteCargo_Click(object sender, EventArgs e)
        {
            DeleteCargoControl deleteCargoControl = new DeleteCargoControl();
            LoadPanel(deleteCargoControl);
        }

        private void btnInventoryOverview_Click(object sender, EventArgs e)
        {
            InventoryOverviewControl inventoryOverviewControl1 = new InventoryOverviewControl();
            LoadPanel(inventoryOverviewControl1);
        }

        private void btnScheduleShip_Click(object sender, EventArgs e)
        {
            ScheduleShipController scheduleShipController1 = new ScheduleShipController();
            LoadPanel(scheduleShipController1);
        }

        private void btnUserReport_Click(object sender, EventArgs e)
        {
           UserReportControl userReportControl1 = new UserReportControl();
            LoadPanel(userReportControl1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LogControl logControl1 = new LogControl();
            LoadPanel(logControl1);
        }

        private void btnShipReport_Click(object sender, EventArgs e)
        {
            ShipReportControl shipReportControl = new ShipReportControl();
            LoadPanel(shipReportControl);
        }

        private void btnCargoReport_Click(object sender, EventArgs e)
        {
            CargoReportControl cargoReportControl = new CargoReportControl();
            LoadPanel(cargoReportControl);
        }

        private void btnDockReport_Click(object sender, EventArgs e)
        {
            PortReportControl portReportControl = new PortReportControl();
            LoadPanel(portReportControl);
        }
    }
}

