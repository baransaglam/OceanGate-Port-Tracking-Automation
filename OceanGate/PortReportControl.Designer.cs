namespace OceanGate
{
    partial class PortReportControl
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
            this.btn_ListPorts = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btn_ListPorts
            // 
            this.btn_ListPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_ListPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListPorts.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListPorts.ForeColor = System.Drawing.Color.White;
            this.btn_ListPorts.Location = new System.Drawing.Point(445, 577);
            this.btn_ListPorts.Name = "btn_ListPorts";
            this.btn_ListPorts.Size = new System.Drawing.Size(176, 46);
            this.btn_ListPorts.TabIndex = 15;
            this.btn_ListPorts.Text = "List";
            this.btn_ListPorts.UseVisualStyleBackColor = false;
            this.btn_ListPorts.Click += new System.EventHandler(this.btn_ListPorts_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OceanGate.PortReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(143, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(806, 506);
            this.reportViewer1.TabIndex = 16;
            // 
            // PortReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_ListPorts);
            this.Name = "PortReportControl";
            this.Size = new System.Drawing.Size(1096, 713);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListPorts;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
