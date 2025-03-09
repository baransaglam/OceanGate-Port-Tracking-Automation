namespace OceanGate
{
    partial class InventoryOverviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addUserPanel = new System.Windows.Forms.Panel();
            this.btn_ListCargo = new System.Windows.Forms.Button();
            this.btn_GetPort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortID = new System.Windows.Forms.TextBox();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.addUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserPanel
            // 
            this.addUserPanel.Controls.Add(this.btn_ListCargo);
            this.addUserPanel.Controls.Add(this.btn_GetPort);
            this.addUserPanel.Controls.Add(this.label4);
            this.addUserPanel.Controls.Add(this.txtPortID);
            this.addUserPanel.Controls.Add(this.dgvCargo);
            this.addUserPanel.Location = new System.Drawing.Point(30, 25);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(939, 652);
            this.addUserPanel.TabIndex = 8;
            // 
            // btn_ListCargo
            // 
            this.btn_ListCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ListCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListCargo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListCargo.ForeColor = System.Drawing.Color.White;
            this.btn_ListCargo.Location = new System.Drawing.Point(429, 589);
            this.btn_ListCargo.Name = "btn_ListCargo";
            this.btn_ListCargo.Size = new System.Drawing.Size(63, 31);
            this.btn_ListCargo.TabIndex = 29;
            this.btn_ListCargo.Text = "List";
            this.btn_ListCargo.UseVisualStyleBackColor = false;
            this.btn_ListCargo.Click += new System.EventHandler(this.btn_ListCargo_Click);
            // 
            // btn_GetPort
            // 
            this.btn_GetPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_GetPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetPort.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GetPort.ForeColor = System.Drawing.Color.White;
            this.btn_GetPort.Location = new System.Drawing.Point(285, 591);
            this.btn_GetPort.Name = "btn_GetPort";
            this.btn_GetPort.Size = new System.Drawing.Size(63, 31);
            this.btn_GetPort.TabIndex = 28;
            this.btn_GetPort.Text = "Get";
            this.btn_GetPort.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(38, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cargo ID:";
            // 
            // txtPortID
            // 
            this.txtPortID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPortID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPortID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtPortID.Location = new System.Drawing.Point(147, 588);
            this.txtPortID.Name = "txtPortID";
            this.txtPortID.Size = new System.Drawing.Size(96, 32);
            this.txtPortID.TabIndex = 17;
            // 
            // dgvCargo
            // 
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Location = new System.Drawing.Point(14, 17);
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.RowHeadersWidth = 51;
            this.dgvCargo.RowTemplate.Height = 24;
            this.dgvCargo.Size = new System.Drawing.Size(911, 540);
            this.dgvCargo.TabIndex = 0;
            // 
            // InventoryOverviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addUserPanel);
            this.Name = "InventoryOverviewControl";
            this.Size = new System.Drawing.Size(1010, 776);
            this.addUserPanel.ResumeLayout(false);
            this.addUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addUserPanel;
        private System.Windows.Forms.Button btn_ListCargo;
        private System.Windows.Forms.Button btn_GetPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortID;
        private System.Windows.Forms.DataGridView dgvCargo;
    }
}
