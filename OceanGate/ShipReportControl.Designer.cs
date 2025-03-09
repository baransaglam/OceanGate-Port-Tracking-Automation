namespace OceanGate
{
    partial class ShipReportControl
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
            this.btn_ListShips = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btn_ListShips
            // 
            this.btn_ListShips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ListShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListShips.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListShips.ForeColor = System.Drawing.Color.White;
            this.btn_ListShips.Location = new System.Drawing.Point(417, 571);
            this.btn_ListShips.Name = "btn_ListShips";
            this.btn_ListShips.Size = new System.Drawing.Size(176, 46);
            this.btn_ListShips.TabIndex = 14;
            this.btn_ListShips.Text = "List";
            this.btn_ListShips.UseVisualStyleBackColor = false;
            this.btn_ListShips.Click += new System.EventHandler(this.btn_ListShips_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OceanGate.ShipReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(137, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(753, 466);
            this.reportViewer1.TabIndex = 15;
            // 
            // ShipReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_ListShips);
            this.Name = "ShipReportControl";
            this.Size = new System.Drawing.Size(1096, 713);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListShips;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
