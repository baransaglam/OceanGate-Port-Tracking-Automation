namespace OceanGate
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.UserManagementContainer = new System.Windows.Forms.Panel();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userManagementButton = new System.Windows.Forms.PictureBox();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.harborContainer = new System.Windows.Forms.Panel();
            this.btnViewPorts = new System.Windows.Forms.Button();
            this.btnEditPort = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddPort = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnDeletePort = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pcHarbor = new System.Windows.Forms.PictureBox();
            this.btnHarborManagement = new System.Windows.Forms.Button();
            this.shipContainer = new System.Windows.Forms.Panel();
            this.btnScheduleShip = new System.Windows.Forms.Button();
            this.btnViewShips = new System.Windows.Forms.Button();
            this.btnEditShip = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnAddShip = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnDeleteShip = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnShipManagement = new System.Windows.Forms.Button();
            this.inventoryContainer = new System.Windows.Forms.Panel();
            this.btnInventoryOverview = new System.Windows.Forms.Button();
            this.btnEditCargo = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAddCargo = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDeleteCargo = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInventoryManagement = new System.Windows.Forms.Button();
            this.reportContainer = new System.Windows.Forms.Panel();
            this.btnCargoReport = new System.Windows.Forms.Button();
            this.btnShipReport = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnUserReport = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnDockReport = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnReporting = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button12 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.userTimer = new System.Windows.Forms.Timer(this.components);
            this.harborTimer = new System.Windows.Forms.Timer(this.components);
            this.shipTimer = new System.Windows.Forms.Timer(this.components);
            this.inventoryTimer = new System.Windows.Forms.Timer(this.components);
            this.reportTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.UserManagementContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementButton)).BeginInit();
            this.harborContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHarbor)).BeginInit();
            this.shipContainer.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.inventoryContainer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.reportContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sidebar.Controls.Add(this.UserManagementContainer);
            this.sidebar.Controls.Add(this.harborContainer);
            this.sidebar.Controls.Add(this.shipContainer);
            this.sidebar.Controls.Add(this.inventoryContainer);
            this.sidebar.Controls.Add(this.reportContainer);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(278, 776);
            this.sidebar.MinimumSize = new System.Drawing.Size(72, 776);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(278, 776);
            this.sidebar.TabIndex = 0;
            // 
            // UserManagementContainer
            // 
            this.UserManagementContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.UserManagementContainer.Controls.Add(this.btnViewUsers);
            this.UserManagementContainer.Controls.Add(this.btnEditUser);
            this.UserManagementContainer.Controls.Add(this.panel4);
            this.UserManagementContainer.Controls.Add(this.btnDeleteUser);
            this.UserManagementContainer.Controls.Add(this.panel3);
            this.UserManagementContainer.Location = new System.Drawing.Point(3, 3);
            this.UserManagementContainer.MaximumSize = new System.Drawing.Size(275, 252);
            this.UserManagementContainer.MinimumSize = new System.Drawing.Size(275, 71);
            this.UserManagementContainer.Name = "UserManagementContainer";
            this.UserManagementContainer.Size = new System.Drawing.Size(275, 71);
            this.UserManagementContainer.TabIndex = 8;
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnViewUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewUsers.FlatAppearance.BorderSize = 0;
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUsers.Image")));
            this.btnViewUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewUsers.Location = new System.Drawing.Point(0, 202);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(277, 51);
            this.btnViewUsers.TabIndex = 7;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUser.Image")));
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.Location = new System.Drawing.Point(0, 113);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(277, 51);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnAddUser);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(1, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 58);
            this.panel4.TabIndex = 4;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(0, -16);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(277, 74);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = " Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 74);
            this.button3.TabIndex = 4;
            this.button3.Text = "   User Management";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 156);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(277, 51);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userManagementButton);
            this.panel3.Controls.Add(this.btnUserManage);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 80);
            this.panel3.TabIndex = 2;
            // 
            // userManagementButton
            // 
            this.userManagementButton.Image = ((System.Drawing.Image)(resources.GetObject("userManagementButton.Image")));
            this.userManagementButton.Location = new System.Drawing.Point(3, 9);
            this.userManagementButton.Name = "userManagementButton";
            this.userManagementButton.Size = new System.Drawing.Size(56, 56);
            this.userManagementButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userManagementButton.TabIndex = 0;
            this.userManagementButton.TabStop = false;
            this.userManagementButton.Click += new System.EventHandler(this.userManagementButton_Click);
            // 
            // btnUserManage
            // 
            this.btnUserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUserManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUserManage.FlatAppearance.BorderSize = 0;
            this.btnUserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManage.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManage.Location = new System.Drawing.Point(63, 9);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(209, 62);
            this.btnUserManage.TabIndex = 5;
            this.btnUserManage.Text = "User Management";
            this.btnUserManage.UseVisualStyleBackColor = false;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // harborContainer
            // 
            this.harborContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.harborContainer.Controls.Add(this.btnViewPorts);
            this.harborContainer.Controls.Add(this.btnEditPort);
            this.harborContainer.Controls.Add(this.panel6);
            this.harborContainer.Controls.Add(this.btnDeletePort);
            this.harborContainer.Controls.Add(this.panel7);
            this.harborContainer.Location = new System.Drawing.Point(3, 80);
            this.harborContainer.MaximumSize = new System.Drawing.Size(275, 252);
            this.harborContainer.MinimumSize = new System.Drawing.Size(275, 73);
            this.harborContainer.Name = "harborContainer";
            this.harborContainer.Size = new System.Drawing.Size(275, 73);
            this.harborContainer.TabIndex = 9;
            // 
            // btnViewPorts
            // 
            this.btnViewPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnViewPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewPorts.FlatAppearance.BorderSize = 0;
            this.btnViewPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPorts.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewPorts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewPorts.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPorts.Image")));
            this.btnViewPorts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPorts.Location = new System.Drawing.Point(0, 202);
            this.btnViewPorts.Name = "btnViewPorts";
            this.btnViewPorts.Size = new System.Drawing.Size(277, 51);
            this.btnViewPorts.TabIndex = 7;
            this.btnViewPorts.Text = "View Ports";
            this.btnViewPorts.UseVisualStyleBackColor = false;
            this.btnViewPorts.Click += new System.EventHandler(this.btnViewPorts_Click);
            // 
            // btnEditPort
            // 
            this.btnEditPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditPort.FlatAppearance.BorderSize = 0;
            this.btnEditPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPort.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditPort.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPort.Image")));
            this.btnEditPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPort.Location = new System.Drawing.Point(0, 113);
            this.btnEditPort.Name = "btnEditPort";
            this.btnEditPort.Size = new System.Drawing.Size(277, 51);
            this.btnEditPort.TabIndex = 5;
            this.btnEditPort.Text = "Edit Port";
            this.btnEditPort.UseVisualStyleBackColor = false;
            this.btnEditPort.Click += new System.EventHandler(this.btnEditPort_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnAddPort);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(1, 74);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 58);
            this.panel6.TabIndex = 4;
            // 
            // btnAddPort
            // 
            this.btnAddPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPort.FlatAppearance.BorderSize = 0;
            this.btnAddPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPort.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPort.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPort.Image")));
            this.btnAddPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPort.Location = new System.Drawing.Point(0, -16);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(277, 74);
            this.btnAddPort.TabIndex = 3;
            this.btnAddPort.Text = " Add Port";
            this.btnAddPort.UseVisualStyleBackColor = false;
            this.btnAddPort.Click += new System.EventHandler(this.btnAddPort_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(287, 74);
            this.button6.TabIndex = 4;
            this.button6.Text = "   User Management";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnDeletePort
            // 
            this.btnDeletePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeletePort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeletePort.FlatAppearance.BorderSize = 0;
            this.btnDeletePort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePort.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletePort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletePort.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePort.Image")));
            this.btnDeletePort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePort.Location = new System.Drawing.Point(0, 156);
            this.btnDeletePort.Name = "btnDeletePort";
            this.btnDeletePort.Size = new System.Drawing.Size(277, 51);
            this.btnDeletePort.TabIndex = 6;
            this.btnDeletePort.Text = "Delete Port";
            this.btnDeletePort.UseVisualStyleBackColor = false;
            this.btnDeletePort.Click += new System.EventHandler(this.btnDeletePort_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pcHarbor);
            this.panel7.Controls.Add(this.btnHarborManagement);
            this.panel7.Location = new System.Drawing.Point(3, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(275, 74);
            this.panel7.TabIndex = 2;
            // 
            // pcHarbor
            // 
            this.pcHarbor.Image = ((System.Drawing.Image)(resources.GetObject("pcHarbor.Image")));
            this.pcHarbor.Location = new System.Drawing.Point(3, 9);
            this.pcHarbor.Name = "pcHarbor";
            this.pcHarbor.Size = new System.Drawing.Size(56, 56);
            this.pcHarbor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcHarbor.TabIndex = 0;
            this.pcHarbor.TabStop = false;
            // 
            // btnHarborManagement
            // 
            this.btnHarborManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHarborManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHarborManagement.FlatAppearance.BorderSize = 0;
            this.btnHarborManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarborManagement.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarborManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHarborManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHarborManagement.Location = new System.Drawing.Point(60, 9);
            this.btnHarborManagement.Name = "btnHarborManagement";
            this.btnHarborManagement.Size = new System.Drawing.Size(209, 59);
            this.btnHarborManagement.TabIndex = 5;
            this.btnHarborManagement.Text = "Harbor Management";
            this.btnHarborManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHarborManagement.UseVisualStyleBackColor = false;
            this.btnHarborManagement.Click += new System.EventHandler(this.btnHarborManagement_Click);
            // 
            // shipContainer
            // 
            this.shipContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.shipContainer.Controls.Add(this.btnScheduleShip);
            this.shipContainer.Controls.Add(this.btnViewShips);
            this.shipContainer.Controls.Add(this.btnEditShip);
            this.shipContainer.Controls.Add(this.panel14);
            this.shipContainer.Controls.Add(this.btnDeleteShip);
            this.shipContainer.Controls.Add(this.panel15);
            this.shipContainer.Location = new System.Drawing.Point(3, 159);
            this.shipContainer.MaximumSize = new System.Drawing.Size(275, 302);
            this.shipContainer.MinimumSize = new System.Drawing.Size(275, 71);
            this.shipContainer.Name = "shipContainer";
            this.shipContainer.Size = new System.Drawing.Size(275, 71);
            this.shipContainer.TabIndex = 10;
            // 
            // btnScheduleShip
            // 
            this.btnScheduleShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnScheduleShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScheduleShip.FlatAppearance.BorderSize = 0;
            this.btnScheduleShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleShip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnScheduleShip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScheduleShip.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleShip.Image")));
            this.btnScheduleShip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleShip.Location = new System.Drawing.Point(0, 250);
            this.btnScheduleShip.Name = "btnScheduleShip";
            this.btnScheduleShip.Size = new System.Drawing.Size(277, 51);
            this.btnScheduleShip.TabIndex = 8;
            this.btnScheduleShip.Text = "Schedule Ship";
            this.btnScheduleShip.UseVisualStyleBackColor = false;
            this.btnScheduleShip.Click += new System.EventHandler(this.btnScheduleShip_Click);
            // 
            // btnViewShips
            // 
            this.btnViewShips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnViewShips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewShips.FlatAppearance.BorderSize = 0;
            this.btnViewShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewShips.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewShips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewShips.Image = ((System.Drawing.Image)(resources.GetObject("btnViewShips.Image")));
            this.btnViewShips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewShips.Location = new System.Drawing.Point(0, 202);
            this.btnViewShips.Name = "btnViewShips";
            this.btnViewShips.Size = new System.Drawing.Size(277, 51);
            this.btnViewShips.TabIndex = 7;
            this.btnViewShips.Text = "View Ships";
            this.btnViewShips.UseVisualStyleBackColor = false;
            this.btnViewShips.Click += new System.EventHandler(this.btnViewShips_Click);
            // 
            // btnEditShip
            // 
            this.btnEditShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditShip.FlatAppearance.BorderSize = 0;
            this.btnEditShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditShip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditShip.Image = ((System.Drawing.Image)(resources.GetObject("btnEditShip.Image")));
            this.btnEditShip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditShip.Location = new System.Drawing.Point(0, 113);
            this.btnEditShip.Name = "btnEditShip";
            this.btnEditShip.Size = new System.Drawing.Size(277, 51);
            this.btnEditShip.TabIndex = 5;
            this.btnEditShip.Text = "Edit Ship";
            this.btnEditShip.UseVisualStyleBackColor = false;
            this.btnEditShip.Click += new System.EventHandler(this.btnEditShip_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.btnAddShip);
            this.panel14.Controls.Add(this.button9);
            this.panel14.Location = new System.Drawing.Point(1, 74);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(277, 58);
            this.panel14.TabIndex = 4;
            // 
            // btnAddShip
            // 
            this.btnAddShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddShip.FlatAppearance.BorderSize = 0;
            this.btnAddShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddShip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddShip.Image = ((System.Drawing.Image)(resources.GetObject("btnAddShip.Image")));
            this.btnAddShip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddShip.Location = new System.Drawing.Point(0, -16);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(277, 74);
            this.btnAddShip.TabIndex = 3;
            this.btnAddShip.Text = " Add Ship";
            this.btnAddShip.UseVisualStyleBackColor = false;
            this.btnAddShip.Click += new System.EventHandler(this.btnAddShip_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(3, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(287, 74);
            this.button9.TabIndex = 4;
            this.button9.Text = "   User Management";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnDeleteShip
            // 
            this.btnDeleteShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeleteShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteShip.FlatAppearance.BorderSize = 0;
            this.btnDeleteShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteShip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteShip.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteShip.Image")));
            this.btnDeleteShip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteShip.Location = new System.Drawing.Point(0, 156);
            this.btnDeleteShip.Name = "btnDeleteShip";
            this.btnDeleteShip.Size = new System.Drawing.Size(277, 51);
            this.btnDeleteShip.TabIndex = 6;
            this.btnDeleteShip.Text = "Delete Ship";
            this.btnDeleteShip.UseVisualStyleBackColor = false;
            this.btnDeleteShip.Click += new System.EventHandler(this.btnDeleteShip_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.pictureBox4);
            this.panel15.Controls.Add(this.btnShipManagement);
            this.panel15.Location = new System.Drawing.Point(3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(275, 74);
            this.panel15.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btnShipManagement
            // 
            this.btnShipManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnShipManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShipManagement.FlatAppearance.BorderSize = 0;
            this.btnShipManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipManagement.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShipManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShipManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShipManagement.Location = new System.Drawing.Point(60, 9);
            this.btnShipManagement.Name = "btnShipManagement";
            this.btnShipManagement.Size = new System.Drawing.Size(209, 59);
            this.btnShipManagement.TabIndex = 5;
            this.btnShipManagement.Text = "Ship Management";
            this.btnShipManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShipManagement.UseVisualStyleBackColor = false;
            this.btnShipManagement.Click += new System.EventHandler(this.btnShipManagement_Click);
            // 
            // inventoryContainer
            // 
            this.inventoryContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.inventoryContainer.Controls.Add(this.btnInventoryOverview);
            this.inventoryContainer.Controls.Add(this.btnEditCargo);
            this.inventoryContainer.Controls.Add(this.panel8);
            this.inventoryContainer.Controls.Add(this.btnDeleteCargo);
            this.inventoryContainer.Controls.Add(this.panel9);
            this.inventoryContainer.Location = new System.Drawing.Point(3, 236);
            this.inventoryContainer.MaximumSize = new System.Drawing.Size(275, 252);
            this.inventoryContainer.MinimumSize = new System.Drawing.Size(275, 71);
            this.inventoryContainer.Name = "inventoryContainer";
            this.inventoryContainer.Size = new System.Drawing.Size(275, 73);
            this.inventoryContainer.TabIndex = 10;
            // 
            // btnInventoryOverview
            // 
            this.btnInventoryOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInventoryOverview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventoryOverview.FlatAppearance.BorderSize = 0;
            this.btnInventoryOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryOverview.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInventoryOverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventoryOverview.Image = ((System.Drawing.Image)(resources.GetObject("btnInventoryOverview.Image")));
            this.btnInventoryOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryOverview.Location = new System.Drawing.Point(0, 202);
            this.btnInventoryOverview.Name = "btnInventoryOverview";
            this.btnInventoryOverview.Size = new System.Drawing.Size(277, 51);
            this.btnInventoryOverview.TabIndex = 7;
            this.btnInventoryOverview.Text = "   Inventory Overview";
            this.btnInventoryOverview.UseVisualStyleBackColor = false;
            this.btnInventoryOverview.Click += new System.EventHandler(this.btnInventoryOverview_Click);
            // 
            // btnEditCargo
            // 
            this.btnEditCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditCargo.FlatAppearance.BorderSize = 0;
            this.btnEditCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCargo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCargo.Image")));
            this.btnEditCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCargo.Location = new System.Drawing.Point(0, 113);
            this.btnEditCargo.Name = "btnEditCargo";
            this.btnEditCargo.Size = new System.Drawing.Size(277, 51);
            this.btnEditCargo.TabIndex = 5;
            this.btnEditCargo.Text = "Edit Cargo";
            this.btnEditCargo.UseVisualStyleBackColor = false;
            this.btnEditCargo.Click += new System.EventHandler(this.btnEditCargo_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.btnAddCargo);
            this.panel8.Controls.Add(this.button7);
            this.panel8.Location = new System.Drawing.Point(1, 74);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(277, 58);
            this.panel8.TabIndex = 4;
            // 
            // btnAddCargo
            // 
            this.btnAddCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCargo.FlatAppearance.BorderSize = 0;
            this.btnAddCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCargo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCargo.Image")));
            this.btnAddCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCargo.Location = new System.Drawing.Point(0, -16);
            this.btnAddCargo.Name = "btnAddCargo";
            this.btnAddCargo.Size = new System.Drawing.Size(277, 74);
            this.btnAddCargo.TabIndex = 3;
            this.btnAddCargo.Text = "Add Cargo";
            this.btnAddCargo.UseVisualStyleBackColor = false;
            this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(287, 74);
            this.button7.TabIndex = 4;
            this.button7.Text = "   User Management";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCargo
            // 
            this.btnDeleteCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeleteCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteCargo.FlatAppearance.BorderSize = 0;
            this.btnDeleteCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCargo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCargo.Image")));
            this.btnDeleteCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCargo.Location = new System.Drawing.Point(0, 156);
            this.btnDeleteCargo.Name = "btnDeleteCargo";
            this.btnDeleteCargo.Size = new System.Drawing.Size(277, 51);
            this.btnDeleteCargo.TabIndex = 6;
            this.btnDeleteCargo.Text = "Delete Cargo";
            this.btnDeleteCargo.UseVisualStyleBackColor = false;
            this.btnDeleteCargo.Click += new System.EventHandler(this.btnDeleteCargo_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Controls.Add(this.btnInventoryManagement);
            this.panel9.Location = new System.Drawing.Point(3, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(275, 74);
            this.panel9.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInventoryManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventoryManagement.FlatAppearance.BorderSize = 0;
            this.btnInventoryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryManagement.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInventoryManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventoryManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryManagement.Location = new System.Drawing.Point(60, 9);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(209, 59);
            this.btnInventoryManagement.TabIndex = 5;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryManagement.UseVisualStyleBackColor = false;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // reportContainer
            // 
            this.reportContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reportContainer.Controls.Add(this.btnCargoReport);
            this.reportContainer.Controls.Add(this.btnShipReport);
            this.reportContainer.Controls.Add(this.panel11);
            this.reportContainer.Controls.Add(this.btnDockReport);
            this.reportContainer.Controls.Add(this.panel12);
            this.reportContainer.Location = new System.Drawing.Point(3, 315);
            this.reportContainer.MaximumSize = new System.Drawing.Size(275, 252);
            this.reportContainer.MinimumSize = new System.Drawing.Size(275, 75);
            this.reportContainer.Name = "reportContainer";
            this.reportContainer.Size = new System.Drawing.Size(275, 75);
            this.reportContainer.TabIndex = 11;
            // 
            // btnCargoReport
            // 
            this.btnCargoReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCargoReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargoReport.FlatAppearance.BorderSize = 0;
            this.btnCargoReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargoReport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCargoReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargoReport.Image = ((System.Drawing.Image)(resources.GetObject("btnCargoReport.Image")));
            this.btnCargoReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargoReport.Location = new System.Drawing.Point(0, 202);
            this.btnCargoReport.Name = "btnCargoReport";
            this.btnCargoReport.Size = new System.Drawing.Size(277, 51);
            this.btnCargoReport.TabIndex = 7;
            this.btnCargoReport.Text = "       Cargo Report";
            this.btnCargoReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargoReport.UseVisualStyleBackColor = false;
            this.btnCargoReport.Click += new System.EventHandler(this.btnCargoReport_Click);
            // 
            // btnShipReport
            // 
            this.btnShipReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnShipReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShipReport.FlatAppearance.BorderSize = 0;
            this.btnShipReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipReport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShipReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShipReport.Image = ((System.Drawing.Image)(resources.GetObject("btnShipReport.Image")));
            this.btnShipReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShipReport.Location = new System.Drawing.Point(0, 113);
            this.btnShipReport.Name = "btnShipReport";
            this.btnShipReport.Size = new System.Drawing.Size(277, 51);
            this.btnShipReport.TabIndex = 5;
            this.btnShipReport.Text = "   Ship Activity Report";
            this.btnShipReport.UseVisualStyleBackColor = false;
            this.btnShipReport.Click += new System.EventHandler(this.btnShipReport_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.btnUserReport);
            this.panel11.Controls.Add(this.button8);
            this.panel11.Location = new System.Drawing.Point(1, 74);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(277, 58);
            this.panel11.TabIndex = 4;
            // 
            // btnUserReport
            // 
            this.btnUserReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUserReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUserReport.FlatAppearance.BorderSize = 0;
            this.btnUserReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserReport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserReport.Image = ((System.Drawing.Image)(resources.GetObject("btnUserReport.Image")));
            this.btnUserReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserReport.Location = new System.Drawing.Point(0, -16);
            this.btnUserReport.Name = "btnUserReport";
            this.btnUserReport.Size = new System.Drawing.Size(277, 74);
            this.btnUserReport.TabIndex = 3;
            this.btnUserReport.Text = "   User Activity Report";
            this.btnUserReport.UseVisualStyleBackColor = false;
            this.btnUserReport.Click += new System.EventHandler(this.btnUserReport_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(287, 74);
            this.button8.TabIndex = 4;
            this.button8.Text = "   User Management";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnDockReport
            // 
            this.btnDockReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDockReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDockReport.FlatAppearance.BorderSize = 0;
            this.btnDockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDockReport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDockReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDockReport.Image = ((System.Drawing.Image)(resources.GetObject("btnDockReport.Image")));
            this.btnDockReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDockReport.Location = new System.Drawing.Point(0, 156);
            this.btnDockReport.Name = "btnDockReport";
            this.btnDockReport.Size = new System.Drawing.Size(277, 51);
            this.btnDockReport.TabIndex = 6;
            this.btnDockReport.Text = "   Dock Usage Report";
            this.btnDockReport.UseVisualStyleBackColor = false;
            this.btnDockReport.Click += new System.EventHandler(this.btnDockReport_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.pictureBox3);
            this.panel12.Controls.Add(this.btnReporting);
            this.panel12.Location = new System.Drawing.Point(3, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(275, 80);
            this.panel12.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnReporting
            // 
            this.btnReporting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReporting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReporting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(60, 9);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(209, 59);
            this.btnReporting.TabIndex = 5;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.UseVisualStyleBackColor = false;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Location = new System.Drawing.Point(3, 396);
            this.panel2.MaximumSize = new System.Drawing.Size(275, 252);
            this.panel2.MinimumSize = new System.Drawing.Size(275, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 75);
            this.panel2.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pictureBox5);
            this.panel10.Controls.Add(this.button12);
            this.panel10.Location = new System.Drawing.Point(3, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(275, 74);
            this.panel10.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(60, 9);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(209, 59);
            this.button12.TabIndex = 5;
            this.button12.Text = "Logs";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUserManagement);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 57);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = global::OceanGate.Properties.Resources.icons8_user_50;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.Coral;
            this.btnUserManagement.Image = global::OceanGate.Properties.Resources.icons8_user_50;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Location = new System.Drawing.Point(3, 112);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(266, 68);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "             User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "           User Management";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Controls.Add(this.closebtn);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(278, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1010, 776);
            this.panelContainer.TabIndex = 3;
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.closebtn.Location = new System.Drawing.Point(970, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 40);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 8;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // userTimer
            // 
            this.userTimer.Interval = 10;
            this.userTimer.Tick += new System.EventHandler(this.userTimer_Tick);
            // 
            // harborTimer
            // 
            this.harborTimer.Interval = 10;
            this.harborTimer.Tick += new System.EventHandler(this.harborTimer_Tick);
            // 
            // shipTimer
            // 
            this.shipTimer.Interval = 10;
            this.shipTimer.Tick += new System.EventHandler(this.shipTimer_Tick);
            // 
            // inventoryTimer
            // 
            this.inventoryTimer.Interval = 10;
            this.inventoryTimer.Tick += new System.EventHandler(this.inventoryTimer_Tick);
            // 
            // reportTimer
            // 
            this.reportTimer.Interval = 10;
            this.reportTimer.Tick += new System.EventHandler(this.reportTimer_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 776);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.sidebar.ResumeLayout(false);
            this.UserManagementContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userManagementButton)).EndInit();
            this.harborContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcHarbor)).EndInit();
            this.shipContainer.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.inventoryContainer.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.reportContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.PictureBox userManagementButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel UserManagementContainer;
        private System.Windows.Forms.Timer userTimer;
        private System.Windows.Forms.Panel harborContainer;
        private System.Windows.Forms.Button btnViewPorts;
        private System.Windows.Forms.Button btnEditPort;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAddPort;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnDeletePort;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pcHarbor;
        private System.Windows.Forms.Button btnHarborManagement;
        private System.Windows.Forms.Timer harborTimer;
        private System.Windows.Forms.Panel inventoryContainer;
        private System.Windows.Forms.Button btnInventoryOverview;
        private System.Windows.Forms.Button btnEditCargo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAddCargo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnDeleteCargo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInventoryManagement;
        private System.Windows.Forms.Panel reportContainer;
        private System.Windows.Forms.Button btnCargoReport;
        private System.Windows.Forms.Button btnShipReport;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnUserReport;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDockReport;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Panel shipContainer;
        private System.Windows.Forms.Button btnViewShips;
        private System.Windows.Forms.Button btnEditShip;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnDeleteShip;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnShipManagement;
        private System.Windows.Forms.Button btnScheduleShip;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Timer shipTimer;
        private System.Windows.Forms.Timer inventoryTimer;
        private System.Windows.Forms.Timer reportTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button12;
    }
}