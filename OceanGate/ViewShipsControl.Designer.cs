namespace OceanGate
{
    partial class ViewShipsControl
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
            this.btn_ListShips = new System.Windows.Forms.Button();
            this.btn_GetPShip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShipID = new System.Windows.Forms.TextBox();
            this.dgvShips = new System.Windows.Forms.DataGridView();
            this.addUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserPanel
            // 
            this.addUserPanel.Controls.Add(this.btn_ListShips);
            this.addUserPanel.Controls.Add(this.btn_GetPShip);
            this.addUserPanel.Controls.Add(this.label4);
            this.addUserPanel.Controls.Add(this.txtShipID);
            this.addUserPanel.Controls.Add(this.dgvShips);
            this.addUserPanel.Location = new System.Drawing.Point(24, 12);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(939, 652);
            this.addUserPanel.TabIndex = 8;
            // 
            // btn_ListShips
            // 
            this.btn_ListShips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ListShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListShips.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListShips.ForeColor = System.Drawing.Color.White;
            this.btn_ListShips.Location = new System.Drawing.Point(428, 591);
            this.btn_ListShips.Name = "btn_ListShips";
            this.btn_ListShips.Size = new System.Drawing.Size(63, 31);
            this.btn_ListShips.TabIndex = 29;
            this.btn_ListShips.Text = "List";
            this.btn_ListShips.UseVisualStyleBackColor = false;
            this.btn_ListShips.Click += new System.EventHandler(this.btn_ListShips_Click);
            // 
            // btn_GetPShip
            // 
            this.btn_GetPShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_GetPShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetPShip.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GetPShip.ForeColor = System.Drawing.Color.White;
            this.btn_GetPShip.Location = new System.Drawing.Point(262, 591);
            this.btn_GetPShip.Name = "btn_GetPShip";
            this.btn_GetPShip.Size = new System.Drawing.Size(63, 31);
            this.btn_GetPShip.TabIndex = 28;
            this.btn_GetPShip.Text = "Get";
            this.btn_GetPShip.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(38, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ship ID:";
            // 
            // txtShipID
            // 
            this.txtShipID.BackColor = System.Drawing.SystemColors.Control;
            this.txtShipID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShipID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtShipID.Location = new System.Drawing.Point(125, 588);
            this.txtShipID.Name = "txtShipID";
            this.txtShipID.Size = new System.Drawing.Size(96, 32);
            this.txtShipID.TabIndex = 17;
            // 
            // dgvShips
            // 
            this.dgvShips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShips.Location = new System.Drawing.Point(16, 19);
            this.dgvShips.Name = "dgvShips";
            this.dgvShips.RowHeadersWidth = 51;
            this.dgvShips.RowTemplate.Height = 24;
            this.dgvShips.Size = new System.Drawing.Size(911, 540);
            this.dgvShips.TabIndex = 0;
            // 
            // ViewShipsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addUserPanel);
            this.Name = "ViewShipsControl";
            this.Size = new System.Drawing.Size(1010, 776);
            this.addUserPanel.ResumeLayout(false);
            this.addUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addUserPanel;
        private System.Windows.Forms.Button btn_ListShips;
        private System.Windows.Forms.Button btn_GetPShip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShipID;
        private System.Windows.Forms.DataGridView dgvShips;
    }
}
