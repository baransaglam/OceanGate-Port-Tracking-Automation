namespace OceanGate
{
    partial class ScheduleShipController
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
            this.components = new System.ComponentModel.Container();
            this.addHarborPanel = new System.Windows.Forms.Panel();
            this.btnListMovements = new System.Windows.Forms.Button();
            this.dgvMovements = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.cmbShip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMovement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.oceanGateDBDataSet = new OceanGate.OceanGateDBDataSet();
            this.oceanGateDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addHarborPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanGateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanGateDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addHarborPanel
            // 
            this.addHarborPanel.Controls.Add(this.btnListMovements);
            this.addHarborPanel.Controls.Add(this.dgvMovements);
            this.addHarborPanel.Controls.Add(this.label4);
            this.addHarborPanel.Controls.Add(this.label1);
            this.addHarborPanel.Controls.Add(this.dtpDepartureDate);
            this.addHarborPanel.Controls.Add(this.dtpArrivalDate);
            this.addHarborPanel.Controls.Add(this.cmbPort);
            this.addHarborPanel.Controls.Add(this.cmbShip);
            this.addHarborPanel.Controls.Add(this.label3);
            this.addHarborPanel.Controls.Add(this.btnAddMovement);
            this.addHarborPanel.Controls.Add(this.label2);
            this.addHarborPanel.Location = new System.Drawing.Point(31, 42);
            this.addHarborPanel.Name = "addHarborPanel";
            this.addHarborPanel.Size = new System.Drawing.Size(942, 538);
            this.addHarborPanel.TabIndex = 6;
            // 
            // btnListMovements
            // 
            this.btnListMovements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnListMovements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMovements.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListMovements.ForeColor = System.Drawing.Color.White;
            this.btnListMovements.Location = new System.Drawing.Point(605, 417);
            this.btnListMovements.Name = "btnListMovements";
            this.btnListMovements.Size = new System.Drawing.Size(157, 44);
            this.btnListMovements.TabIndex = 21;
            this.btnListMovements.Text = "List Movements";
            this.btnListMovements.UseVisualStyleBackColor = false;
            this.btnListMovements.Click += new System.EventHandler(this.btnListMovements_Click);
            // 
            // dgvMovements
            // 
            this.dgvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovements.Location = new System.Drawing.Point(417, 18);
            this.dgvMovements.Name = "dgvMovements";
            this.dgvMovements.RowHeadersWidth = 51;
            this.dgvMovements.RowTemplate.Height = 24;
            this.dgvMovements.Size = new System.Drawing.Size(502, 368);
            this.dgvMovements.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(18, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Arrival Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(18, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Departure Date:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(194, 141);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDepartureDate.TabIndex = 17;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(194, 196);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(200, 22);
            this.dtpArrivalDate.TabIndex = 16;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(183, 95);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 24);
            this.cmbPort.TabIndex = 15;
            // 
            // cmbShip
            // 
            this.cmbShip.FormattingEnabled = true;
            this.cmbShip.Location = new System.Drawing.Point(183, 41);
            this.cmbShip.Name = "cmbShip";
            this.cmbShip.Size = new System.Drawing.Size(121, 24);
            this.cmbShip.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = " Port:";
            // 
            // btnAddMovement
            // 
            this.btnAddMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovement.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMovement.ForeColor = System.Drawing.Color.White;
            this.btnAddMovement.Location = new System.Drawing.Point(170, 251);
            this.btnAddMovement.Name = "btnAddMovement";
            this.btnAddMovement.Size = new System.Drawing.Size(157, 44);
            this.btnAddMovement.TabIndex = 10;
            this.btnAddMovement.Text = "Add Movement";
            this.btnAddMovement.UseVisualStyleBackColor = false;
            this.btnAddMovement.Click += new System.EventHandler(this.btnAddMovement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ship:";
            // 
            // oceanGateDBDataSet
            // 
            this.oceanGateDBDataSet.DataSetName = "OceanGateDBDataSet";
            this.oceanGateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oceanGateDBDataSetBindingSource
            // 
            this.oceanGateDBDataSetBindingSource.DataSource = this.oceanGateDBDataSet;
            this.oceanGateDBDataSetBindingSource.Position = 0;
            // 
            // ScheduleShipController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addHarborPanel);
            this.Name = "ScheduleShipController";
            this.Size = new System.Drawing.Size(1004, 622);
            this.Load += new System.EventHandler(this.ScheduleShipController_Load);
            this.addHarborPanel.ResumeLayout(false);
            this.addHarborPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanGateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceanGateDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addHarborPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShip;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMovements;
        private System.Windows.Forms.Button btnListMovements;
        private System.Windows.Forms.BindingSource oceanGateDBDataSetBindingSource;
        private OceanGateDBDataSet oceanGateDBDataSet;
    }
}
